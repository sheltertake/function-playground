# function-playground

npm install -g azure-functions-core-tools

http://localhost:7071/api/HttpTriggerCSharp?name=pippo

# mfun-js

[16/11/2019 15:43:40] For help, see: https://nodejs.org/en/docs/inspector
[16/11/2019 15:43:40] [error] Incompatible Node.js version. The version you are using is v13.0.1, but the runtime requires an LTS-covered major version (ex: 8.11.1 or 10.14.1). LTS-covered versions have an even major version number (8.x, 10.x, etc.) as per https://github.com/nodejs/Release#release-plan. For deployed code, change WEBSITE_NODE_DEFAULT_VERSION in App Settings. Locally, install or switch to a supported node version (make sure to quit and restart your code editor to pick up the changes).

# install nvm-windows
https://github.com/coreybutler/nvm-windows/releases/tag/1.1.7

nvm install 12.13

PS C:\Users\Max> nvm list

  * 13.0.1 (Currently using 64-bit executable)

PS C:\Users\Max> nvm

Running version 1.1.7.

PS C:\GIT\function-playground\mfun-js> nvm use 12.13
12.13.0
Now using node v12.13.0 (64-bit)
PS C:\GIT\function-playground\mfun-js> nvm list

    13.0.1
  * 12.13.0 (Currently using 64-bit executable)

  [16/11/2019 15:54:53] [error] Incompatible Node.js version. The version you are using is v12.13.0, but the runtime requires an LTS-covered major 
version (ex: 8.11.1 or 10.14.1). LTS-covered versions have an even major version number (8.x, 10.x, etc.) as per https://github.com/nodejs/Release#release-plan. For deployed code, change WEBSITE_NODE_DEFAULT_VERSION in App Settings. Locally, install or switch to a supported node version (make sure to quit and restart your code editor to pick up the changes).

PS C:\GIT\function-playground\mfun-js> nvm install 10.14.1
Downloading node.js version 10.14.1 (64-bit)...
Complete
Creating C:\Users\Max\AppData\Roaming\nvm\temp

Downloading npm version 6.4.1... Complete
Installing npm v6.4.1...

Installation complete. If you want to use this version, type

nvm use 10.14.1
PS C:\GIT\function-playground\mfun-js> nvm use 10.14.1    
Now using node v10.14.1 (64-bit)
PS C:\GIT\function-playground\mfun-js>