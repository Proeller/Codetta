# Coda 
A monospaced coding font with special ligatures for C#

A coding font has to meet a number of requirements:
+ It has to be monospaced, that means, all characters have the same width.
+ The width of the characters shouldn't be to wide, because long code lines should fit on the screen.
+ The same is true for the character height. Productivity grows with the numbers of lines you can see at a glance. 
+ All charactes must be easily distinguisable. This is especially important for characters like uppercase and lowercase letter L, uppercase letter I, number one, uppercase letter O and number zero as well as for punctuation signs like semicolon, colon, comma and period.
+ Even at small font sizes like 9 point on a normal 96 dpi monitor, the font has to be sharp and crisp. 
+ And finally the overall impression should be fresh and comfortable.

C# programmers usually work with Microsoft Visual Studio which comes with the Consolas font designed by [Luc(as) de Groot] (https://en.wikipedia.org/wiki/Luc(as)_de_Groot). 

Hasklig solves the problem the way typographers have always solved ill-fitting characters which co-occur often: [ligatures](https://en.wikipedia.org/wiki/Typographic_ligature). The underlying code stays the same — only the representation changes.

[**Download Coda Font Family v1.4**](https://github.com/i-tu/Hasklig/releases/download/1.1/Hasklig-1.1.zip)

#### Coda
![Hasklig Sample](hasklig_example.png?raw=true)

#### Consolas
![Source Code Pro Sample](SourceCodeProSample.png?raw=true)

### Release notes
+ [v1.0](https://github.com/i-tu/Hasklig/releases/tag/1.0)
    + Updates to the latest version of SCP
    + Hasklig moves to a ligature substitution mechanism borrowed from the excellent [Fira Code by Nikita Prokopov](https://github.com/tonsky/FiraCode)
#### Currently implemented symbols
`<*` `<*>` `<+>` `<$>` `***` `<|` `|>`  `<|>` `!!` `||` `===` `==>` `<<<` `>>>` `<>` `+++` `<-` `->` `=>` `>>` `<<` `>>=` `=<<` `..` `...` `::` `-<` `>-` `-<<` `>>-` `++` `/=` `==`

### Credits
Original idea, design and implementation of code ligatures by Ian Tuomi 2014-2015.
This typeface extends [Source Code Pro](https://github.com/adobe-fonts/source-code-pro) with ligatures.
