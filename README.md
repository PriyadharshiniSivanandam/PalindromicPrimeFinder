Project: PalindromicPrimeFinder

Description: 
This project is to to find the Palindromic Prime number in the give range for the selected number system. 
Currently the functionality is implemented for decimal and Binary number system.

Features:
	Follows SOLID Principle
	Unit Tested
	
Approach:

UI : 
Simple UI created using WinForms which takes below inputs.
	Number System
	Range(From value and TO Value)
Added required Validations for controls.

BusinessLogic:
Considering the fact that number system are just representations but the characteristics of number remains same irrespective of number system
only did Palindrome check based on number system.

For each number in the given range perform below check
	IsPrime
	IsPalindorme in the selected number system

If both the condition matches the corresponding number will be added to output list which will then be displayed.

