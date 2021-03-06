nuget install xunit.runner.console -OutputDirectory packages -Version 2.3.1
    
nuget install OpenCover -OutputDirectory packages -Version 4.6.519
    
dotnet tool install coveralls.net --version 1.0.0 --tool-path tools
    
dotnet --version
    
.\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -register:user -target:"C:\Program Files\dotnet\dotnet.exe" "-targetargs:"".\packages\xunit.runner.console.2.3.1\tools\netcoreapp2.0\xunit.console.dll"" ""DiscordBotCore.xUnit.Tests\bin\Release\netcoreapp2.0\DiscordBotCore.xUnit.Tests.dll"" -noshadow -appveyor" -filter:"+[DiscordBotCore*]* -[DiscordBotCore*]*Tests.*" -oldStyle -output:opencoverCoverage.xml
    
$coveralls = ".\tools\csmacnz.coveralls.exe"
    
& $coveralls --opencover -i opencoverCoverage.xml --repoToken $env:COVERALLS_REPO_TOKEN --commitId $env:APPVEYOR_REPO_COMMIT --commitBranch $env:APPVEYOR_REPO_BRANCH --commitAuthor $env:APPVEYOR_REPO_COMMIT_AUTHOR --commitEmail $env:APPVEYOR_REPO_COMMIT_AUTHOR_EMAIL --commitMessage $env:APPVEYOR_REPO_COMMIT_MESSAGE --jobId $env:APPVEYOR_JOB_ID