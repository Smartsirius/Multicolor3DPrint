#define Version=GetFileVersion("..\bin\Release\Multicolor3DPrint.exe")
#define Name="Multicolor3DPrint"
#define Firma="Smartsirius"
#define Jahr="2020"
#define Web="https://github.com/Smartsirius/Multicolor3DPrint"

[Setup]
AppName={#Name}
UninstallDisplayName={#Name}
VersionInfoProductName={#Name}
VersionInfoDescription={#Name}

AppPublisher={#Firma}
VersionInfoCompany={#Firma}

AppPublisherURL={#Web}
AppSupportURL={#Web}
AppUpdatesURL={#Web}

AppVersion={#Version}
VersionInfoVersion={#Version}
VersionInfoProductVersion={#Version}

AppCopyright={#Jahr} by {#Firma}
VersionInfoCopyright={#Jahr} by {#Firma}

DefaultDirName={commonpf}\{#Name}
OutputBaseFilename={#Name}_V{#Version}_Setup
UsePreviousAppDir=False                                                                                                     
DefaultGroupName={#Name}
AllowNoIcons=True
Compression=lzma
SolidCompression=True

OutputDir=Output
UsePreviousSetupType=False
UsePreviousTasks=False
UsePreviousLanguage=False
UsePreviousGroup=False
SetupLogging=True
MinVersion=0,6.1
ChangesAssociations=True
UserInfoPage=False
UninstallDisplayIcon={app}\{#Name}.exe
PrivilegesRequired=none

[Dirs]
Name: "{app}\Licences"

[Files]
Source: "..\bin\Release\Multicolor3DPrint.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Release\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Release\settings.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Release\Licences\newtonsoft.json_licence.txt"; DestDir: "{app}\Licences"; Flags: ignoreversion
Source: "..\bin\Release\Multicolor3DPrint.exe.config"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\Multicolor3DPrint"; Filename: "{app}\Multicolor3DPrint.exe"; WorkingDir: "{app}"; IconFilename: "{app}\Multicolor3DPrint.exe"

[Run]
Filename: "{app}\Multicolor3DPrint.exe"; WorkingDir: "{app}"; Flags: nowait postinstall skipifsilent; MinVersion: 0,6.1