@ECHO OFF
ECHO Demo Automation Executed Started.


set dllpath=C:\Users\CA\source\repos\SeleniumQuiz\SeleniumQuiz\bin\Debug\SeleniumQuiz.dll
set trxerpath=C:\Users\CA\source\repos\SeleniumQuiz\SeleniumQuiz\bin\Debug
set SummaryReportPath=C:\Users\CA\source\repos\SeleniumQuiz\Report\MSTest\

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET filename=%testcategory%_%DTS:~0,4%%DTS:~4,2%%DTS:~6,2%%DTS:~8,2%%DTS:~10,2%%DTS:~12,2%
echo %filename%

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%SummaryReportPath%\%filename%.trx"

cd %trxerpath%

TrxToHTML.exe %SummaryReportPath%\

PAUSE