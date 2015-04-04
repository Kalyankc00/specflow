set FileName=%DATE:/=-%@%TIME::=-%
set ResultTRX=TestResults%FileName: =%.trx
set ResultHTML=TestResults%FileName: =%.html

echo %ResultTRX%
echo %ResultHTML%
c:
cd C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE
mstest.exe /testcontainer:%~dp0SpecflowTrainingSpecs\bin\Debug\SpecflowTrainingSpecs.dll /resultsfile:%~dp0TestResults\%ResultTRX% 
e:
cd %~dp0packages\SpecFlow.1.9.0\tools
SpecFlow.exe mstestexecutionreport %~dp0SpecflowTrainingSpecs\SpecflowTrainingSpecs.csproj /testResult:%~dp0TestResults\%ResultTRX% /out:%~dp0TestResults\%ResultHTML%

echo Created file %ResultHTML%
