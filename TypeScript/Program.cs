using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScript
{ /*

    ***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 01 - Basics

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

                                                                  TYPESCRIPT : 02 - Environment Required

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

                                                                  TYPESCRIPT : 03 - Syntax

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

                                                                  TYPESCRIPT : 04 - Identifiers

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

      |- Multi-line comments (/* */) /*

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
obj.greet();                                  //OUTPUT : Hello World!!!

***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 05 - Data Type

***********************************************************************************************************************************************************************

** TypeScript - Types :

     |- The Type System represents the diffrent types of values supported by the language.

     |- The Type System checks the validity of supplied values, before they are stored or manipulated by program.This ensures that the code behaves as expected.

     |- The Type System further allows for richer code hinting and automated documentation too.

     |- Type Script provides data types as a part of its optional Type System.

** Classification of data type in TS :

      (1) Any : 

          |- It is the superset of all data types.
         
          |- It has two parts :


           (i) Built-in Types :

                  |- Includes number, string, boolean, void, null and undefined.

           (ii) User-defined Types :

                 |- Includes Arrays, Enums, Classes, Interfaces etc.


** The " Any " Type :

        |- It is the Super Type of all types in TS.

        |- It denotes a dynamic type.

        |- Using the " any " type is eqivalent to opting out of type checking for a variable.

** Built-in Types :

        (1) Number --> number 

                        |- Double precision 64-bit floating point values.

                        |- It can be used to represent both, integers and functions.

       (2) String --> string 

                        |- Represents a set of Unicode characters.

       (3) Boolean --> Boolean 

                        |- Represents logical values, true and false.

       (4) Void --> void  

                     |- Used on function return types to represent non-returning values.

       (5) Null --> null 

                     |- Returns an intentional absence of an object value.

       (6) Undefined --> undefined

                          |- Denotes value given to all uninitialized variables.

    ** Note : There is " no integer type in TS and JS ".

    ** Note : "Null" and "Undefined" are not same :

               |- They can not be used to reference data type of a variable.

               |- They can only be assigned as "values to a variable".

               |- A "variable" initialised with "undefined" means that tha variables has "no value" or "object" assigned to it.

               |- "null" means that the "variable" has not been set to an "object" whose value is "undefined".

 ***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 06 - Variables

***********************************************************************************************************************************************************************

** Variables :

    |- It is a "named space in a memory" that stores values.

    |- TS must follow JS naming rules :

         (i) variable names can contain alphabets and numeric digits.

         (ii) They can not contain spaces and special characters, except the underscore (_) and the dollar sign ($).

         (iii) variable names can not begin with a digit.
 
    |- A variable must be declared before it is used.

    |- "var" keyword is used to declare variables.


** Variable declaration in TS :

     |- The Type Syntax for declaring a variable in TS is to " include a colon (:) after a variable name " followed by its Type.

     |- When we declare a variable we have " four " options :

        (1) Declare it's type and value in one statement :

                      --> var[identifier] : [type-annotation] = value ;

                        e.g, 
                                var name : string = "shubham" ;

        (2) Declare it's type but no value :
      
                   |- In this case, the variable will be set to undefined.

                      --> var[identifier] : [type-annotation] ;

                       e.g,
                             var name : string ;

        (3) Declare it's value but no type :

                   |- In this case variable type will be set to "any".


                      -- > var[identifier] = value;

e.g, 
                                 var name = "saurabh";

(4) Declare neither value nor type:

                  | -In this case the data type of the variable will be "any" and will be initialized to "undefined".


                     -- > var[identifier];

e.g,
                                var name;




**Note : TS compiler will generate errors, if we attempt to assign a value to a variable that is not of the same type.Hence "TS" follows "Strong Typing".

               The Strong Typing syntax ensures that the types specified on either side of the assignment operator ( = ) are same.

               e.g, var name : string = 55; // It will lead to an error.


**Type Assertion in TS:

     | -TS allows changing a variable from  " one type to another ".This process in TS is known as Type Assertion.


    | -The Syntax is to put the " target type " between " < > " symbols and place it in front of the variable expression.

         e.g,

                          var str = '1';
var str2 : number = < number > < any > str;
console.log(str2);                                // OUTPUT : 1


     | -" Type Assertions" are purely a "compile time construct" and a way for us to provide hints to the compiler on how we want the code to be analyzed.

* *Inferred Typing in TS :

     | -TS also encourages dynamic typing of variables.This means that, TS encourages declaring a variable without a type.

     | -In such cases, the compiler will determine the type of the variable on the basis of the value assigned for it.

     | -TS will find the first usage of the variable within the code, determine the type to which it has been initially set and then assume the same type for this

        variable in the rest of your code block.

          e.g,

                      var num = 2;
                      console.log(num); // OUTPUT : 2

                      num = "shubham"   // At this line TSC will throw an error that cannot convert "string" to "number" because variables's type is already set to number.	   



* *Scope Of A Variable :

    | -The scope of a variable specifies where the variable is defined.

    | -The aviability of a variable within a program is determined by it's scope.

    | -TS variables can be of the following scopes :

        (1) Global Scope :


                | -Global variables are declared outside the programming constructs.

                | -These variables can be accessed from anywhere within the code.

        (2) Local Scope :

                | -It is declared within the constructs like methods, loops etc.

                | -It is accessible only within the constructs.

        (3) Class Scope :      

                | -These variable are also called " fields ".

                | -Fields or class variables are declared within the class but outside the methods.

                |- These variables can be accessed using the " object of the class ".

                |- Fields can also be " static ".

                |- static fields can be " accessed using the class name ".

                    
                      e.g,

                                 var global_num : number = 15 ; 

                                 class Numbers
{
    num_value = 17 ;

                                                 static sval = 19 ;

                                                 storeNum():void {
                                                                        var local_num = 20;

    console.log("local Scope Number :" + local_num);
                                                                  }
                                               }

                                console.log("Global Scope Number :" + global_num);

                                console.log("Static Field Number :" + Numbers.sval);

                                var obj = new Numbers();

console.log("Class Scope Number :" + obj.num_value);

                                obj.storeNum()

 ***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 07 - Operators

***********************************************************************************************************************************************************************

** For operators refer " https://www.tutorialspoint.com/typescript/typescript_operators.html "    


 ***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 08 - Decision Making

***********************************************************************************************************************************************************************

(1) if statement :

        |- An " if " statement consists of a Boolean expression followed by one or more statements.

        |- Syntax :

             if(boolean_expression)
                  {
    // statements will execute if the boolean exprtession is true.
}                                

       |- e.g,

                    var num : number = 20 ;

                    if(num >= 18) 

                        {
                              console.log("Eligible To Vote");
                        }                                                    // OUTPUT : Eligible To Vote



(2) if..else statement :

       |- An " if " statement can be followed by an optional " else " statement, which executes when the expression is false.

       |- Syntax :

            if(boolean_expression)
                      {
                        // statement(s) will execute if the boolean expression is true
                      }     
             else
                 {
                    // statement(s) will execute if the boolean expression is false
                 }

       |- e.g,

                    var num : number = 16 ;

                    if(num >= 18) 

                        {
                              console.log("Eligible To Vote");
                        }   

                      else
                        {
                              console.log("Not Eligible To Vote");
                        }                                              // OUTPUT : Not Eligible To Vote


(3) else..if statement(nested) :

         |- Used when we have to test multiple conditions.

         |- Syntax :

                     if(boolean_expression1)
                      {
    // statement(s) will execute if expression1 evaluates to true. 
} 
                       else if(boolean_expresion2)
                        {
                          // statement(s) will execute if expression2 evaluates to true.
                        }
                       else
                        {
                          // statement(s) will execute if both expression1 and expression2 is false
                        }

          ** Note : when using " if...else...if " and " else " statements, there are a few points to keep in  mind :
                   
                   (i) An " if " can have zero or one " else's " and it must come after any " else..if's ".

                  (ii) An " if " can have zero to many " else..if's " and they must come before the " else ".

                 (iii) Once an " else..if " succeeds, none of the remaining " else..if's " or " else's " will be tested.

        |- e.g,

                    var num:number = 2 

                   if(num > 0) 
                       { 
                                   console.log(num+" is positive") 
                      } 
                 else if(num< 0)
                     { 
                                  console.log(num+" is negative") 
                     } 
                  else { 
                                   console.log(num+" is neither positive nor negative")   // OUTPUT : 2 is positive
                       }

(4) Switch statement :

        |- It evaluates an expression, matches the expression's value to a case clause, and executes statements associated with the case.

        |- Syntax :

                     switch(variable_expression)

                               {
                                      case constant_expr1: 

                                           {
                                             //statements ;
                                                break;
                                           }

                                       case constant_expr2:

                                          {
                                            //statements; 
                                              break;
                                          }

                                       case constant_expr3:
 
                                          {
                                             //statements;
                                               break;
                                          }
                        
                                        default :
    
                                          {
                                                //statement(s)
                                                     break;
                                          }
                               }

           |- The value of the variable_expression is tested against all cases in the switch. 

           |- If the variable matches one of the cases, the corresponding code block is executed.

           |- If no case expression matches the matches the value of the variable_expression, the code within the default block is associated.

 ** Note :
 
     |- The following rules apply to a switch statement :

       (i) There can be any number of case statements within a switch.

      (ii) The case statements can include " only constants ". It cannot be a variable or an expression.

     (iii) The " data type " of the variable_expression and the constant expression must match.

      (iv) Unless you put a break after each block of code, execution flows into the next block.

      (v)  The case expression must be unique.

     (vi)  The default block is optional.


             e.g,

                               var grade : string = "A"

                            switch(grade)
                                  {
                                      case  "A" : {
                                          console.log("Excellent")
                                          break;
                                       }
                                     case "B" : {
                                         console.log("Very Good")
                                         break;
                                      }
                                     case "c" : {
                                        console.log("Good")
                                        break;
                                     }
                                    case "D":{ 
                                       console.log("Poor")
                                       break;
                                    }
                                  default : {
                                       console.log("Invalid Choice")
                                       break;
                                   }
                               }                                           // OUTPUT : Excellent


 ***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 09 - Loops

***********************************************************************************************************************************************************************

** Types of Loops :

       |- There are two types of loops :

           (1) Definite : A loop whose number of iterations are definite/fixed is termed as a definite loop.

                 | -It further have a part :

                        | -(i)For Loop : The for loop is an implementation of a definite loop.

                                 | -It executes the code block for a specified number of items.

                                 | -It can be used to iterate over a fixed set of values, such as an array.

                                 | -SYNTAX :

                                      | -                for(initial_count_value; termination_condition; step)
                                                            {
                                                              // statements
                                                            }

                                |- The loop uses a count variable to keep track of the iterations.
                               
                                |- The loop initializes the iteration by setting the value of " count " to its " initial value ".

                                |- It executes the code block, each time the value of count satisfies the  " termination_condtion ".

                                |- The step changes the value of count after every iteration.

                                |- e.g,
                                          var num : number = 5
                                          var i : number
                                          var factorial : number = 1

                                            for(i = num ; i >= 1 ; i--)
                                                 {
                                                     factorial *= i 
                                                 }
                                         console.log(factorial)                  //OUTPUT 120

                         |- (ii) The for...in loop :

                                  |- Another variation of the for loop is the for... in loop.

                                  |- The for...in loop can be used to iterate over a set of values as in the case of an " array " or a " tuple ".

                                  |- The for...in loop is used to iterate through a " list " or " collection " of values.

                                  |- SYNTAX :

                                       |-  for(var val in list)
{
    //statements
}

                                       |- e.g, 
                                                       var i : any
                                                       var j : any = "a b c"
                                                       for (i in j)
                                                           {
                                                              console.log(j[i])
                                                            }
 
           (2) Indefinite : An indefinite loop is used when the number of iterations in a loop is indeterminate or unknown.

                 |- It furter have two parts :

                     |- (i) While Loop :
                  
                              |- The while loop executes the instructions each time the condition specified evaluates to true.

                              |- Syntax :

                                   |- while(condition)
                                          {
                                            // Statements if the condition id true.
                                          }

                                   |- e.g,
                                                var num : number = 5 ;
                                                var factorial : number = 1;
                                                while(num >= 1)
                                                 {
                                                       factorial = factorial* sum;
num-- ;
                                                       console.log("The factorial is :" : + factorial);
                                                 }

                     |-(ii) do...while Loop :
 
                             |- It is similar to the while loop except that the " do...while " loop doesn't evaluate the condition for thr first time the loop executes.

                             |- " do…while loop " executes statement once.This is because the initial iteration does not consider the Boolean expression.

                             |- However, for the subsequent iteration, the while checks the condition and takes the control out of the loop.

                             |- e.g,

                                            var num : number = 5 ;
                                             while(num > 5)
                                               {
                                                    console.log("Entered While")
                                               }
                                             do
                                                {
                                                    console.log("Entered do...while")
                                                }
                                             while(num > 5)                              // OUTPUT : Entered do...while 




** The Break Statement :

      |- It is used to take the control out of a construct.

      |- using " break " in a loop causes the program to exist the loop.

      |- SYNTAX :

           |- break
      
                |- e.g, 
                             var i : number = 1 
                             while(i <= 10)
                                 {
                                    if(i % 5 == 0)
                                      {
                                          console.log("The first multiple of 5 between 5 and 10 is : " + i)
                                          break
                                       }
                                         i++
                                 }   
                                       // OUTPUT : The first multiple of 5 between 5 and 10 is : 5

** The Continue Statement :

      |- The continue statement skips the subsequent statements in the current iteration and takes the control back to the beginning of the loop.

      |-  Unlike the break statement, the continue doesn’t exit the loop.

      |-  It terminates the current iteration and starts the subsequent iteration.

      |- e.g,
               var num : number = 0
               var count : number = 0
               for(num = 0 ; num <= 20 ; num++)                                                                            
               {
                   for (num % 2 == 0)
                   {
                      continue
                   }
                  count ++
               }
               console.log("Count of all odd numbers upto 20 is :"+ count) // OUTPUT : 10

** Infinite Loop :

       |- Using for Loop :

            |- for(;;)
                {
                    console.log("This is an endless loop")
                }
  
       |- Using while loop :

               |- while(true)
                    {
                           console.log("This is an endless loop")
                    } 



***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 10 - Functions

***********************************************************************************************************************************************************************











                                                            

}


            

























                                                            
    
     
     
     
     
     
}
