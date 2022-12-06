# visual

<h2>Visual Programming in C# .NET framework</h2>

<h3>Getting Started With .NET Framework</h3>

<h4>Installation</h4>

For Linux, Visual Studio is not available. So we will install Visual Studio Code either using the apt command from terminal or manually downloading the .deb file from the official website.






      sudo apt install code 





Use https://docs.microsoft.com/en-us/dotnet/core/install/ to install .NET SDK and core. 

Or for debian based devices like ubuntu run the following commands in the terminal

| <b>Note: You must install the dotnet core in the directory where you will be creating the projects</b>







      wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb 

      sudo dpkg -i packages-microsoft-prod.deb 

      sudo apt update 

      sudo apt install apt-transport-https 

      sudo apt install dotnet-sdk-7.0 
      
<h4>Project Creation</h4>

After the installation of .NET core, we simply create a project in the specific directory using the terminal integrated with VS Code.
      
      dotnet new console -n helloworld
      
This creates a separate directory for the project with the name HelloWorld.

      cd HelloWorld


This helps us to enter the project directory.

      dotnet run

This builds the projects and compiles the files creating a /bin directory which contains a HelloWorld.dll file.

Alternatively you can download this extension for building and running the projects without using the terminal from https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet
