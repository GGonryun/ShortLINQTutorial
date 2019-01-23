## Thanks for checking out this tutorial!
If anything isn't clear enough or incorrect, note it and I will adjust this guide according to your feedback. Instructions within brackets [] are atomic actions, these should be performed in that specific sequence without interruption. 

The `=>` means "and then".

For Example:
To highlight groups of text first you [Highlight Text => Press Ctrl + K => Press C] 

You can also expect to find additional sources at the end of this file. 
This short sequence is to familiarize yourself with the structure of LINQ and it's basic functions.

## How to start:
To start the sequence, please download the solution to a folder. Open Microsoft Visual Basic 2017 => Open Project/Solution => Navigate to the folder with the tutorial and open => Linq Tutorial.sln

## What is LINQ?
[L]anguage [IN]tegrated [Q]uery! It is a part of our programming language syntax, in fact it is a programming language syntax for querying in-memory data.

### Why use LINQ?
Remember OS class? When we're Querying objects we typically have to access data structures outside of our memory, these calls are slow and require the use of external tools in order to access our data (SQL). LINQ allows us to bring these data structures into our program, put them in memory, and execute our searches on in-memory objects. 

### Objects you say? 
That's right ladies and gentlement, ~Objects~. Most traditional data is stored much like an object. Orders have customers, and an SQL Query would probably model it similarly (We'll use the order as a key and then grab a customers object). But this can strain our mental model, wouldn't it be easier if we could just Query objects that already exist as part of our Requirements Vocabulary? 
             
