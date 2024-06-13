@echo off
echo Set objShell = CreateObject("Shell.Application") > runAsAdmin.vbs
echo objShell.ShellExecute "cmd.exe", "/k winfr C: D:\lpnu\TestRecovery /extensive /x /y:jpeg,mpeg", "", "runas", 1 >> runAsAdmin.vbs
cscript runAsAdmin.vbs
del runAsAdmin.vbs