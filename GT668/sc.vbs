Dim fso,wsh,sFolderPath,sFullPath
Dim Params,ArgList,cmd,loc,curdir,ShortcutName,FileName,GroupName,allUsers,Args

Params = Session.Property("CustomActionData")
ArgList = Split(params,",")
if UBound(ArgList) <> 7 then
    WScript.Quit
end if

cmd = ArgList(0)
loc = ArgList(1)
curdir = ArgList(2)
ShortcutName = ArgList(3)
FileName = ArgList(4)
Args = ArgList(5)
GroupName = ArgList(6)
allUsers = ArgList(7)

set wsh = CreateObject("WScript.Shell")

if loc="Desktop" then
    if allUsers = "" then
        sFolderPath=wsh.SpecialFolders("Desktop")
    else
        sFolderPath=wsh.SpecialFolders("AllUsersDesktop")
    end if
    GroupName = ""
elseif loc="Menu" then
    if allUsers = "" then
        sFolderPath=wsh.SpecialFolders("Programs")
    else
        sFolderPath=wsh.SpecialFolders("AllUsersPrograms")
    end if
    GroupName = GroupName & "\"
end if
sFullPath=sFolderPath & "\" & GroupName & ShortcutName & ".lnk"
if cmd="Del" then
    Set fso = CreateObject("Scripting.FilesystemObject")
    if fso.FileExists(sFullPath) Then
        fso.DeleteFile sFullPath
    end if
    set fso = Nothing
elseif cmd="Add" then
    set CreateShortcut=wsh.CreateShortcut(sFullPath)
    CreateShortcut.TargetPath=curdir & FileName
    CreateShortcut.Arguments=Args
    CreateShortcut.WorkingDirectory=curdir
    CreateShortcut.Save
    set CreateShortcut=Nothing
end if
set wsh=Nothing
