: tu ustawiamy sciezke do .net
PATH C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\
csc /checked /t:exe test.cs

: biblioteka
: csc /checked /t:library A.cs
: linkowanie
: csc /checked /t:exe B.cs /r:A.dll
PAUSE