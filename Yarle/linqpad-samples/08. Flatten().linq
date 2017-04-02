<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//If you just want to flatten a 2D list into a 1D list, SelectMany() is overkill.

//So here's something a little bit more lightweight.

Yarle.Grid(3,3).SelectMany(x=>x).Dump();

Yarle.Grid(3,3).Flatten().Dump();