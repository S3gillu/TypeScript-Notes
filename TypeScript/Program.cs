using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScript
{ /*
   ***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 01

***********************************************************************************************************************************************************************

** TypeScript :

       |- It is a typed superset of JavaScript that compiles to plain JavaScript.

       |- It is pure object oriented with classes, interfaces and statically typed like C# or Java.

       |- JavaScript was introduced as a language for the client side.

       |- TypeScript is JavaScript for application-scale development.
 
       |- It is designed by " Andres Hejlsberg " at Microsoft.
 
       |- It is both langugae and a set of tools.

       |- It is an " Open Source " technology.


** Features :

       |- It is just JavaScript.

       |- It supports all other JS libraries.

       |- It is portable.

       |- It is aligned with ECMAScript6 specification.

       |- It adopts its basic language features from the ECMAScript5 specification, i.e, the official specification for JavaScript.

       |- The TypeScript transpiler provides the error-checking feature. TypeScript will compile the code and generate compilation errors,
          if it finds some sort of syntax errors.This helps to highlight errors before the script is run.

       |- Strong Static Typing:

               |- It comes with an optional " static typing " and " type inference system " through the TLS (TypeScript Language Service).

       |- It supports " type definitions " for existing JS libraries.TypeScript Definition file(with.d.ts extension) provides definition for 
          external JavaScript libraries.Hence, TypeScript code can contain these libraries.

       |- TypeScript supports Object Oriented Programming concepts like classes, interfaces, inheritance, etc.


** Components :
      
       |- TS has following three components :


        (1) Language :

              |- It comparises of the syntax , keywords, and type annotations.

         (2) The TS Compiler :
 
              |- The TS Compiler converts the instructions written in TS to JS equivalent.

         (3) The TS Language Service :

              |- The " Language Service " exposes an additional layer around the core compilerpipeline that are editor-like applications.

              |- It supports the common set of a typical editor operations like statement completions, signature help, code formatting and outlining, colorization, etc.

** DECLARATIONS :
 
       |- When a TS gets compiled, there is an option to generate a declaration file (with the extension .d.ts) that functions as an interface
          to the components in the compiled JavaScript.

       |- The declaration files(files with .d.ts extension) provide intellisense for types, function calls, and variable support for 
          JavaScript libraries like jQuery, MooTools, etc.


***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 02

***********************************************************************************************************************************************************************

** What is required for TS in your system :

    (1) A Code Editor(Mainly Visual Studio Code)

    (2) Install Node.js

    (3) Install TS in your OS by following code :

              --> npm install -g typescript

** The TypeScript Compiler :

        |- It itself a " .ts " file compiled down to JavaScript(" .js ") file.

        |- The TSC is a " source-to-source " compiler(transcompiler / transpiler).

        |- It generates a JavaScript version of " .ts " file passed to it.

        |- In other words , the TSC produces an equivalent JavaScript source code from the TypeScript file given as an input to it. This process is termed as " transpilation ".

        |- Ths TSC rejects any raw JS file passed to it. 

        |- The compiler deals only with " .ts " or " .d.ts " files.

     Note :- To compile a program use the following command in terminal of VS Code.

             --> tsc<file_name>.ts

             After compiling the file, use this command to run the program

             --> node<file_name>.js

      Note :- Multiple files can be compiled at once.

              --> tsc file1.ts, file2.ts, file3.ts


***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 03

***********************************************************************************************************************************************************************

** TS - Basic Syntax :

     |- Syntax defines a set of rules for writing programs.

     |- A TS Program is composed of :-


        (1) Modules

        (2) Functions

        (3) Variables

        (4) Statements and Expressions

        (5) Comments

** Compiler Flags :

      |- It enables us to change the behaviour of the compiler during the compilation.
 
      |- Each compiler flag exposes a setting that allows us to change how the compiler behaves.
    
      |- Following are the compiler flags with description :

         (1) --help :

              |- Displays the help manual

         (2) --module :

              |- Load external modules

         (3) --target :

               |- set the target ECMA Version

         (4) --declaration :

               |- Generates an additional.d.ts file

         (5) --removeComments :

               |- Removes all comments from the output file.

         (6) --out :

               |- Compile multiple files into a single output file.

         (7) --sourcemap :

               |- Generate a sourcemap(.map) files.

         (8) --module noImplicitAny :

               |- Disallows the compiler from inferring the any type.

         (9) --watch :

               |- Watch for file changes and recompile them on the fly.


***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 04

***********************************************************************************************************************************************************************

** Identifiers in TypeScript :

      |- Identifiers are names given to elements in a program like variables, functions etc. 
 
      |- The rules for identifiers are :

         (1) Identifiers can include both, characters and digits.However, the identifier cannot begin with a digit.

         (2) Identifiers cannot include special symbols except for underscore(_) or a dollar sign($).

         (3) Identifiers cannot be keywords.

         (4) They must be unique.

         (5) Identifiers are case-sensitive.

         (6) Identifiers cannot contain spaces.


** Keywords in TS :

       |-   break	as	any         switch
   	    case	if	throw	        else

        var number   string get
           module type    instanceof  typeof
           public private enum export
           finally	for	while	        void
           null	       super this            new
	  in	       return	true	        false
          any extends  static let
 package     implement interface function

     new	      try	yield const
         continue     do	catch

** Whitespace and Line Breaks :

     |- TypeScript ignores spaces, tabs, and newlines that appear in programs.

     |- we can use spaces, tabs, and newlines freely in our program and we are free to format and indent
        our programs in a neat and consistent way that makes the code easy to read and understand.

** TypeScript is Case-sensitive

    |-  This means that TypeScript differentiates between uppercase and lowercase characters.

** Semicolons are optional :

    |- Each line of instruction is called a " statement ".

    |- A single line can contain multiple statements.However, these statements must be separated by a semicolon.

** Comments in TS :

      |- Single-line comments ( // )

      |- Multi-line comments (/* */) 
      /*

** TypeScript and Object Orientation :

     |- TS is Object-Oriented JS.

     |- Object Orientation is a software development paradigm that follows real-world modelling.

     |- Object Orientation considers a " program as a collection of objects " that communicate with each other via mechanism called " methods ".

     |- TS supports following Object-Oriented components too :

             (1) Object :

                  |- An object is a real time representation of any entity.

                  |-  Every Object must have three features :
      
                        (a) State     :- Described by the attributes of an object

                        (b) Behaviour :- Describes how the object will act.

                        (c) Identity  :- A unique value that distinguishes an object from a set of similar such objects.


            (2) Class :

                 |-  A class in terms of OOP is a blueprint for creating objects.

                 |- A class encapsulates data for the object.

            (3) Method :

                 |- Methods facilitate communication between objects.


                            e.g,    class Greeting
    {

                        greet():void { 
   					   console.log("Hello World!!!") 
   						}
}
var obj = new Greeting();
obj.greet();
*/



            

























                                                            
    
     
     
     
     
     
}
