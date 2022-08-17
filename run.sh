# This script to be used only for local building and testing on Mac/Linux with .net core
# This should be run from the agents/dotnet-core-agent directory.
# Prequisite: Install .NET (https://docs.microsoft.com/en-us/dotnet/core/install/macos)

# Delete logs from previous run.

# Build
# dotnet clean
dotnet build

# Inject the agent
# Note: Since 5.0 is not supported on mac, using the path to net6.0 here. Need to change in csproj files and build for v6.0 when building locally.
dotnet /Users/jamie/Downloads/test/dotnet-agent.injector.dll /Users/jamie/dotnet-testproject/bin/Debug/net6.0/TestProject1.dll /tmp/config.yaml

# Run unit tests
dotnet test --no-build

# dotnet add package JUnitTestLogger --version 1.1.0
# dotnet test --no-build --logger junit;LogFilePath=test_results.xml

# echo "log file here: /tmp/callgraph/dotnet/logs/log.txt"
# cat  /tmp/callgraph/dotnet/logs/log.txt

# echo "----------- JSON callgraph ---------------"
# cat /tmp/callgraph/dotnet/json/*

# echo "----------- CSV relations ---------------"
# cat /tmp/callgraph/dotnet/csv/*
