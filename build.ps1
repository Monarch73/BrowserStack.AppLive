#! /usr/bin/env pwsh
param(
    [Parameter(Mandatory = $false)][string] $Configuration = "Release",
    [Parameter(Mandatory = $false)][string] $OutputPath = "",
    [Parameter(Mandatory = $false)][switch] $SkipTests
)

$solutionPath = Split-Path $MyInvocation.MyCommand.Definition
$solutionFile = Join-Path $solutionPath "Monarch73.BrowserStack.AppLive.sln"
$sdkFile = Join-Path $solutionPath "global.json"
$dotnet = Join-Path "$env:DOTNET_INSTALL_DIR" "dotnet"
& $dotnet build $solutionFile --output $OutputPath --configuration $Configuration
& $dotnet pack $solutionFile --output (Join-Path $OutputPath "packages") --configuration $Configuration --include-symbols --include-source
