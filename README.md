# Codetta 
## A monospaced coding font with special ligatures for C#.

The C# programming language uses a lot of character pairs to form special operators like two plus glyphs '++' to increment a value, two equal glyphs '==' to check for equality or the equal and greater glyph '=>' for the lambda operator.
**Codetta** combines these and 21 further combinations to [ligatures](https://en.wikipedia.org/wiki/Typographic_ligature) to improve code readability and productivity.

But first and foremost, **Codetta** must meet several requirements to be a great coding font:
+ It must be monospaced, that means, all characters have the same width.
+ The width of the characters shouldn't be too wide, because even long code lines should fit on the screen.
+ The same is true for the character height. Productivity grows with the numbers of lines you can see at a glance. 
+ All characters must be easily distinguishable. This is especially important for characters like uppercase and lowercase letter L, uppercase letter I, number one, uppercase letter O and number zero as well as for punctuation signs like semicolon, colon, comma and period.
+ Even at small font sizes like 9 points on a normal 96 dpi monitor, the font must be sharp and crisp. 
+ And finally the overall impression should be fresh and comfortable.

C# programmers usually work with Microsoft Visual Studio which comes with the Consolas font designed by [Luc(as) de Groot](https://en.wikipedia.org/wiki/Luc(as)_de_Groot). Consolas is a very sophisticated and exceptionally well-designed font that nearly meets all the requirements. Only the distinctiveness of the number one (1), the lowercase letter L and the uppercase letter I is difficult at small font sizes like 9 or 10 pt.

Starting point in the development of *Codetta* was Abobe's open source font [Source Sans Pro](https://fonts.google.com/specimen/Source+Sans+Pro). The font metrics and most of the glyphs were strongly revised to meet the compactness and space efficiency of Consolas. Care was taken, that the font looks good at typically used font sizes (9 pt., 10 pt.) in Visual Studio and that the font works well with ClearType.

The width of the ligatures is double the size of a regular character (triple in case of the Xml-Comment '///'). This guaranties that any code formatting is preserved when switching from a font without ligatures to *Codetta*. Nevertheless, *Codetta* can help saving space, because ligatures, which always start or terminate a clause are shifted left or right respectively, so that leading or trailing blanks can be omitted and the code is still easily readable.

Of course, *Codetta* doesn't change anything in your code. Switching from a normal font like Consolas to *Codetta* just changes the visual representation of the code. When someone else opens your code without having *Codetta* installed on his machine, he sees the regular code. 

[**Download Codetta Font Family v1.0**](https://github.com/proeller/Codetta/blob/master/release/Codetta_1.0.zip?raw=true)


### Samples

##### Consolas
![Consolas Sample](https://github.com/Proeller/Codetta/blob/master/doc/Consolas.png?raw=true)

 

##### Codetta
![Coda Sample](https://github.com/Proeller/Codetta/blob/master/doc/Codetta.png?raw=true)

### Known Issues
Ligatures, which are starting with a hyphen ('--' or '-=') are not shown in Microsoft Visual Studio due to a known bug in the WPF font renderer. I hope this will be fixed soon by Microsoft.

### Credits
This typeface is based on [Source Code Pro](https://github.com/adobe-fonts/source-code-pro).

