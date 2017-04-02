<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//If you consider the LINQ function Skip() and Take() function too cryptic for your code, well, here take a free candy.

//Please remember that the index starts from 0 rather than 1

Yarle.Cardinal(10).Skip(3).Take(5).Dump();

Yarle.Cardinal(10).PickRange(3,8).Dump();

//For 2D list, use the counterpart called PickSubarea():

Yarle.Grid(10,10).PickSubarea(3,8,3,6).Dump();