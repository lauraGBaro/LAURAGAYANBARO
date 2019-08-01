cd C:\Users\gteam\source\repos\LAURAGAYANBARO
SonarScanner.MSBuild.exe begin /k:"proyectoFinal" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="6e18bd539bfcab2f38bd7c4b2f7f81c0f599468e"
pause
MsBuild.exe /t:Rebuild
pause
SonarScanner.MSBuild.exe end /d:sonar.login="6e18bd539bfcab2f38bd7c4b2f7f81c0f599468e"
pause
