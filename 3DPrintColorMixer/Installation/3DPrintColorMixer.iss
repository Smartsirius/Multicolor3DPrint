#define Version=GetFileVersion("..\3DPrintColorMixer\bin\Release\3DPrintColorMixer.exe")
#define Name="3DPrintColorMixer"
#define Firma="Smartsirius"
#define Jahr="2020"
#define Web="https://github.com/Smartsirius/3DPrintColorMixer"

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
OutputBaseFilename=3DPrintColorMixer_V{#Version}_Setup
UsePreviousAppDir=False                                                                                                     
DefaultGroupName={#Name}
AllowNoIcons=True
Compression=lzma
SolidCompression=True
;WizardImageFile="..\3DPrintColorMixer\Logos\logo_install.bmp"
;WizardSmallImageFile="..\ISG.App.Wpf.CncEditor\Logos\logo_install_small.bmp"

OutputDir=.
UsePreviousSetupType=False
UsePreviousTasks=False
UsePreviousLanguage=False
UsePreviousGroup=False
SetupLogging=True
MinVersion=0,6.1
ChangesAssociations=True
UserInfoPage=False
UninstallDisplayIcon={app}\3DPrintColorMixer.exe
PrivilegesRequired=none

[Dirs]
Name: "{app}\en"
Name: "{app}\de"

[Files]
Source: "..\bin\Release\3DPrintColorMixer.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Release\3DPrintColorMixer.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Release\de\3DPrintColorMixer.resources.dll"; DestDir: "{app}\de"; Flags: ignoreversion
Source: "..\bin\Release\en\3DPrintColorMixer.resources.dll"; DestDir: "{app}\en"; Flags: ignoreversion

[Icons]
Name: "{group}\3DPrintColorMixer"; Filename: "{app}\3DPrintColorMixer.exe"; WorkingDir: "{app}"; IconFilename: "{app}\3DPrintColorMixer.exe"

[Run]
Filename: "{app}\3DPrintColorMixer.exe"; WorkingDir: "{app}"; Flags: nowait postinstall skipifsilent; MinVersion: 0,6.1