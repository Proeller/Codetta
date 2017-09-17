# Codetta 
## A monospaced coding font with special ligatures for C#.

The C# programming language uses a lot of character pairs to form special operators like two plus glyphs '++' to increment a value, two equal glyphs '==' to check for equality or the equal and greater glyph '=>' for the lambda operator.
**Codetta** combines these and a 21 further combinations to [ligatures](https://en.wikipedia.org/wiki/Typographic_ligature) in oder to improve code readability and productivity.

But first and foremost, **Codetta** has to meet a number of requirements to be a great coding font:
+ It has to be monospaced, that means, all characters have the same width.
+ The width of the characters shouldn't be to wide, because even long code lines should fit on the screen.
+ The same is true for the character height. Productivity grows with the numbers of lines you can see at a glance. 
+ All charactes must be easily distinguisable. This is especially important for characters like uppercase and lowercase letter L, uppercase letter I, number one, uppercase letter O and number zero as well as for punctuation signs like semicolon, colon, comma and period.
+ Even at small font sizes like 9 point on a normal 96 dpi monitor, the font has to be sharp and crisp. 
+ And finally the overall impression should be fresh and comfortable.

C# programmers usually work with Microsoft Visual Studio which comes with the Consolas font designed by [Luc(as) de Groot](https://en.wikipedia.org/wiki/Luc(as)_de_Groot). Consolas is a very sophisticated and exceptionally well designed font that neary meets all of the requirements. Only the distinctiveness of the numer one (1), the lowercase letter L and  the uppercase letter I is difficult at small font sizes like 9 or 10 pt.

Starting point in the development of **Codetta** was Abobe's open source font [Source Sans Pro](https://fonts.google.com/specimen/Source+Sans+Pro). The font metrics and most of the glyphs were strongly revised to meet the compactness and space efficiency of Consolas. Care was taken, that the font looks good at typicaly used font sizes (9 pt, 10 pt.) in Visual Studio and that the font works well with ClearType.

[**Download Codetta Font Family v1.0**](https://github.com/proeller/Coda/blob/master/release/Codetta_1.0.zip?raw=true)


### Samples

##### Consolas
![Consolas Sample](https://github.com/Proeller/Coda/blob/master/doc/Consolas.png?raw=true)

 

##### Codetta
![Coda Sample](https://github.com/Proeller/Coda/blob/master/doc/Coda.png?raw=true)

### Known Issues
Ligatures, which are starting with a hypen ('--' or '-=') are not shown in Microsoft Visual Studio due to a known bug in the WPF font renderer. I hope this will be fixed soon by Microsoft.

### Credits
This typeface is based on [Source Code Pro](https://github.com/adobe-fonts/source-code-pro).

