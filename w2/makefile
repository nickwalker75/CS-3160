app.exe:  main.cs basketballplayer.dll
    csc /t:exe /out:app.exe main.cs /r:basketballplayer.dll

basketball.dll:  basketballplayer.cs
    csc /t:library /out:basketballplayer.dll basketballplayer.cs

clean:
    del *.dll
    del *.exe

