# Create a GUI+DLL application from the command line

vbapp:	app.vb utility.dll
	vbc app.vb  /r:Microsoft.VisualBasic.dll /target:exe /r:System.dll /r:utility.dll

csapp:	app.cs utility.dll
	csc /t:exe /out:app.exe  app.cs /r:System.dll /r:utility.dll


csdll:	utility.cs
	csc /t:library utility.cs

vbdll:	utility.vb
	vbc utility.vb /reference:Microsoft.VisualBasic.dll /target:library /r:System.dll

clean:
	erase *.exe
	erase *.dll