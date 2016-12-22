/**
Literate sample
===============

This file demonstrates how to write literate C# script
files(`*.csx`) that can be transformed into nice HTML
using the `literate.fsx` script from the[F# Formatting
package](http://tpetricek.github.com/FSharp.Formatting).

As you can see, a comment starting with double asterisk
is treated as part of the document and is transformed
using Markdown, which means that you can use:

 - Unordered or ordered lists
 - Text formatting including **bold * *and _emphasis_

And numerous other[Markdown][md]
features.


[md]: http://daringfireball.net/projects/markdown

Writing C# code
---------------
Code that is not inside comment will be formatted as
a sample snippet(which also means that you can
run it in Visual Studio or MonoDevelop).
*/

using System;

/// The Hello World of functional languages!
int Factorial(int x)
{
    if (x == 0)
        return 1;
    return x * (Factorial(x - 1));
}

var f10 = Factorial(10);



/**
Hiding code
-----------

If you want to include some code in the source code, 
but omit it from the output, you can use the `hide` 
command.
*/

/***hide ***/
/// This is a hidden answer
var hidden = 42;

/**
The value will be deffined in the F# code and so you
can use it from other (visible)code and get correct
tool tips:
*/

var answer = hidden;

/**
Moving code around
------------------

Sometimes, it is useful to first explain some code that
has to be located at the end of the snippet(perhaps
because it uses some definitions discussed in the middle).
This can be done using `include` and `define` commands.

The following snippet gets correct tool tips, even though
it uses `laterFunction`:
*/

/***include:later - bit ***/

/**
Then we can explain how `laterFunction` is defined:
*/

string LaterFunction() => 
    "Not very difficult, is it?";

/**
This example covers pretty much all features that are
currently implemented in `literate.fsx`, but feel free
to[fork the project on GitHub][fs] and add more
features or report bugs!

  [fs]: https://github.com/tpetricek/FSharp.Formatting

*/

/***define:later - bit ***/
void Sample() =>
    Console.WriteLine($"Got: {LaterFunction()}");


/**

Other features
--------------

The tool - tips also work for double - backtick identifiers.
  This might be useful to generate nice documents from tests:

*/
void One_plus_one_should_be_equal_to_2()
    => 1 + 1 = 2;

/**
Others examples follow here.
*/

