# Building MSBuild Project Tools for VS Code

You'll need:

1. .NET Core 2.0.0 or newer
2. NodeJS
3. VSCE  
   `npm install -g vsce`

To build:

1. `npm install`
2. `dotnet restore`
3. `dotnet publish src/LanguageServer/LanguageServer.Host.csproj -o $PWD/out/language-server`

To debug:

1. Step 3 from "To build".
2. Open VS Code, and hit F5.

To create a VSIX package:

1. `vsce package`