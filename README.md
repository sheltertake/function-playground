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

# Azure storage emulator

https://docs.microsoft.com/it-it/azure/storage/common/storage-use-emulator

download
https://go.microsoft.com/fwlink/?linkid=717179&clcid=0x409

search storage emulator and launch

C:\Program Files (x86)\Microsoft SDKs\Azure\Storage Emulator>AzureStorageEmulator.exe start
Windows Azure Storage Emulator 5.10.0.0 command line tool
Autodetect requested. Autodetecting SQL Instance to use.
Looking for a LocalDB Installation.
Probing SQL Instance: '(localdb)\MSSQLLocalDB'.
Found a LocalDB Installation.
Probing SQL Instance: '(localdb)\MSSQLLocalDB'.
Found SQL Instance (localdb)\MSSQLLocalDB.
Creating database AzureStorageEmulatorDb510 on SQL instance '(localdb)\MSSQLLocalDB'.

# Connect (localdb)\MSSQLLocalDb Sql Management Studio

# Storage Explorer

https://azure.microsoft.com/en-us/features/storage-explorer/

# upload file in azure storage (local don't trigger)

[16/11/2019 17:18:35] Executing 'BlobTriggerCSharp' (Reason='New blob detected: mfun-csharp-blob-path/Squadra1.jpg', Id=81854e7d-2088-4129-a3c3-b38228aa2e76)
[16/11/2019 17:18:36] C# Blob trigger function Processed blob
 Name:Squadra1.jpg
 Size: 1100 Bytes
[16/11/2019 17:18:36] Executed 'BlobTriggerCSharp' (Succeeded, Id=81854e7d-2088-4129-a3c3-b38228aa2e76)

# connection deve essere AzureWebJobsStorage 
Connection = "AzureWebJobsStorage"

local.settings.json 

    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "mfuncharspblobstorage_STORAGE": "DefaultEndpointsProtocol=https...."

publishing should be rewritten

il wizard ha creato un blobstorage diverso
DefaultEndpointsProtocol=https;AccountName=mfuncsharpblob

# blob trigger + js

nel wizard di vscode selezionare sempre l'opzione AzureWebJobsStorage
prima avevo fatto casino con quello step che ha creato un local.settings.json e una
risorsa su azure inutile e oltrettutto non funzionava l'emulatore perchè nel binding
del c# aveva hardcodato il nome della risorsa storage mentre deve essere sempre
AzureWebJobsStorage

In js i binding vanno nel function.json e non negli attributi dell'entrypoint (c#)

To resize the image, you need to add a few NuGet
packages. The packages that you need to install are
azure-storage, urijs, stream, jimp, and async. You
can install these packages using npm i <package
name>.

npm install azure-storage
npm install urijs
npm install stream
npm install jimp
npm install async

"dependencies": {
  "async": "^3.1.0",
  "azure-storage": "^2.10.3",
  "jimp": "^0.8.5",
  "stream": "0.0.2",
  "urijs": "^1.19.2"
}

# Func + Db

dotnet add package System.Data.SqlClient --version 4.5.1

# func js + odata

npm install azure-odata-sql async tedious tedious-connection-pool