CmdHidden
=========

Start batch-files in a hidden console window.

Description
-----------
You can use this tiny utility for start batch-script in **Task Scheduler** or others programs if you don't like to observe blinking black console window while the script is executing.

Requirements
------------
<code>.NET Framework 4.0 Client Profile</code>

Usage
-----

    CmdHidden <cmd-file> [<params>]
    
Sample
------
> CmdHidden.exe "C:\My Scripts\HiddenScript.cmd" -test -file "C:\My Documents\File.txt" /p
