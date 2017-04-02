<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//SelectMany() is useful, but what if you want to keep the jagged list afterwards, rather than having it flattened?

//Well, just use GridMap and you can keep your 2D jagged list rather than having to use two Select() and thus your code is clearer.

Yarle.Grid(5,8).Select(x=>x.Select(y=>y.X+y.Y)).Dump();

Yarle.Grid(5,8).GridMap(x=>x.X+x.Y).Dump();