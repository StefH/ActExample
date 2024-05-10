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

### Pass environment variables
``` cmd
gh act -W .github/workflows/main.yml --env CONFIGURATION=Debug --env RUN_TESTS=false
```

## :memo: Logging 
### Logging (1st time)
This needs to download the catthehacker/ubuntu:act-latest image and cache some JavaScript actions like `actions/setup-dotnet@v3`.

```
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

```
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

### Logging from real GitHub Actions
```
2024-05-10T09:17:18.8471440Z Current runner version: '2.316.1'
2024-05-10T09:17:18.8496689Z ##[group]Operating System
2024-05-10T09:17:18.8497372Z Ubuntu
2024-05-10T09:17:18.8497667Z 22.04.4
2024-05-10T09:17:18.8498074Z LTS
2024-05-10T09:17:18.8498367Z ##[endgroup]
2024-05-10T09:17:18.8498748Z ##[group]Runner Image
2024-05-10T09:17:18.8499255Z Image: ubuntu-22.04
2024-05-10T09:17:18.8499656Z Version: 20240422.1.0
2024-05-10T09:17:18.8500610Z Included Software: https://github.com/actions/runner-images/blob/ubuntu22/20240422.1/images/ubuntu/Ubuntu2204-Readme.md
2024-05-10T09:17:18.8502124Z Image Release: https://github.com/actions/runner-images/releases/tag/ubuntu22%2F20240422.1
2024-05-10T09:17:18.8503001Z ##[endgroup]
2024-05-10T09:17:18.8503356Z ##[group]Runner Image Provisioner
2024-05-10T09:17:18.8503895Z 2.0.369.1
2024-05-10T09:17:18.8504259Z ##[endgroup]
2024-05-10T09:17:18.8505275Z ##[group]GITHUB_TOKEN Permissions
2024-05-10T09:17:18.8506835Z Contents: read
2024-05-10T09:17:18.8507209Z Metadata: read
2024-05-10T09:17:18.8507896Z Packages: read
2024-05-10T09:17:18.8508335Z ##[endgroup]
2024-05-10T09:17:18.8511500Z Secret source: Actions
2024-05-10T09:17:18.8512050Z Prepare workflow directory
2024-05-10T09:17:18.9217586Z Prepare all required actions
2024-05-10T09:17:18.9384076Z Getting action download info
2024-05-10T09:17:19.0770601Z Download action repository 'actions/checkout@v2' (SHA:ee0669bd1cc54295c223e0bb666b733df41de1c5)
2024-05-10T09:17:19.1785534Z Download action repository 'actions/setup-dotnet@v3' (SHA:3447fd6a9f9e57506b15f895c5b76d3b197dc7c2)
2024-05-10T09:17:19.5845914Z Complete job name: build
2024-05-10T09:17:19.6761638Z ##[group]Run actions/checkout@v2
2024-05-10T09:17:19.6762209Z with:
2024-05-10T09:17:19.6762742Z   repository: StefH/ActExample
2024-05-10T09:17:19.6763487Z   token: ***
2024-05-10T09:17:19.6763872Z   ssh-strict: true
2024-05-10T09:17:19.6764423Z   persist-credentials: true
2024-05-10T09:17:19.6764886Z   clean: true
2024-05-10T09:17:19.6765239Z   fetch-depth: 1
2024-05-10T09:17:19.6765700Z   lfs: false
2024-05-10T09:17:19.6766099Z   submodules: false
2024-05-10T09:17:19.6766473Z   set-safe-directory: true
2024-05-10T09:17:19.6767286Z ##[endgroup]
2024-05-10T09:17:19.9638112Z Syncing repository: StefH/ActExample
2024-05-10T09:17:19.9641123Z ##[group]Getting Git version info
2024-05-10T09:17:19.9642581Z Working directory is '/home/runner/work/ActExample/ActExample'
2024-05-10T09:17:19.9643976Z [command]/usr/bin/git version
2024-05-10T09:17:19.9644847Z git version 2.43.2
2024-05-10T09:17:19.9646711Z ##[endgroup]
2024-05-10T09:17:19.9680958Z Temporarily overriding HOME='/home/runner/work/_temp/6928697f-4c15-450a-a0d7-69bd5658060e' before making global git config changes
2024-05-10T09:17:19.9683390Z Adding repository directory to the temporary git global config as a safe directory
2024-05-10T09:17:19.9685482Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/ActExample/ActExample
2024-05-10T09:17:19.9687623Z Deleting the contents of '/home/runner/work/ActExample/ActExample'
2024-05-10T09:17:19.9689609Z ##[group]Initializing the repository
2024-05-10T09:17:19.9690747Z [command]/usr/bin/git init /home/runner/work/ActExample/ActExample
2024-05-10T09:17:19.9692494Z hint: Using 'master' as the name for the initial branch. This default branch name
2024-05-10T09:17:19.9694103Z hint: is subject to change. To configure the initial branch name to use in all
2024-05-10T09:17:19.9695637Z hint: of your new repositories, which will suppress this warning, call:
2024-05-10T09:17:19.9696887Z hint: 
2024-05-10T09:17:19.9697698Z hint: 	git config --global init.defaultBranch <name>
2024-05-10T09:17:19.9698589Z hint: 
2024-05-10T09:17:19.9699723Z hint: Names commonly chosen instead of 'master' are 'main', 'trunk' and
2024-05-10T09:17:19.9701384Z hint: 'development'. The just-created branch can be renamed via this command:
2024-05-10T09:17:19.9702523Z hint: 
2024-05-10T09:17:19.9703350Z hint: 	git branch -m <name>
2024-05-10T09:17:19.9704600Z Initialized empty Git repository in /home/runner/work/ActExample/ActExample/.git/
2024-05-10T09:17:19.9706826Z [command]/usr/bin/git remote add origin https://github.com/StefH/ActExample
2024-05-10T09:17:19.9736897Z ##[endgroup]
2024-05-10T09:17:19.9738870Z ##[group]Disabling automatic garbage collection
2024-05-10T09:17:19.9825260Z [command]/usr/bin/git config --local gc.auto 0
2024-05-10T09:17:19.9826698Z ##[endgroup]
2024-05-10T09:17:19.9827983Z ##[group]Setting up auth
2024-05-10T09:17:19.9829260Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2024-05-10T09:17:19.9866414Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2024-05-10T09:17:20.0280739Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2024-05-10T09:17:20.0324438Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2024-05-10T09:17:20.0613857Z [command]/usr/bin/git config --local http.https://github.com/.extraheader AUTHORIZATION: basic ***
2024-05-10T09:17:20.0672404Z ##[endgroup]
2024-05-10T09:17:20.0674232Z ##[group]Fetching the repository
2024-05-10T09:17:20.0679789Z [command]/usr/bin/git -c protocol.version=2 fetch --no-tags --prune --progress --no-recurse-submodules --depth=1 origin +e624683a58c6f0db995c522300fb1d938af95e26:refs/remotes/origin/main
2024-05-10T09:17:20.3054330Z remote: Enumerating objects: 15, done.        
2024-05-10T09:17:20.3056502Z remote: Counting objects:   6% (1/15)        
2024-05-10T09:17:20.3058130Z remote: Counting objects:  13% (2/15)        
2024-05-10T09:17:20.3059584Z remote: Counting objects:  20% (3/15)        
2024-05-10T09:17:20.3060809Z remote: Counting objects:  26% (4/15)        
2024-05-10T09:17:20.3061791Z remote: Counting objects:  33% (5/15)        
2024-05-10T09:17:20.3062872Z remote: Counting objects:  40% (6/15)        
2024-05-10T09:17:20.3064093Z remote: Counting objects:  46% (7/15)        
2024-05-10T09:17:20.3065077Z remote: Counting objects:  53% (8/15)        
2024-05-10T09:17:20.3066097Z remote: Counting objects:  60% (9/15)        
2024-05-10T09:17:20.3067319Z remote: Counting objects:  66% (10/15)        
2024-05-10T09:17:20.3068312Z remote: Counting objects:  73% (11/15)        
2024-05-10T09:17:20.3069399Z remote: Counting objects:  80% (12/15)        
2024-05-10T09:17:20.3070718Z remote: Counting objects:  86% (13/15)        
2024-05-10T09:17:20.3071904Z remote: Counting objects:  93% (14/15)        
2024-05-10T09:17:20.3073454Z remote: Counting objects: 100% (15/15)        
2024-05-10T09:17:20.3075095Z remote: Counting objects: 100% (15/15), done.        
2024-05-10T09:17:20.3076494Z remote: Compressing objects:   8% (1/12)        
2024-05-10T09:17:20.3077831Z remote: Compressing objects:  16% (2/12)        
2024-05-10T09:17:20.3079437Z remote: Compressing objects:  25% (3/12)        
2024-05-10T09:17:20.3080900Z remote: Compressing objects:  33% (4/12)        
2024-05-10T09:17:20.3082412Z remote: Compressing objects:  41% (5/12)        
2024-05-10T09:17:20.3083748Z remote: Compressing objects:  50% (6/12)        
2024-05-10T09:17:20.3085294Z remote: Compressing objects:  58% (7/12)        
2024-05-10T09:17:20.3090251Z remote: Compressing objects:  66% (8/12)        
2024-05-10T09:17:20.3091665Z remote: Compressing objects:  75% (9/12)        
2024-05-10T09:17:20.3092968Z remote: Compressing objects:  83% (10/12)        
2024-05-10T09:17:20.3094725Z remote: Compressing objects:  91% (11/12)        
2024-05-10T09:17:20.3096144Z remote: Compressing objects: 100% (12/12)        
2024-05-10T09:17:20.3097793Z remote: Compressing objects: 100% (12/12), done.        
2024-05-10T09:17:20.3144236Z remote: Total 15 (delta 1), reused 11 (delta 1), pack-reused 0        
2024-05-10T09:17:20.3278630Z From https://github.com/StefH/ActExample
2024-05-10T09:17:20.3280595Z  * [new ref]         e624683a58c6f0db995c522300fb1d938af95e26 -> origin/main
2024-05-10T09:17:20.3310791Z ##[endgroup]
2024-05-10T09:17:20.3312677Z ##[group]Determining the checkout info
2024-05-10T09:17:20.3314916Z ##[endgroup]
2024-05-10T09:17:20.3316525Z ##[group]Checking out the ref
2024-05-10T09:17:20.3320346Z [command]/usr/bin/git checkout --progress --force -B main refs/remotes/origin/main
2024-05-10T09:17:20.3398073Z Switched to a new branch 'main'
2024-05-10T09:17:20.3399589Z branch 'main' set up to track 'origin/main'.
2024-05-10T09:17:20.3406689Z ##[endgroup]
2024-05-10T09:17:20.3459554Z [command]/usr/bin/git log -1 --format='%H'
2024-05-10T09:17:20.3497576Z 'e624683a58c6f0db995c522300fb1d938af95e26'
2024-05-10T09:17:20.3992687Z ##[group]Run actions/setup-dotnet@v3
2024-05-10T09:17:20.3993469Z with:
2024-05-10T09:17:20.3994028Z   dotnet-version: 8.0.x
     

2024-05-10T09:17:20.3994761Z   cache: false
2024-05-10T09:17:20.3995291Z ##[endgroup]
2024-05-10T09:17:20.5989269Z [command]/home/runner/work/_actions/actions/setup-dotnet/v3/externals/install-dotnet.sh --channel 8.0
2024-05-10T09:17:21.3249922Z dotnet-install: .NET Core SDK with version '8.0.204' is already installed.
2024-05-10T09:17:21.3573285Z ##[group]Run dotnet build ./ActExample/ActExample.csproj -c Release
2024-05-10T09:17:21.3574049Z [36;1mdotnet build ./ActExample/ActExample.csproj -c Release[0m
2024-05-10T09:17:21.3769946Z shell: /usr/bin/bash -e {0}
2024-05-10T09:17:21.3770386Z env:
2024-05-10T09:17:21.3770706Z   DOTNET_ROOT: /usr/share/dotnet
2024-05-10T09:17:21.3771203Z ##[endgroup]
2024-05-10T09:17:24.7134936Z MSBuild version 17.9.8+b34f75857 for .NET
2024-05-10T09:17:27.2821810Z   Determining projects to restore...
2024-05-10T09:17:28.9238414Z   Restored /home/runner/work/ActExample/ActExample/ActExample/ActExample.csproj (in 65 ms).
2024-05-10T09:17:34.8050591Z   ActExample -> /home/runner/work/ActExample/ActExample/ActExample/bin/Release/net8.0/ActExample.dll
2024-05-10T09:17:34.8153602Z 
2024-05-10T09:17:34.8174401Z Build succeeded.
2024-05-10T09:17:34.8175219Z     0 Warning(s)
2024-05-10T09:17:34.8175761Z     0 Error(s)
2024-05-10T09:17:34.8176114Z 
2024-05-10T09:17:34.8176747Z Time Elapsed 00:00:09.66
2024-05-10T09:17:34.8700016Z ##[group]Run dotnet build ./ActExampleTests/ActExampleTests.csproj -c Release
2024-05-10T09:17:34.8700866Z [36;1mdotnet build ./ActExampleTests/ActExampleTests.csproj -c Release[0m
2024-05-10T09:17:34.8701621Z [36;1mdotnet test ./ActExampleTests/ActExampleTests.csproj -c Release --no-build[0m
2024-05-10T09:17:34.8755834Z shell: /usr/bin/bash -e {0}
2024-05-10T09:17:34.8756184Z env:
2024-05-10T09:17:34.8756629Z   DOTNET_ROOT: /usr/share/dotnet
2024-05-10T09:17:34.8757046Z ##[endgroup]
2024-05-10T09:17:35.1215647Z MSBuild version 17.9.8+b34f75857 for .NET
2024-05-10T09:17:35.9020502Z   Determining projects to restore...
2024-05-10T09:17:40.6147794Z   Restored /home/runner/work/ActExample/ActExample/ActExampleTests/ActExampleTests.csproj (in 4.32 sec).
2024-05-10T09:17:40.6184180Z   1 of 2 projects are up-to-date for restore.
2024-05-10T09:17:41.0346050Z   ActExample -> /home/runner/work/ActExample/ActExample/ActExample/bin/Release/net8.0/ActExample.dll
2024-05-10T09:17:41.5975254Z   ActExampleTests -> /home/runner/work/ActExample/ActExample/ActExampleTests/bin/Release/net8.0/ActExampleTests.dll
2024-05-10T09:17:41.6167936Z 
2024-05-10T09:17:41.6189026Z Build succeeded.
2024-05-10T09:17:41.6190105Z     0 Warning(s)
2024-05-10T09:17:41.6197846Z     0 Error(s)
2024-05-10T09:17:41.6317594Z 
2024-05-10T09:17:41.6318041Z Time Elapsed 00:00:06.25
2024-05-10T09:17:42.7389036Z Test run for /home/runner/work/ActExample/ActExample/ActExampleTests/bin/Release/net8.0/ActExampleTests.dll (.NETCoreApp,Version=v8.0)
2024-05-10T09:17:43.0064883Z Microsoft (R) Test Execution Command Line Tool Version 17.9.0 (x64)
2024-05-10T09:17:43.0066336Z Copyright (c) Microsoft Corporation.  All rights reserved.
2024-05-10T09:17:43.0156978Z 
2024-05-10T09:17:43.5043073Z Starting test execution, please wait...
2024-05-10T09:17:43.5514906Z A total of 1 test files matched the specified pattern.
2024-05-10T09:17:44.1883190Z 
2024-05-10T09:17:44.1929371Z Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: < 1 ms - ActExampleTests.dll (net8.0)
2024-05-10T09:17:44.2478021Z Post job cleanup.
2024-05-10T09:17:44.3866726Z Post job cleanup.
2024-05-10T09:17:44.4981476Z [command]/usr/bin/git version
2024-05-10T09:17:44.5070031Z git version 2.43.2
2024-05-10T09:17:44.5129532Z Temporarily overriding HOME='/home/runner/work/_temp/79847cab-dc4c-47f9-8581-953c0a53cf72' before making global git config changes
2024-05-10T09:17:44.5131950Z Adding repository directory to the temporary git global config as a safe directory
2024-05-10T09:17:44.5134906Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/ActExample/ActExample
2024-05-10T09:17:44.5206590Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2024-05-10T09:17:44.5273719Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2024-05-10T09:17:44.5609491Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2024-05-10T09:17:44.5641579Z http.https://github.com/.extraheader
2024-05-10T09:17:44.5656283Z [command]/usr/bin/git config --local --unset-all http.https://github.com/.extraheader
2024-05-10T09:17:44.5699312Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2024-05-10T09:17:44.6254398Z Cleaning up orphan processes
2024-05-10T09:17:44.6596179Z Terminate orphan process: pid (1689) (dotnet)
```