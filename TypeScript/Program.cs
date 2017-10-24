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

**  TypeScript and Object Orientation :

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

** Functions :

        |- These are the building blocks of readable, maintainable, and reusable code.

        |- It is a set of statements to perform a specific task.

        |- It organise the program into a logical blocks of code.This makes the code reusable.

        |- A function declarations tells the compiler about a function's name, return type, and parameters.

  (1) Defining a function :

        |- A function definition specifies what and how a specific task would be done.

        |- Before using a function it must be defined.

         |- functions are defined using " function " keyword.

         |- SYNTAX :

             |-     function function_name()

{
    //function body
}

(2) Calling a function :
        
        |- A functoin must be called so as to execute it.

        |- This term is called as "function invocation".

        |- SYNTAX :

             |- function_name()

        |-  e.g,
                     function xyz()                        // Function definition
{
    console.log("Function called")
                      }

                    xyz()                                  // Function invocation                     // OUTPUT : Function Called


    (3) Returning Functions :

         |- Functions may also return value along with control, back to the caller.

         |- SYNTAX :

              |-    function function_name() : return_type 
                      {
                         // statements 
                            
                          return value;
                      }
        ** Note:

         |- The " return_type " can be any valid data type.
 
         |- A returning function must end with a " return statement ".

         |- There can be only " one return statement per function ".

         |- The " data type " of the value returned must match the " return type " of the function.

         |- e.g,
                   function xyz() : string
                     {
    return "Hello Shubham Saurabh"
                     }
function abc()
{
    var greet = xyz()
                        console.log(greet)
                     }

                  abc()                                                  // OUTPUT : Hello Shubham Saurabh


     (4) Parameterized Function :

              |- Parameters are mechanism to pass values to functions.

              |- The parameter values are passed to the function during it's " invocation ".

              |- Unless explicitly specified, the " number of values passed to a function must match the number of parameters defined ".

              |- While calling a function, there are " two ways " that " arguments can be passed to a function " :-

                (i) Call By Value :

                     |- This method copies the  " actual value of an argument " into the formal parameter of the function.

                     |- In this case, changes made to the parameter inside the function have no effect on the argument.

                (ii) Call By Parameter :

                     |- This method copies the " address of an argument " into the formal parameter.

                     |- Inside the function, the address is used to access the actual argument used in the call. This means that changes made to the parameter.


              |- SYNTAX :

                    |- function func_name(param1:[datatype], param2:[datatype])
{
    // statements
}
                    |- e.g, 
                              function xyz(n1 : number , s1: string)
{
    console.log(n1)
                                     console.log(s1)
                                 }
                              xyz(123 , "Hello World")                                // OUTPUT : 123
                                                                                                  Hello World


      (5) Optional Parameter :

            |- These are used when argument need not be compulsorily passed for a function's execution.

            |- A Parameter can be marked " optional " by appending  a " question mark to its name " .

            |- It should be set as the " last argument " in a function.

            |- SYNTAX :

                  |- function func_name(param1 : [datatype], param2 : [datatype], param3?: [datatype])

                  |- e.g, 
                            function student_details(name : string , id : number , email?: string)
{
    console.log("Name:", name)
                                     console.log("Id:", id)

                                       if (email != undefined)
    {
        console.log("Email", email)
                                          }
}


                            student_details("shubham saurabh" , 1 )
                            student_details("mayank joshi", 2 , "mayank@email.com")


       (6) Rest parameters :

             |- It don't restrict the number of values that we can pass to a function.	

             |- However the values passed must be of the same type.

             |- It act as a placeholders for multiple arguments of the same type.

             |- SYNTAX :

                 |- To declare a rest parameter, the " parameter name is prefixed with the three periods ".

                 |- Any " nonrest parameter "  should come before the rest parameter.   
    
                 |- Rest Parameters are treated as a boundless number of optional parameters.

                 |- The compiler will build an " array of the arguments " passed in with the name given after the " ellipsis (...) ", allowing you to use it in your function.

                 |- e.g,
                              function buildName(firstName: string, ...restOfName: string[])
{
    return firstName + " " + restOfName.join(" ");
}

let employeeName = buildName("Joseph", "Samuel", "Lucas", "MacKinzie");
console.log(employeeName)                                                   //OUTPUT : Joseph Samuel Lucas Mackinzie


   (7) Default Parameters :

           |- Functions can also be assigned values by default.

           |- SYNTAX :

                |-   function func_name(param1 : [datatype] , param2 : [datatype] = default_value)
{
    //statements
}

         ** Note :

            |- A function can not be declared optional and default at the same time.

              |- e.g,
                           var discount(price : number , rate : number = 0.50)
{
    var discount_amount = price * rate
                              console.log(discount_amount)
                            }


                              discount(3000)
                              discount(1000 , 0.30)                                            // OUTPUT : 1500
                                                 							   300

  (8) Anonymous Function :

       |- Functions that are not bound to an identifier(function name) are called as " anonymous functions ".

       |- These are dynamically " declared at run time ".

       |- They can accept inputs and return outputs, just as standard function.

       |- It is usually not accessible after its initial creation.

       |- Variables can assign anonymous function.Such an expression is called a function expression.

       |- SYNTAX :

           |- var res = function( [arguments])
{ }

           |- e.g, Simple anonymous function :

                      var msg = function()
                                         {
                                              return "Hello World"
                                        }
                       console.log(msg())                                  // OUTPUT : Hello World

           |- e.g, Anonymous functions with parameter :

                                 var num = function(a, b)
                                         {
                                               return a* b
                                         }
                                 console.log(num(2,3))                   //OUTPUT : 6


 (9) Facts about Functoin Expression and Function Declaration :

       |- They are not synonymous.

       |- Unlike a function expression, a function declaration is bound by the function name.

       |- Basic difference between these two is : Function declarations are parsed before their execution.On the other hand, function expressions are parsed only
                                                  when the script engine encounters it during execution.

       |- When a JS parser sees a " function in the main code flow ", it assumes " function declaration ".

       |- When a " function comes as a part of a statement ", it is a " Function Expression ".

(10) The Function Constructor :

       |- TS also supports defining a function with the " built-in JS constructor " called " Function() "

       |- SYNTAX :

           |- var res = new Function( [arguments] ) {...}

           |- e.g,
                       var myFunction = new Function("a", "b", "return a*b")
                       var x = myFunction(4, 3)
                       console.log(x)                                            // OUTPUT : 12

      


           |- The new Function() is a call to the constructor which in turns creates and returns a function reference.

(11) Recursion and TypeScript Functions :

      |- It is a technique for iterating over an operation by having a function call to itself repeatedly until it arrives as a result.

      |- It is best applied when we need to call the same function repeatedly with different parameters from within a loop.

      |- e.g,
                function factorial(number)
                {
    if (number <= 0)
    {
        return 1;
    }
    else
    {
        return (number * factorial(number - 1))
                    }
}
console.log(factorial(10))

(12) Anonymous Recursive Function :
  
       |- e.g,
                     (function()
                       {
                          var x = "Hello !"
                          console.log(x)
                       }) ()                  // Function invokes itself using a pair of parentheses ()



(13) Lambda Functions :

      |- Lambda refers to anonymous functions in programming.

      |- These are concise mechanism to represent anonymous functions.

      |- These functions are also called as " Arrow Functions "

      |- There are three parts to lambda function :


          (i) Parameters : 
          
                 |- A function may optionally have parameters.

         (ii) The Fat Arrow notation / Lambda Expression :

                 |- Also known as "goes to" operator.

        (iii) Statements :

                 |- reperesents the function's instruction set.

   ** Lambda Expression :

        |- It is an " anonymous " function expression thatb points to a single line of code.

        |- SYNTAX :

              |- ([param1, param2, ...param n]) => statement;

              |- e.g,
                        var result = (x: number) => 10 + x
                         console.log(result(100))               // OUTPUT : 110

  ** Lambda Statement :

         |- It is an anonymous function declaration that points to a block of code.

         |- This syntax is used when function body spans multiple lines.

         |- SYNTAX :

              |- ([param1, param2, ...param n]) => {

                                       //code block
                             } 
              |- e.g,
                      var result = (x: number) =>
                      {
                         x = 10 + x
                         console.log(x)
                      };
                     result(100)                         // OUTPUT : 110

(14) Syntatic Variations :

      (i) Parameter Type Inference :

           |- It is not mandatory to specify the data type of a parameter.

           |- In such a case the data type of the parameter is " any ".

           |- e.g,
                     var result = (x) =>
                     {
                         if (typeof x == "number")
                         {
                             console.log(x + "is numeric")
                               }
                         else if (typeof x == "string")
                         {
                             console.log(x + "is string")
                               }
                     }

                result(100)

                 result("Hello")                                     // OUTPUT : 100 is numeric

                                                           Hello is string

       (ii) Optional Parentheses for a single parameter :
    
              |- e.g,
                        var display = x => { console.log("The function got" + x)  }
                         display(12)                                                 //OUTPUT: The function got 12


      (iii) Optional braces for a single statement, Empty parentheses for no parameter :
 
              |- e.g,

                          var display = () => { console.log("Function Invoked")}
                          display()                                               //OUTPUT : Function Invoked


(15) Function Overloads :

        |- Functions have the capability to operate differently on the basis of the input provided to them.

        |- Or, A program can have multiple methods with the same name with different implementation.This mechanism is termed as " Function Overloading " .

        |- TS provides support for function overloading.

        |- Following are the steps to overload a function in TS :

            (i) Declare multiple functions with the same name but different function signature :

                    |- Function signature include following :

                       (a) The Data Type of the parameter : 
                  
                              |- function disp(string):void ;
function disp(number):void ;

                       (b) The number of parameters :

                             |- function disp(s1:string):void ;
                                function disp(x:number , y:number):void ;

                       (c) The sequence of parameters :

                             |- function disp(x:number , y:string) : void ;
                                function disp(a :string , b: number) : void ;

                   |- Function signature does not include the function's return type.

           (ii) The declaration must be followed by a function definition.

                  |- The parameter types should be set to " any " if the parameter types differ during overload.

          (iii) Finally, we must invoke the function to make it functional.

                   e.g,
                             function disp(s1:string):void;
			    function disp(n1:number, s1:string):void;

			    function disp(x:any , y?: any ) :void
		            {
   				 console.log(x)
                                  if(y)
                     console.log(y)
                            }

                disp("shubham")

                disp(1 , "saurabh")





***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 11 - Numbers

***********************************************************************************************************************************************************************

** Numbers :

     |- TS like JS support numeric values as number objects.

     |- A number object converts numeric literal to an instance of the number class.

     |- Numeric class act as a wrapper and enables manipulation of numeric literals as they were objects.

     |- SYNTAX :

           |- var var_name = new Number(value)

     | -In case if a non generic argument is passed as an argument to the Number's constructor, it returns " NaN " (Not-a-Number) .


** Following are a set of properties of the Number Object :

      (i) MAX_VALUE
 
            |- The largest possible valuea number in JS can have 1.7976931348623157E+308
  
     (ii) MIN_VALUE

            |- The smallest possible value a number in JS can have 5E-324

    (iii) NaN

           |- Equal to a value that is not a number.

     (iv) NEGATIVE_INFINITY

            |- A value that is less than MIN_VALUE

     (v) POSITIVE_INFINITY

            |- A value that is greater than MAX_VALUE

    (vi) Prototype :

            |- A "static" property of the Number object. 

            |- Use the prototype property to assign new properties and methods to the Number object in the current object.

   (vii) Constructor :

             |- Return the function that created this object's instance. By default this is the Number object.


** Example :

        |-      var month = 0 
                if(month <= 0 || month > 12)
                  {
    month = Number.NaN
                    console.log("Value is" + NaN)
                  } else {
    console.log("Value Accepted")
                    }

** Example Prototype :

        |-      function employee(id : number , name : string)
                    {
    this.id = id
                       this.name = name
                    }

var emp = new employee(123 , "shubham")
               employee.prototype.email = "shubham@email.com"

               console.log("Employee's id is" + emp.id)
               console.log("Employee's name is" + emp.name)
               console.log("Employee's email is" + emp.email)


** Number Methods :

      |- The Number Object contains only the default methods that are a part of every object's definition.

      |- Some of the commonly used methods are :

        (i) toExponential() :

              |- Forces a number to display in exponential notation, even if the number is in the range in which JS normally uses standard notation.

              |- This method " returns a string " representing the number object in exponential notation.

              |- SYNTAX :

                   |- number.toExponential( [fraction_Digits] )

                   |- fraction_Digits : An integer specifying the number of digits after the decimal point.

             |- Return Value :

                   |- A string representing a Number Object in exponential notation with one digit before the decimal point, rounded to fraction digits
                      after the decimal point.
    
                   |- If the fraction Digit argument is ommited, the number of digits after the decimal point defaults to the number of digits necessary to
                      represent the value uniquely.

                   |- E.g,

                            var num = 1.2235
                            var val = num.toExponential();
console.log(val)
          //OUTPUT : 1.2235e + 3

          (ii) toFixed():

                 |- Formats a number with a specific number of digits to the right of the decimal.
    
                 |-  A string representation of number that does not use exponential notation and has the exact number of digits after the decimal place.

                 |- e.g,
                            var num = 1.2235
                            var val = num.toFixed(2)             // OUTPUT : 1.22



        (iii) toLocaleString():

                |- This method converts a Number object into a " human readable string " representing the number using the locale of the environment.

                |- Returns a human readable string representing the number using the loale of the environment.

                |- SYNTAX :

                      |- number.toLocaleString()
                            
                |- e.g,
                              var num = new Number(177.3254)
                              console.log(num.toLocaleString())    // OUTPUT : 177.3254

        (iv) toPrecision :

                |- It defines how many total digits(including digits to the left and right of the decimal) to display a number.

                |- A Negative precision will throw an error.

                |- SYNTAX :
                        
                    |- number.toPrecision( [precision] )

                |- e.g,
                            var num = 1.25698

                            var val = num.toPrecision(2)

                            console.log(val)                         // OUTPUT : 1.2



       (v) toString() :

                |- This method returns a string representing the specified object.

                |- This method parses it's first argument, and attempts to return a string representation in the specified radix (base).

                |- SYNTAX :

                      |- number.toString( [radix] )

                |- e.g,
                           var num = new Number(10)

                           console.log(num.toString())
                            console.log(num.toString(2))
                            console.log(num.toString(8))                   // OUTPUT :  10
 											1010
											12 


        (vi) valueOf():
 
               |- It return's the number's primitive value.

               |- SYNTAX :

                    |- number.valueOf()

               |- e.g,
                                 var num = new Number(10)
                                 console.log(num.valueOf())                // OUTPUT : 10

***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 11 - Strings

***********************************************************************************************************************************************************************

** String :
 
    |- The String Object lets us work with a series of characters.

    |- It wraps the string primitive data type with a number of helper methods.

    |- SYNTAX :

         |- var var_name = new String(string);

** Methods available in String Object :

    (i) Constructor :

          |- Returns a reference to the String function that created the object.
 
          |- e.g, 
                  var str = new String("This is String")
                  console.log("String Constructor is" + str.constructor)  // OUTPUT : str.constructor is:function String() { [native code] } 

  ** (ii) String Length Property :

          |- Returns the length of the string.
        
          |- e.g, 
                   var name = new String("Shubham Saurabh")
                   console.log(name)
                   console.log(name.length)                    // OUTPUT : [String: 'Shubham Saurabh']
 									   15

  (iii) Prototype property :

          |- It allows us to add properties and methods to an object.

          |- Example :
                        function employee(id : number , name : string)
{
    this.id = id
                       this.name = name
                    }

var emp = new employee(123, "shubham")
               employee.prototype.email = "shubham@email.com"

               console.log("Employee's id is" + emp.id)
               console.log("Employee's name is" + emp.name)
               console.log("Employee's email is" + emp.email)


** String Methods :

         |- Following are the String Methods :

         (i) charAt() :

               |- Returns the character at the specified index.

               |- Characters in a string are indexed from " left to right ". 

               |- The index of the first character is 0, and the index of the last character in string, called the stringName, is stringName.length - 1

               |- SYNTAX :
       
                   |- string.charAt(index);

                   |- e.g, 
                                  var str = new String("This is string")

                                  console.log(str.charAt(2))                     // OUTPUT : i

        (ii) charCodeAt() :

               |- Returns a number indicating the unicode value of the character at the specified index.

               |- unicode range : 0 to 1,114,111

               |- The first 128 Unicode points are a direct match of the ASCII character coding.

               |- It always returns a value less than 65,536

               |- SYNTAX :
   
                   |- string.charCodeAt(index);

    ** (iii) concat :
    
               |- This method adds two or more strings and returns a new single String.
 
               |- SYNTAX :

                   |- string.concat(string2, string3,[... stringN])

                   |- e.g,
                            var str1:any = new String("This is String One")
                            var str2:any = new String("This is String Two")
                            var str3:any = str1.concat(str2)
                            console.log(" " + str3)                           // OUTPUT : This is String One This is String Two


        (iv) indexOf() :

               |- This method returns the index within the calling String object of the " first occurrence " of the specified value, starting the search at
                  " fromIndex or -1 " if the value is not found.

               |- SYNTAX :

                    |- string.indexOf(searchValue, [fromIndex])

                    |- e.g,
                              var str = new String("This is Shubham")
                              var result = str.indexOf("Shubham")
                              console.log(result)                             // OUTPUT : 8

        (v) lastIndexOf():

              |- This method returns the index within the calling String object of the " last occurrence " of the specified value, starting the search at
                  " fromIndex or -1 " if the value is not found.

              |- SYNTAX :
       
                    |- string.lastIndexOf(searchValue, [fromIndex])

                    |- e.g,
                              var str = new String("This is Shubham Shubham")
                              var result = str.indexOf("Shubham")
                              console.log(result)                             // OUTPUT : 16

        (vi) localeCompare() :

              |- It returns a number indicating whether a reference string comes before or after or is the same as the given string in sorted order.

              |- SYNTAX :
                     |-   string.localeCompare(param)

                     |- param :- A string to be compared with string object.

              |- RETURN VALUE :

                 (i) 0 :- If the string matches 100%

                (ii) 1 :- No match, and the parameter value comes before the string object's value in the locale sort order.

               (iii) Negative Value :- No match, and the parameter values comes after the string object's value in the local sort order.

              |-e.g,
                          var str1 = new String("This is Shubham")

               var str2 = str1.localeCompare("This is Shubham")

               console.log(str2)                                        //OUTPUT : 0


        (vii) match():
    
                |- Used to match a " regular expression " against a local string.

        (viii) replace():

                |- This method finds a " match between a regular expression and a string ", and replaces the matched substring with a new substring.

                |- Following are the replacement patterns :

                   (a) $$ --> Inserts a "$"

                   (b) $& --> Inserts the matched substring

                   (c) $` --> Inserts the portion of the string that " precedes " the matched string.

                   (d) $' --> Inserts the portion of the string that " follows " the matched string.

                   (e) $n or $nn --> where "n" and "nn" are decimal digits, inserts the "nth" parenthesized submatch string, provided the first argument was a RegExp object.
   
                |- SYNTAX :

                    |-  " string.replace(regexp/substr, newSubStr/function, [flags]) "

                    |- regexp :- A RegularExpression Object.The matched is replaced by the return value pf parameter #2.

                    |- substr :- A String that is to be replaced by newSubStr.
     
                    |- newSubStr :- The String that replaces the subString received from parameter #1.

                    |- function :- A function to invoked to create the new substring.

                    |- flags :- A String containing any combination of the RegExp flags: g

                    |- e.g,
                               var re = / apples / gi;
var str = "Apples are round, and apples are juicy.";
var newstr = str.replace(re, "oranges");
console.log(newstr)					// OUTPUT : oranges are round, and oranges are juicy.

                    |- e.g,
                               var re = / (\w+)\s(\w+)/; 
                               var str = "zara ali";
var newstr = str.replace(re, "$2, $1");
console.log(newstr);                                    // OUTPUT : ali, zara


        (ix) search() :

               |- This method executes the search for a "match" between a "regular expression" and the "string object".

               |- SYNTAX :
                             string.search(regexp)

                     |- e.g,
                                  var de = / apples / gi
                                  var str = "All Apples are nothing but apples"
                                  var result = str.search(de)
                                  console.log(result)


               |- regexp : A regular expression object. If a non-RegExp object is passed, it is implicitly converted to a RegExp by using new RegExp(obj).

               |- Return Value :

                    |- If successful, the search returns the "index" of the regular expression inside the string. Otherwise it returns "-1" .


        (x) slice() :

              |- This method extracts a section of a string and returns a new string.

              |- SYNTAX :

                           string.slice(beginslice , [endslice])

                   |- e.g,
                              var obj = "All apples are red and apples are juicy too"
                              var str = obj.slice(3, -2)
                              console.log(str)							// OUTPUT : apples are red and apples are juicy t

              |- Argument details :

                    |- beginslice :- The Zero-based index at which to begin extraction.

                    |- endslice :- The Zero-based index at which to end the execution.If omitted, slice extracts to the end of the string.

              |- Return Value :

                    |- If successful, slice returns the index of regular expression inside the string. Otherwise, it returns "-1" .



         (xi) split() :

               |- This method splits a "String Object" to an "array of strings" by separating the string into substrings.

               |- SYNTAX :


                                string.split([separator], limit)

               |- Argument Details :

                     (a) separator :- Specifies the character to use for separating the String.

                          Note : If separator is omitted, the array returned contains one element consisting of the entire String.

                     (b) limit :- Integer specifying a limit on the number of splits to be found.

               |- Return Value :

                      |- This methods returns a new array.
 
                      |- Also, when the string is empty, split returns an array consisting one empty string, rather than an empty array.

                      |- e.g,
                                 var str = "All apples are juicy and red too"

                     var splitted = str.split(" ", 3)

                      console.log(splitted)                               //OUTPUT : All apples are


         (xii) substr() :

                |- This method returns the characters in a string beginning at the specified location through the specified number of characters.

                |- SYNTAX :

                                    string.substr(start, length)

                |- Argument Details :

                      |- start :- Location at which to start extracting characters.

                      |- length :- The number of character to extract.

                       Note : If start is negative, substr uses it as a character index from the end of the string.

                |- Return Value :

                      |- It returns new sub-string based on given parameters.

                |- e.g,

                             var str = "Apples are red and juicy"
                             var result1 = str.substr(2, 2)
                             console.log(result1)                        // OUTPUT : pl

                             var result2 = str.substr(-2,2)
			     console.log(result2)                       // OUTPUT : cy

                             var result3 = str.substr(1)
			     console.log(result3)                       // OUTPUT : pples are red and juicy


          (xiii) substring() :

                     |- This method returns a "subset" of a String object.

                     |- SYNTAX :

                                  string.substring(indexA, [indexB])

                     |- Argument Details :

                         (a) indexA : An integer b/w "0" and one less than the length of the string.

                         (b) indexB : (optional) An integer between 0 and the length of the string.

                     |- Return Value :

                              |- It returns the new sub-string based on given parameters.

                     |- e.g,
                                  var str = "Apples are red and juicy"

                        var result = str.substring(1, 2)

                   console.log(result)                            // OUTPUT : P


         (xiv) toLocaleLowerCase():

                    |- It returns a string in lowercase with the current locale.
 
                    |- SYNTAX :

                                    string.toLocaleLowerCase()

                    |- e.g,
                               var str = "Apples are Red and Juicy"

                    var result = str.toLocaleLowerCase()

                 console.log(result)                               // OUTPUT : apples are red and juicy


         (xv) toLocaleUpperCase():

                   |- It returns a string in uppercase with the current locale.

                   |- SYNTAX :

 					string.toLocaleUpperCase()

                   |- e.g,
                                    var str = "apples are red and juicy"
                                    var result = str.toLocaleUpperCase()

                     console.log(result)                        // OUTPUT : APPLES ARE RED AND JUICY


         (xvi) toLowerCase():

                  |- It returns the calling string value converted to lowercase.

                  |- SYNTAX :
                                 string.toLowerCase()

                  |- e.g,
                               var str = "Apples are Red and Juicy"

                    var result = str.toLowerCase()

                 console.log(result)                               // OUTPUT : apples are red and juicy


         (xvii) toUpperCase():

                  |- It returns a string representing the specified object.

                  |- SYNTAX :

                                 string.toUpperCase()

                 |- e.g,
                                    var str = "apples are red and juicy"
                                    var result = str.toLocaleUpperCase()

                     console.log(result)                        // OUTPUT : APPLES ARE RED AND JUICY


         (xviii) toString() :

                   |- This method returns a string representing the specified object.

                   |- SYNTAX :

                                   string.toString()

                   |- e.g,
                                var str = "Apples are Red and juicy"

                cosole.log(srt.toString())                   // OUTPUT : Apples are Red and juicy 


          (xix) valueOf():

                  |- It returns the "primitive value" of a String Object.

                  |- SYNTAX :

                              string.valueOf()

                  |- e.g,
                               var str = new String("Hello Shubham")

                console.log(str.valueOf())                      //OUTPUT : Hello Shubham
***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 12 - Arrays

***********************************************************************************************************************************************************************

** Limitation of Variable :
                
            |- Variables are "scalar" in nature.

            |- variable declaration can only contain a single value at a time.This means that to store "n" values in a program "n" variable declration will be needed.

            |- Hence the use of variable is not feasible when one needs to store a larger collection of values.

            |- Memory allocation of variables in a program are random in nature, so it become tedious to retrieve/read the values in order of their declaration.

** Arrays :

      |- TS introduces the concept of arrays to tackle the same.

      |- An array is a homogenous collection of values.

      |- In other words, an array is a collection of the same data type.It is a user defined type.

** Features of an Array :

      |- An array declaration allocates sequential memory blocks

      |- Array are static. This means an array once initialized can't be resized.

      |- Each memory block represents an array element.

      |- Array elements are identified by a unique integer called as the subscript/index of the element.

      |- Like variables, array too, should be declared before they are used.

      |- "var" keyword is used to declare an array.

      |- Array initialization refers to populating the array elements.

      |- Array elements values can be updated or modified but can't be deleted.

** Declaring and Initializing Arrays :

       |-   var array_name : [datatype]   // declaration

       |-  array_name = [val1, val2, val3, ...val'n']   //Initialization

     Note : An array declaration without "data type" is deemed to be of type "any". 
            The type of such an array is inferred from the data type of the array's first element during initialization.

       |- Arrays may be declared and initialized in a single statement.
                       
                  |- SYNTAX :
                                    var array_name : [data type] = [val1, val2, ...val'n']

      Note : The pair of[] is called the "dimension" of the array.



** Accessing Array Elements :

       |- SYNTAX :

                    array_name[index] = value

       | -e.g,
                    var nums:numbers[] = [1, 2, 3, 4]

            console.log(nums[0])            // 1
            console.log(nums[1])                        // 2
                    console.log(nums[2])                        // 3
                    console.log(nums[3])                        // 4


** Array Object :

     |- An array can also be created using the array object.

     |- An array constructor can be passed

          (i) A numeric value that represents the size of an array or

         (ii) A list of comma separated values.

      e.g,
                var car : number[] = new Arrey(4)                  // OUTPUT : 0
              for(var i= 0; i<car.length, i++)                               2
                  {                                                            4
                      var result = car[i] = i * 2                              6
                      console.log(result)   
                  }

 
     e.g, 
                      var names:string[] = new Array["shubham", "saurabh", "singh"]    // OUTPUT : shubham
                       for(var i=0; i<name.length; i++ )                                         saurabh
                        {                                  					   singh
                              console.log(name[i])
                        }


** Array Methods :
  
  (i) concat() :

            |- This method returns a new array comprised of this array joined with two or more arrays.

            |- SYNTAX:
                        array.concat(value1, value2, ..., valueN)

            |- RETURN VALUE :  It returns a new array.

        Note : concat will work only on same type of array.Either set data type to any or set same data type.
           
            |- e.g,
                     var alpha : any = ["x", "y", "z"]               // OUTPUT : x,y,z,1,2,3
var beta : any = [1, 2, 3]
var result = alpha.concat(beta)
                     console.log(result)


  (ii) every() :

          |- This method tests whether all the elements in an array passes the test implemented by the provided function.

          |- SYNTAX :
                       array.every(callback, [thisObject])

          |- ARGUMENT DETAILS :

                |- callback :- Function to test for each element.

                |- thisObject :- Object to use as this when executing callback.

          |- RETURN VALUE :
  
                 |- Returns "true" if every element in this array satisfies the provided testing function.

          |- e.g,
                      function isBigEnough(element)
                       {
    return (elemnt >= 4)
                       }
var passed = [11, 21, 56, 89, 54].every(isBigEnough)
                       console.log("Test Value :" + passed)                              // OUTPUT : Test Value : true


 (iii) filter() :
 
           |- This method creates a new array with all elements that pass the test implemented by the provided function.

           |- SYNTAX :
                        array.filter(callback, [thisObject])

           |- e.g,
                        function isBigEnough(element)
{
    return (element >= 10)
                         }
var passed = [112, 15, 6, 5, 89].filter(isBigEnough)

            console.log(passed) 					// OUTPUT : 112, 15, 89

 (iv) forEach():

        |- similar to "for" loop.

 (v) indexOf() :

        |- This method "returns the first index" at which a given element can be found in the array, or returns "-1" if it is not present.

        |- SYNTAX :
                       array.indexOf(search Element, [fromIndex])

        |- PARAMETER DETAILS:
                
                  |- search Element :- Element to locate in the array.

                  |- fromindex : The index at which to begin the search. Defaults to "0", i.e, the whole array will be searched.
                                 If the index is greater than or equal to the length of the array, -1 is returned.

        |- e.g,
                       var index = [10, 20, 30, 40, 50].indexOf(40)
                       console.log("index is :" + index)	      // OUTPUT : 3


(vi) Join():

       |- Joins all the elements of an array into a string

       |- SYNTAX :
                        array.join(separator)

       |- PARAMETER DETAILS :
                          
             |- separator :- Specifies a string to separate each element of the array.If omitted, the array elements are separated with comma.

       |- e.g,
                      var arr = new Array("shubham", "saurabh", "singh")
                      var str = arr.join("+")
                      console.log(str)                                  // OUTPUT : shubham+saurabh+singh


(vii) lastIndexOf() :

        |- It returns the last index at which a given element can be found in the array, or "-1" if it is not present.

        |- The array is searched backwards, starting at fromIndex.

        |- SYNTAX :
                    array.lastIndexOf(search Element, [fromm Index])

        |- PARAMETER DETAILS :

                |- Search Element :- Element to locate in the array.

                |- fromIndex :- The index at which to start searching backwards. Default to the array's length, i.e, the whole array will be searched.
                                If the Index is greater than or equal to the length of the array, the whole array will be searched.
                                If negative, it is taken as the "offset" from the end of the array.

       |- e.g,
                   var index = [10, 20, 23, 20, 50].lastIndexOf(20)
                   console.log(index)                                                   // OUTPUT : 3


(viii) map() :
        
        |- This method creates a new array with the results of calling a provided function on every element in this array.

        |- SYNTAX :
                      array.map(callback, [this Object])

        |- e.g,
                         var num = [1, 4, 9]
                         var result = num.map(Math.sqrt)

              console.log("root is :" + num)                 // OUTPUT : 1, 2, 3

(ix) pop() :

      |- It removes the "last element" from an array and returns that element.

      |- SYNTAX :
                      array.pop()

      |- e.g, 
                        var num = [1,4,9]
var result = num.pop()
             		console.log()                    // OUTPUT : 9

(x) push() :

      |- It adds the element to the "last" of the array and returns the length of the new array.

      |- SYNTAX :
                   array.push()

       |- e.g,
                     var num = [10, 20, 30]
                     var result = num.push(40)

             console.log(result)                    //OUTPUT : 4
                     console.log(num)			    // OUTPUT : [10,20,30,40]


(xi) reduce() :

       |- This method applies a function simultaneously against "two values of the array" (from left to right) as to reduce itb to a single value.

       |- SYNTAX :
                    array.reduce(callback, [initial Value])

       |- PARAMETER DETAILS :

             |- callback :- Function to execute on each value in the array.

             |- Initial Value :- Object to use as the first argument to the first call of the callback.

       |- e.g,
                  var total = [1, 2, 3].reduce(function(a, b) { return a + b }) 
                  console.log("total is:" + total)                              // OUTPUT : 6

(xii) reduceRight() :

         |- This method applies a function simultaneously against "two values of the array" (from right to left) as to reduce itb to a single value.

         |- SYNTAX :
                       array.reduceRight(callback, [initial value])

          |- e.g,
                  var total = [1, 2, 3].reduceRight(function(a, b) {return a + b }) 
                  console.log("total is:" + total)                              // OUTPUT : 6


(xiii) reverse() :

         |- It reverses the element of an array.

         |- SYNTAX :
 			array.reverse()

         |- var arr = [1, 2, 7, 9, 45]
            var res = arr.reverse()
            console.log(res)                       // OUTPUT : [45,9,7,2,1]


(xiv) shift() :

       |- This method "removes the first element" from an array and returns that element.

       |- SYNTAX :
                       array.shift()

       |- e.g,
                    var arr = [1, 25, 656, 89]

              var res = arr.shift()

            console.log(res)                      // OUTPUT : 1

(xv) slice() :

      |- This method extracts a section of an array and returns a new array.

      |- SYNTAX :
                    array.slice(begin, [end])

             Note : Here Begin index(included) and End index(excluded) in the result.

       |- PARAMETER DETAILS :

                 |- begin :- Zero-based index at which to begin extraction.As a negative index, start indicates an offset from the end of the sequence.

                 |- end :- Zero-based index at which to end extraction.

        |- e.g,
                  var arr = ["Mango", "Apple", "Banana", "kiwi", "Kheera"]

                  var res = arr.slice(1, 3)

          console.log(res)                                            // OUTPUT : ["Apple", "Banana"]



(xvi) some() :

       |- This method tests whether some element in the array passes the test implemented by the provided function.

        |- SYNTAX :


                    array.some(callback, [thisObject])

       |- If some element passes the test, then it returns true otherwise false.

       |- e.g,
                   function isBigEnough(element)

            {
    return (element >= 10)

             }
var arr = [1, 5, 6, 9].some(isBigEnough)
                    console.log(arr)                              // OUTPUT : false.

      |-  e.g,      function isBigEnough(element)
{
    return (element >= 10)

             }
var arr = [1, 15, 6, 9].some(isBigEnough)
                    console.log(arr)                              // OUTPUT : true.

(xvii) sort() :
   
         |- It shorts the elements of an array.

         |- SYNTAX :
			array.sort(compareFunction)

         |- PARAMETER DETAILS :
            
                   |- Specifies a function that defines the sort order.If omitted, the array is sorted "lexicographically".

          |- e.g,
               var arr = new Array("mango", "banana", "apple", "guava")

            var res = arr.sort()

            console.log(res) 						// OUTPUT : apple,banana,guava,mango


(xviii) splice():

           |- This method changes the content of an array, adding new elements while removing old elements.

           |- SYNTAX :
                           array.splice(index, howMany, [element1], [element2], ... [elementN])
 
           |- PARAMETER DETAILS :

                    |- index :- Index at which to start changing the array.

                    |- howMany :- An integer indicating the number of old arrays elements to "remove". If it is "0" then no elements will be removed.

                     |- element1,... elementN :- The elements to add to the array


           |- It returns the extracted array based on the passed parameter.

           |- e.g,
                        var arr = ["mango", "banana", "apple", "guava"]

            var res = arr.splice(2, 0, "pea")

            console.log(arr)                                   // OUTPUT :    ["mango", "banana", "pea","apple" ,"guava"] 


(xix) toString() :

          |- This method returns a string representing the source code of the specified array and its elements.

          |- SYNTAX :

                |- array.toString()

          |- e.g,
                         var arr = ["shubham", "saurabh", "singh"]
                         var res = arr.toString()

             console.log(res)                           // OUTPUT : shubham,saurabh,singh

(xx) unShift() :
 
         |- This method adds one or more elements to the beginning of an array and returns the new length of the array.

          |- SYNTAX :
                        array.unshift(element1,...elementN)

           |- It returns the length of new array.

            |- e.g,
                         var arr = ["shubham", "saurabh", "singh"]
                         var res = arr.unShift("Mr.")

             console.log(res)                           // OUTPUT : 4



** Array Destructuring :

     |- Refers to breaking up the structure of the entity.

     |- TypeScript supports destructuring when used in the context of an array.

     |- e.g,
              var arr:number = [11,12]
var[x:y] = arr
console.log(x)
                console.log(y)           // OUTPUT : 11
						     12

** Array Traversal using "for…in" loop :

      |- This loop performs an index based array traversal.

      |- e.g,
                   var j : any
                   var nums:number[] = [1001, 1002, 1003, 1004]
                   for(j in nums)
{
    console.log(nums[j])
                       }                                                   // OUTPUT : 1001
										       1002
										       1003
                                         					       1004

** ARRAYS IN TYPESCRIPT :

      (i) Multi-dimensional Arrays :

              |- An array element can reference another array for its value.Such arrays are called multi-dimensional array.

               |- var arr_name:datatype[][] = [[val1, val2, val3], [v1, v2, v3]]

               |- e.g,
                           var arr:number = [[1,2,3],[19,20,21]]   
 			   console.log(multi[0][0])                            // OUTPUT :   1
               console.log(multi[0][1])                                  2
			   console.log(multi[0][2])					     3
                           console.log(multi[1][0])					     19
                           console.log(multi[1][1])                                          20
                           console.log(multi[1][2])                                          21

      (ii) Passing Array to Functions :

                |- We can pass to the function a pointer to an array by specifying the array's name without an index.

                 |- e.g,
                           var names:string[] = new Array("Mary","Tom","Jack","Jill")


                           function disp(arr_names:string[])
{
    for (var i = 0; i < arr_names.length; i++)
    {
        console.log(names[i])
                                    }
}

                 disp(names)

                       // OUTPUT
Mary
                Tom

                Jack
                Jill

      (iii) Function Returning an Array :

                |- function disp():string[] 
                    {
                        return new Array("Mary","Tom","Jack","Jill")
                    }
                
                      var nums:string[] = disp()
                    for(var i in nums){
                                        console.log(nums[i])
                     }

                  
                 // OUTPUT :
                             Mary
                 Tom
                             Jack
                             Jill



***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 13 - TUPLES

***********************************************************************************************************************************************************************

** TUPLES :

      |- It represents a heterogeneous collection of values.

      |- In other words, Tuples enable storing multiple field of "different types".

      |- It can also be passed as a functions.

      |- SYNTAX :
                       var tuple_name = [value1, value2, ...valueN]

      | -e.g,
                    var myTuple = [10, "Hello"]

      | -We can also declare an "empty tuple" in TS and choose to initialize it later.

                   var mutuple = []
                   myTuple[0] = 120
                   myTuple[1] = 140


* *Accessing Values in Tuples :

       |- Tuple values are individually called items.

       |- These are index based.

       |- This means that item in a tuple can be accessed using their corresponding numeric index.

       |- Tuple item index start from "zero" and extends upto "n-1" (where 'n' is the tuples size). 

        |- SYNTAX :

                        var tuple_name[index]
        |-  e.g.
                      var myTuple = [10, "shubham"]
                      console.log(myTuple[0])
              console.log(myTuple[1])                         // OUTPUT :    10

                                             shubham


  ** Note : All the operations which are valid on string are also valid on tuples.

***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 14 - UNION

***********************************************************************************************************************************************************************

** UNION :

      |- These are a powerful way to express a value that can be one of the several types.

      |- "Two or more Data Types" are combined using the "pipe symbol (|)" to denote a union type.

      |- In other words, a union type is written as a sequence of types separated by vertical bars.
 
      |- SYNTAX :
                   var var_name = Type1 | Type 2 | Type 3

      |- e.g,
               var val : number | string
               val = "This is string"
               consol.log(val)
        val = 12

        console.log(val)                             // OUTPUT : This is string
                                                                         12 

 ** Union Type and Function Parameter :

      |- e.g,
                   function disp(name : string | string[])
{
    if (name == "string")
    {
        console.log(name)
                       }
    else
    {
        console.log(name[i])
                      }
}
                    disp("TypeScript")
                    disp(["shubham", "saurabh", "singh"])                     // OUTPUT : TypeScript

                                              shubham
                                                  saurabh

                                                  singh


** Union Type And Array :

      |- e.g,
                var arr : number[] | string[]
                var i : number
                arr = [11, 22, 33]
                for(i = 0; i<arr.length; i++)
                {
			console.log(arr[i])
                } 
               arr = ["man", "women", "child"]
               for(i = 0; i<arr.length; i++)
                {
			console.log(arr[i])
                }                                                            // OUTPUT : 11
											 22
										         33
                             								man
                                            women

                                                child


***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 15 - Interfaces

***********************************************************************************************************************************************************************

** Interface :

      |- It defines the syntax that any entity must adhere to.

      |- It defines properties, methods, and events, which are the members of the interface.

      |- Interfaces contain only the declaration of the members.

      |- It is the responsibility of the deriving class to define the members.

      |- It often helps in providing a standard structure that the deriving classes would follow.

** Declaring Interface :

      |- Let's consider an object -


                                       var person = { firstName: "Tom" , lastName: "Jerry" , sayHi: () => { return "Hi" } };

        --> If we consider the "signature" of the object, it could be :

                          { firstName:string , lastName:string, sayHi() => string  }


        --> To "reuse the signature" across objects we can define it as an "interface".



      |- SYNTAX :
                       interface interface_name { }

      |- e.g,
                      interface Iperson
{

    firstName : string
    lastName : string
                    sayHi : () => string
}

var customer : Iperson = {

                               firstName : "Tom"
        			lastName : "Jerry"
				sayHi : () : string => { return "Hey There"}
                        }
											// OUTPUT :
                     console.log("Customer Object")							Customer Object
                     console.log(customer.firstName) Tom

             console.log(customer.lastName) Jerry
                     console.log(customer.sayHi())							Hey There

                     var Employee : Iperson = {

                              firstName : "shubham"
			      lastName : "saurabh"
                              sayHi: () : string => { return "Hello" }
                       }
										     // OUTPUT :
                    console.log("Employee Object")							Employee Object
                    console.log(Employee.firstName) shubham

            console.log(Employee.lastName) saurabh
                    console.log(Employee.sayHi())							Hello



** NOTE :
     |- Interfaces are not to be converted to JavaScript.
    
     |- It just a type of TypeScript.

     |- So interfaces have "Zero runtime JavaScript impact"


** UNION Type and INTERFACE :

     |- e.g,
             interface RunOptions
{

    program : string
          commandLine : string[] | string | (() => string)
             }

// Command Line as a string                                                             // OUTPUT :

var options : RunOptions = { program : "test1" , commandLine : "Hello" }                 Hello
console.log(options.commandLine)

            // Command Line as a string array 

var options : RunOptions = { program : "test2" , commandLine : ["Hey", "There"] }          // OUTPUT
		console.log(options.commandLine)["Hey", "There"]

                // Command Line as a function Expression

                var options : RunOptions = { program : "test3", commandLine : () : => {return "** Hello S3 **"} }
		var result : any = options.commandLine
        console.log(result())												// OUTPUT 

                                                                  ** Hello S3**


** Interfaces and Arrays :

      |- Interfaces can define both the kind of key an array uses and the type of entry it contains.

      |- Index can be of type "string" or "number"

      |- e.g,
                interface nameList
{

    [index: number] : string
}

var list2 : nameList = ["John", 1 , "Bran"]    //Error. 1 is not type string

interface ages
{

    [index:string] : number
}

var agelist : ages
agelist["John"] = 15    // OK
                agelist[2] = "nine"     // Error


** Interface and Inheritance :

        |- An Interface can be extended by other interfaces.In other words, an interface can inherit from other interface.

        |- TS allows an interface to inherit from multiple interfaces.

        |- "extends" keywords is used to implement inheritance among interfaces.

        |- e.g,

           (i) Single Interface Inheritance :


                        interface Person
{

    age : number
}

interface Musician extends Person
{

    instrument : string
                       }

var drummer = < Musician >{}
			drummer.age = 23
			drummer.instrument = "drums"
 			console.log("Age :" + drummer.age)
			console.log("Instrument :" + drummer.instrument)                             // OUTPUT :
															23

                                                            drums


          (ii) Multiple Interface Inheritance :

                        interface IParent1
{

    v1 : number
}
interface IParent2
{

    v2 : number
}

interface Child extends IParent1, IParent2 {}
 
                        var Iobj : Child = { v1:12, v2:23 }
                        console.log("value1 :" + Iobj.v1 + "value2 :" + Iobj.v2)                    // OUTPUT 
													value1 : 12 value2 : 23


***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 16 - Classes

***********************************************************************************************************************************************************************

** Classes :

      |- TS is object oriented JS.

      |- TS supports object-oriented programming featurtes like classes, interfaces, etc.

      |- A class in terms of OOP is a blueprint for creating objects.

      |- A class encapsulates data for the object.

      |- TS gives "built-in support" for this concept called class

      |- JS ES5 or earlier didn't support classes. TypeScript gets this feature from ES6

** Creating Classes :

      |- use "class" keyword to declare a class in TS.

      |- SYNTAX :

                        class class_name
{

    //class scope
}

       |- A class definition include the following :

          (i) Fields :
 
                |- A field is any variable declared in a class. It represents data pertaining to objects.

          (ii) constructors :

                |- Responsible for allocating memory for the object of the class.

                |- It is a "special function of the class" that is responsible for "initializing the variables" of the class.

         (iii) Functions :

               |- It represent actions an object can take.They are also some times referred to as methods.

      Note :- These components put together are termed as the data members of the class.


       |- e.g,

                     class car
{
    // field

    engine : string

    // Constructor

    constructor(engine:string)
    {

        this.engine = engine
                        }

                        //function

            disp():void {

                       	   console.log("Engine is:"+this.engine)
                        }
                     }

** Creating Instance Objects :

        |- To create an instance of the class, use the "new" keyword followed by the class name.

        |- SYNTAX :

                         var object_name = new class_name([arguments])

        |- "new" keyword is responsible for instantiation.

        |- The Right-Hand-Side of the expression invokes the constructor.The constructor should be passed values if it is parameterized.
 
        |- e.g,

                 var obj = new Car("Engine1")

* *Accessing Attributes and Functions :

       |- A class's object and functions can be accessed through the object.

      |- Use "Dot (.)" notation to access the data members of the class.

      |- dot notation also known as "period"

      |- e.g,
                      class car
{
    // field

    engine : string

    // Constructor

    constructor(engine:string)
    {

        this.engine = engine
                        }

                        //function

            disp():void {

                       	   console.log("Engine is:"+this.engine)
                        }
                     }

                    // Create an Object

                     var obj = new Car("XXSY1")

                    // access the field 

console.log("Reading attribute value Engine as :  " + obj.engine) 

                   // access the function

                      obj.disp()

                                                        // OUTPUT : Reading attribute value Engine as :  XXSY1 
                                                        Function displays Engine is  :   XXSY1


** Class Inheritance :

      |- Inheritance is the ability of a program to create new classes from an existing class.

      |- The class that is extended to create a newer classes is called the parent class/super class.

      |- The newly created classes are called the child/sub classes.

      |- A class inherits from other class using the "extends" keyword.

      |- child classes inherit all properties and methods except constructors from the parent class.

       |- SYNTAX :
			class child_class_name extends parent_class_name

       Note :- TS does not support multiple inheritance.

        |- e.g,
                  class shape
{

    Area : number
     constructor(a:number)
    {
        this.Area = a
                    }
}

class Circle extends shape
{

    disp(): void {
        console.log("Area of the circle :" + this.area)
                      }
}
var obj = new Circle(223)                                        // OUTPUT : 223
                        obj.disp()




** Inheritance in TS :

       (i) Single :
     
             |- Every class can at the most extend from one parent class.

       (ii) Multiple :

             |- A class can inherit from multiple classes.

             |- ypeScript doesn’t support multiple inheritance.

      (iii) Multi-Level :

             |- The following example shows how multi-level inheritance works.

             |- e.g,
                         class Root
{

    str : string
}

class child extends Root { }
class Leaf extends child { }
var obj = new Leaf()
                         obj.str = "hello"
			console.log(obj.str)                    // OUTPUT : hello

** TypeScript ─ Class inheritance and Method Overriding :

        |- Method overriding is a mechanism by which the child class redefines the superclass's method.

        |- e.g,
                      class PrinterClass
{


            doPrint() :void{
                     
                        console.log("doPrint() from parent called")
                       }
                      }
                 
                      class StringPrinter extends PrinterClass
{

    doPrint() :void {

        super.doPrint()
                           console.log("doPrint() is printing a string")
                       }
}
var obj = new StringPrinter()
                          obj.doPrint()                                         // OUTPUT :    doPrint() from parent called
                                                doPrint() is printing a string


        |-  The "super" keyword is used to refer to the "immediate parent of a class".

        |- The keyword can be used to refer to the super class version of a variable, property or method.


** The Static Keyword :

         |- It can be applied to the "data members of a class".

         |- A static variable retains it's value till the program finishes execution.

         |- Static members are referenced by the class name. 

          |- e.g,
                     class StaticMem
{

    static num : number

                           static disp() : void{

                                  console.log("The value of number is :" + StaticMem.num)
                        }                
                     }

                       StaticMem.num = 121
                       StaticMem.disp()                              // OUTPUT : The value of number is 121

** The instanceof operator :

       |- It returns "true" if the object belongs to the specified type.

       |- e.g,
                   class Person { }
var obj = new Person { }
                   var isPerson = obj instanceof Person
                   console.log("obj is an instance of person"+ isPerson)  // OUTPUT : obj is an instanceof person : True


** Data Hiding / Encapsulation :

         |- A class can control the "visibility of its data members" to members of other classes.This capability is termed as Data Hiding or Encapsulation.
    
         |- Object Orientation uses the concept of "access modifiers" or "access specifiers" to implement the concept of Encapsulation.

         |- The "access specifiers/modifiers define the visibility" of a class’s data members "outside" its defining class.

         |- The access modifiers supported by TypeScript are −

            (i) public :

                 |- A public data member has universal accessibility.

                 |- Data memebers in a class are public by default.

           (ii) private :

                 |- Private data members are accessible only within the class that defines these members.
 
                  |- If an external class member tries to access a private member, the compiler throws an error.

          (iii) protected :

                  |- A protected data member is accessible by the members within the same class as that of the former and also by the members of the child classes.


             |- e.g,
                                class Encapsulate
{

    str : strig = "hello"
				    private str2 : string = "world"                                  
                                }

var obj = new Encapsulate()
                                   console.log(obj.str)          // accessible
                                   console.log(obj.str2)         // compilation Error as str2 is private


** Classes and Interface :

       |- classes can also implement interfaces.

       |- e.g,
                   interface Iloan
{

    interest : number
}
class AgriLoan
{

    interest : number
rebate : number

 constructor(interest :number , rebate : number)
    {

        this.interest = interest

                this.rebate = rebate
                       }
}
var obj = new Agriloan(10, 1)
                       console.log("Interest is :" + " " + obj.interest + " " + "rebate is :" + " " + obj.rebate )

                       // OUTPUT : Interest is 10 rebate is 1



***********************************************************************************************************************************************************************

                                                                  TYPESCRIPT : 17 - Objects

***********************************************************************************************************************************************************************


                  

         





                      


                                                            



}
