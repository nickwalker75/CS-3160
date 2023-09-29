Lab1.exe : App.cs IntegerSet.dll
	csc /t:exe /out:app.exe App.cs /r:IntegerSet.dll

IntegerSet.dll : IntegerSet.cs
	csc /t:library /out:IntegerSet.dll IntegerSet.cs

clean:
	del *.dll
	del *.exe