<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//Now that you have Cardinal() to replace 1D for-statements, you might want something for 2D as well.

//So, here's Grid().

//Further development is needed, but here's some quick example:

Yarle.Grid(10,10).Dump();

Yarle.Grid(10,10).GridMap(x=>(x.X+x.Y)).Dump();//We'll take a look at GridMap() later