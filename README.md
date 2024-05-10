# Example for "act" to run your GitHub Actions locally 🚀


## 📦 Install act
Installation as GitHub CLI extension:
``` cmd
gh extension install https://github.com/nektos/gh-act
```

## 💻 Usage
Go to the root folder and run the following command:

``` cmd
gh act
```

### Run act on the 'push' event
Run all workflows which have the
``` yaml
on: [push]
```
defined in the workflow file.

Command:
``` cmd
gh act push
```

### Run act on a specific workflow
``` cmd
gh act --workflows .github/workflows/main.yml
```

## :memo: Logging 
### Logging (1st time)
This needs to download the catthehacker/ubuntu:act-latest image and cache some JavaScript actions like `actions/setup-dotnet@v3`.


``` ps
time="2024-05-10T11:11:42+02:00" level=info msg="Using docker host 'npipe:////./pipe/docker_engine', and daemon socket 'npipe:////./pipe/docker_engine'"
[Build with Tests/build] 🚀  Start image=catthehacker/ubuntu:act-latest
[Build with Tests/build]   🐳  docker pull image=catthehacker/ubuntu:act-latest platform= username= forcePull=true
[Build with Tests/build] using DockerAuthConfig authentication for docker pull
[Build with Tests/build]   🐳  docker create image=catthehacker/ubuntu:act-latest platform= entrypoint=["tail" "-f" "/dev/null"] cmd=[] network="host"
[Build with Tests/build]   🐳  docker run image=catthehacker/ubuntu:act-latest platform= entrypoint=["tail" "-f" "/dev/null"] cmd=[] network="host"
[Build with Tests/build]   ☁  git clone 'https://github.com/actions/setup-dotnet' # ref=v3
[Build with Tests/build] ⭐ Run Main actions/checkout@v2
[Build with Tests/build]   🐳  docker cp src=C:\Dev\GitHub\ActExample\. dst=/mnt/c/Dev/GitHub/ActExample
[Build with Tests/build]   ✅  Success - Main actions/checkout@v2
[Build with Tests/build] ⭐ Run Main actions/setup-dotnet@v3
[Build with Tests/build]   🐳  docker cp src=C:\Users\StefHeyenrath\.cache\act/actions-setup-dotnet@v3/ dst=/var/run/act/actions/actions-setup-dotnet@v3/
[Build with Tests/build]   🐳  docker exec cmd=[node /var/run/act/actions/actions-setup-dotnet@v3/dist/setup/index.js] user= workdir=
| [command]/run/act/actions/actions-setup-dotnet@v3/externals/install-dotnet.sh --channel 8.0
| dotnet-install: Attempting to download using aka.ms link https://dotnetcli.azureedge.net/dotnet/Sdk/8.0.204/dotnet-sdk-8.0.204-linux-x64.tar.gz
| dotnet-install: Extracting zip from https://dotnetcli.azureedge.net/dotnet/Sdk/8.0.204/dotnet-sdk-8.0.204-linux-x64.tar.gz
| dotnet-install: Installed version is 8.0.204
| dotnet-install: Adding to current process PATH: `/usr/share/dotnet`. Note: This change will be visible only when sourcing script.
| dotnet-install: Note that the script does not resolve dependencies during installation.
| dotnet-install: To check the list of dependencies, go to https://learn.microsoft.com/dotnet/core/install, select your operating system and check the "Dependencies" section.
| dotnet-install: Installation finished successfully.
[Build with Tests/build]   ❓ add-matcher /run/act/actions/actions-setup-dotnet@v3/.github/csc.json
[Build with Tests/build]   ✅  Success - Main actions/setup-dotnet@v3
[Build with Tests/build]   ⚙  ::set-env:: DOTNET_ROOT=/usr/share/dotnet
[Build with Tests/build]   ⚙  ::set-output:: dotnet-version=8.0.204
[Build with Tests/build]   ⚙  ::add-path:: /usr/share/dotnet
[Build with Tests/build] ⭐ Run Main Build Project
[Build with Tests/build]   🐳  docker exec cmd=[bash --noprofile --norc -e -o pipefail /var/run/act/workflow/2] user= workdir=
|
| Welcome to .NET 8.0!
| ---------------------
| SDK Version: 8.0.204
|
| Telemetry
| ---------
| The .NET tools collect usage data in order to help us improve your experience. It is collected by Microsoft and shared with the community. You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.
|
| Read more about .NET CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry
|
| ----------------
| Installed an ASP.NET Core HTTPS development certificate.
| To trust the certificate, view the instructions: https://aka.ms/dotnet-https-linux
|
| ----------------
| Write your first app: https://aka.ms/dotnet-hello-world
| Find out what's new: https://aka.ms/dotnet-whats-new
| Explore documentation: https://aka.ms/dotnet-docs
| Report issues and find source on GitHub: https://github.com/dotnet/core
| Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli
| --------------------------------------------------------------------------------------
| MSBuild version 17.9.8+b34f75857 for .NET
|   Determining projects to restore...
|   Restored /mnt/c/Dev/GitHub/ActExample/ActExample/ActExample.csproj (in 83 ms).
|   ActExample -> /mnt/c/Dev/GitHub/ActExample/ActExample/bin/Release/net8.0/ActExample.dll
|
| Build succeeded.
|     0 Warning(s)
|     0 Error(s)
|
| Time Elapsed 00:00:03.51
[Build with Tests/build]   ✅  Success - Main Build Project
[Build with Tests/build] ⭐ Run Main Run Tests
[Build with Tests/build]   🐳  docker exec cmd=[bash --noprofile --norc -e -o pipefail /var/run/act/workflow/3] user= workdir=
| MSBuild version 17.9.8+b34f75857 for .NET
|   Determining projects to restore...
|   Restored /mnt/c/Dev/GitHub/ActExample/ActExampleTests/ActExampleTests.csproj (in 6.82 sec).
|   1 of 2 projects are up-to-date for restore.
|   ActExample -> /mnt/c/Dev/GitHub/ActExample/ActExample/bin/Release/net8.0/ActExample.dll
|   ActExampleTests -> /mnt/c/Dev/GitHub/ActExample/ActExampleTests/bin/Release/net8.0/ActExampleTests.dll
|
| Build succeeded.
|     0 Warning(s)
|     0 Error(s)
|
| Time Elapsed 00:00:10.89
| Test run for /mnt/c/Dev/GitHub/ActExample/ActExampleTests/bin/Release/net8.0/ActExampleTests.dll (.NETCoreApp,Version=v8.0)
| Microsoft (R) Test Execution Command Line Tool Version 17.9.0 (x64)
| Copyright (c) Microsoft Corporation.  All rights reserved.
|
| Starting test execution, please wait...
| A total of 1 test files matched the specified pattern.
|
| Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: < 1 ms - ActExampleTests.dll (net8.0)
[Build with Tests/build]   ✅  Success - Main Run Tests
[Build with Tests/build] ⭐ Run Post actions/setup-dotnet@v3
[Build with Tests/build]   🐳  docker exec cmd=[node /var/run/act/actions/actions-setup-dotnet@v3/dist/cache-save/index.js] user= workdir=
[Build with Tests/build]   ✅  Success - Post actions/setup-dotnet@v3
[Build with Tests/build] Cleaning up container for job build
[Build with Tests/build] 🏁  Job succeeded
```

### Logging (next time)
Note that .NET 8 is always downloaded from the internet.

``` ps
time="2024-05-10T11:14:31+02:00" level=info msg="Using docker host 'npipe:////./pipe/docker_engine', and daemon socket 'npipe:////./pipe/docker_engine'"
[Build with Tests/build] 🚀  Start image=catthehacker/ubuntu:act-latest
[Build with Tests/build]   🐳  docker pull image=catthehacker/ubuntu:act-latest platform= username= forcePull=true
[Build with Tests/build] using DockerAuthConfig authentication for docker pull
[Build with Tests/build]   🐳  docker create image=catthehacker/ubuntu:act-latest platform= entrypoint=["tail" "-f" "/dev/null"] cmd=[] network="host"
[Build with Tests/build]   🐳  docker run image=catthehacker/ubuntu:act-latest platform= entrypoint=["tail" "-f" "/dev/null"] cmd=[] network="host"
[Build with Tests/build]   ☁  git clone 'https://github.com/actions/setup-dotnet' # ref=v3
[Build with Tests/build] ⭐ Run Main actions/checkout@v2
[Build with Tests/build]   🐳  docker cp src=C:\Dev\GitHub\ActExample\. dst=/mnt/c/Dev/GitHub/ActExample
[Build with Tests/build]   ✅  Success - Main actions/checkout@v2
[Build with Tests/build] ⭐ Run Main actions/setup-dotnet@v3
[Build with Tests/build]   🐳  docker cp src=C:\Users\StefHeyenrath\.cache\act/actions-setup-dotnet@v3/ dst=/var/run/act/actions/actions-setup-dotnet@v3/
[Build with Tests/build]   🐳  docker exec cmd=[node /var/run/act/actions/actions-setup-dotnet@v3/dist/setup/index.js] user= workdir=
| [command]/run/act/actions/actions-setup-dotnet@v3/externals/install-dotnet.sh --channel 8.0
| dotnet-install: Attempting to download using aka.ms link https://dotnetcli.azureedge.net/dotnet/Sdk/8.0.204/dotnet-sdk-8.0.204-linux-x64.tar.gz
| dotnet-install: Extracting zip from https://dotnetcli.azureedge.net/dotnet/Sdk/8.0.204/dotnet-sdk-8.0.204-linux-x64.tar.gz
| dotnet-install: Installed version is 8.0.204
| dotnet-install: Adding to current process PATH: `/usr/share/dotnet`. Note: This change will be visible only when sourcing script.
| dotnet-install: Note that the script does not resolve dependencies during installation.
| dotnet-install: To check the list of dependencies, go to https://learn.microsoft.com/dotnet/core/install, select your operating system and check the "Dependencies" section.
| dotnet-install: Installation finished successfully.
[Build with Tests/build]   ❓ add-matcher /run/act/actions/actions-setup-dotnet@v3/.github/csc.json
[Build with Tests/build]   ✅  Success - Main actions/setup-dotnet@v3
[Build with Tests/build]   ⚙  ::set-env:: DOTNET_ROOT=/usr/share/dotnet
[Build with Tests/build]   ⚙  ::set-output:: dotnet-version=8.0.204
[Build with Tests/build]   ⚙  ::add-path:: /usr/share/dotnet
[Build with Tests/build] ⭐ Run Main Build Project
[Build with Tests/build]   🐳  docker exec cmd=[bash --noprofile --norc -e -o pipefail /var/run/act/workflow/2] user= workdir=
|
| Welcome to .NET 8.0!
| ---------------------
| SDK Version: 8.0.204
|
| Telemetry
| ---------
| The .NET tools collect usage data in order to help us improve your experience. It is collected by Microsoft and shared with the community. You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.
|
| Read more about .NET CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry
|
| ----------------
| Installed an ASP.NET Core HTTPS development certificate.
| To trust the certificate, view the instructions: https://aka.ms/dotnet-https-linux
|
| ----------------
| Write your first app: https://aka.ms/dotnet-hello-world
| Find out what's new: https://aka.ms/dotnet-whats-new
| Explore documentation: https://aka.ms/dotnet-docs
| Report issues and find source on GitHub: https://github.com/dotnet/core
| Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli
| --------------------------------------------------------------------------------------
| MSBuild version 17.9.8+b34f75857 for .NET
|   Determining projects to restore...
|   Restored /mnt/c/Dev/GitHub/ActExample/ActExample/ActExample.csproj (in 172 ms).
|   ActExample -> /mnt/c/Dev/GitHub/ActExample/ActExample/bin/Release/net8.0/ActExample.dll
|
| Build succeeded.
|     0 Warning(s)
|     0 Error(s)
|
| Time Elapsed 00:00:04.70
[Build with Tests/build]   ✅  Success - Main Build Project
[Build with Tests/build] ⭐ Run Main Run Tests
[Build with Tests/build]   🐳  docker exec cmd=[bash --noprofile --norc -e -o pipefail /var/run/act/workflow/3] user= workdir=
| MSBuild version 17.9.8+b34f75857 for .NET
|   Determining projects to restore...
|   Restored /mnt/c/Dev/GitHub/ActExample/ActExampleTests/ActExampleTests.csproj (in 12.03 sec).
|   1 of 2 projects are up-to-date for restore.
|   ActExample -> /mnt/c/Dev/GitHub/ActExample/ActExample/bin/Release/net8.0/ActExample.dll
|   ActExampleTests -> /mnt/c/Dev/GitHub/ActExample/ActExampleTests/bin/Release/net8.0/ActExampleTests.dll
|
| Build succeeded.
|     0 Warning(s)
|     0 Error(s)
|
| Time Elapsed 00:00:20.12
| Test run for /mnt/c/Dev/GitHub/ActExample/ActExampleTests/bin/Release/net8.0/ActExampleTests.dll (.NETCoreApp,Version=v8.0)
| Microsoft (R) Test Execution Command Line Tool Version 17.9.0 (x64)
| Copyright (c) Microsoft Corporation.  All rights reserved.
|
| Starting test execution, please wait...
| A total of 1 test files matched the specified pattern.
|
| Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: < 1 ms - ActExampleTests.dll (net8.0)
[Build with Tests/build]   ✅  Success - Main Run Tests
[Build with Tests/build] ⭐ Run Post actions/setup-dotnet@v3
[Build with Tests/build]   🐳  docker exec cmd=[node /var/run/act/actions/actions-setup-dotnet@v3/dist/cache-save/index.js] user= workdir=
[Build with Tests/build]   ✅  Success - Post actions/setup-dotnet@v3
[Build with Tests/build] Cleaning up container for job build
[Build with Tests/build] 🏁  Job succeeded
```