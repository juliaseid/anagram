# _Anagram_

#### _Epicodus Project May 12, 2020_

#### By _**Jessica Hvozdovich, DJ Zevenbergen, and Julia Seidman**_

## Description

_A project to introduce the C# language and the .NET Core framework. The console application will take user input to display goals and descriptions. The lesson is meant to practice creating automated testing methods using MSTest and behavior driven development._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet build.

## Known Bugs

There are no known bugs at the time of this update.

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/djzevenbergen/anagram) here on GitHub._

## Technologies Used

* C#
* .NET Core
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User can enter a base word** | User Input:”bread” | Output: "bread" |
| **User can enter a word to compare** | User Input:”beard” | Output: "beard" |
| **User can enter multiple words to compare** | User Input:”beard, bard” | Output: "beard,bard" |
| **Program evaluates if the base word and comparison words are anagrams-true** | User Input:”bread beard” | Output: "Wow an anagram!" |
| **Program evaluates if the base word and comparison words are anagrams-false** | User Input:”bread bard” | Output: "This isn't an anagram!" |


### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jessica Hvozdovich, DJ Zevenbergen, and Julia Seidman_**