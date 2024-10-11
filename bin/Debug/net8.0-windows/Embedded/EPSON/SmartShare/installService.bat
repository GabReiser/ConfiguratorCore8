@echo off
:: BatchGotAdmin
:-------------------------------------
REM  --> Check for permissions
>nul 2>&1 "%SYSTEMROOT%\system32\cacls.exe" "%SYSTEMROOT%\system32\config\system"

REM --> If error flag set, we do not have admin.
if '%errorlevel%' NEQ '0' (
    echo Requesting administrative privileges...
    goto UACPrompt
) else ( goto gotAdmin )

:UACPrompt
    echo Set UAC = CreateObject^("Shell.Application"^) > "%temp%\getadmin.vbs"
    set params = %*:"=""
    echo UAC.ShellExecute "cmd.exe", "/c %~s0 %params%", "", "runas", 1 >> "%temp%\getadmin.vbs"

    "%temp%\getadmin.vbs"
    del "%temp%\getadmin.vbs"
    exit /B

:gotAdmin
    pushd "%CD%"
    CD /D "%~dp0"
:--------------------------------------

:: Obtenha o caminho do diretório do script
for %%I in ("%~dp0") do set "script_dir=%%~fI"
echo Diretório do script: %script_dir%

:: Pergunte ao usuário se ele quer instalar ou desinstalar
set /p action="Você quer instalar ou desinstalar? (i/d) "

if /I "%action%"=="i" (
    :: Verifique se o arquivo smartshare-app já foi extraído
    if not exist "%script_dir%\smartshare-app\" (
        :: Extraia o arquivo zip do front-end
        echo Extraindo o arquivo zip do front-end...
        powershell -command "Expand-Archive -Path '%script_dir%\smartshare-app.zip' -DestinationPath '%script_dir%'"
    ) else (
        echo O arquivo smartshare-app já foi extraído.
    )

    :: Verifique se o diretório C:\inetpub\wwwroot existe e crie-o se não existir
    if not exist "C:\inetpub\wwwroot\" (
        echo Criando o diretório C:\inetpub\wwwroot...
        mkdir "C:\inetpub\wwwroot"
    )
    :: Copie a pasta do front-end extraída para C:\inetpub\wwwroot com o nome de smartshare-app
    echo Copiando a pasta do front-end para C:\inetpub\wwwroot...
    xcopy /E /I "%script_dir%\smartshare-app" "C:\inetpub\wwwroot\smartshare-app"

    :: Copie o .jar, o .exe e o .xml do diretório do script para o disco local C em uma nova pasta chamada SmartShare Embedded
    echo Copiando os arquivos para C:\SmartShare Embedded...
    if not exist "C:\SmartShare-Embedded\" mkdir "C:\SmartShare-Embedded"
    copy "%script_dir%\epson-smartshare-service.jar" "C:\SmartShare-Embedded"
    copy "%script_dir%\epson-smartshare-service.exe" "C:\SmartShare-Embedded"
    copy "%script_dir%\epson-smartshare-service.xml" "C:\SmartShare-Embedded"

    :: Execute o comando para instalar o serviço
    echo Instalando o serviço...
    cd /d "C:\SmartShare-Embedded"
    cmd /k epson-smartshare-service.exe install service
) else if /I "%action%"=="d" (
    :: Desinstale o serviço
    echo Desinstalando o serviço...
    cd /d "C:\SmartShare-Embedded"
    cmd /k epson-smartshare-service.exe uninstall service

    echo Serviço desinstalado.

    :: Remova a pasta do front-end de C:\inetpub\wwwroot
    echo Removendo a pasta do front-end de C:\inetpub\wwwroot...
    rmdir /S /Q "C:\inetpub\wwwroot\smartshare-app"

    :: Remova os arquivos de C:\SmartShare Embedded
    echo Removendo os arquivos de C:\SmartShare Embedded...
    rmdir /S /Q "C:\SmartShare-Embedded"
)

endlocal