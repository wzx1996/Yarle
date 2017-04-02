<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//You have a jagged list, you want a 2D array, then what would you do?

//For jagged array you can do it with one line of code but it's cryptic, 
//but for multidimensional array you'll have to write a long code snipper.

//Well, I've done that for you, so, enjoy :)

Yarle.Grid(10,10).Select(x=>x.ToArray()).ToArray().Dump();

Yarle.Grid(10,10).ToArray2DJagged().Dump();

Yarle.Grid(10,10).ToArray2D().Dump();