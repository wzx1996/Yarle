<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//It's kinda not that fun to convert between multidimensional and jagged 2D array.

//So here's some functions to make life easier.

var array2D=Yarle.Grid(3,3).ToArray2D();

array2D.Dump();

var array2DJagged=array2D.ToJaggedArray();

array2DJagged.Dump();

array2DJagged.ToMultiDimensionArray().Dump();

array2D.AsJaggedEnumerable().Dump();

array2DJagged.AsJaggedEnumerable().Dump();