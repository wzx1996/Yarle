<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//Don't feel like using the foreach-statement? Well here's a ForEach() function you can use instead.

foreach(var i in Yarle.Repeat(10)) "Hello!".Dump();

Yarle.Repeat(10).ForEach(x=>"Hello!".Dump());

//There's also a variation called ForEachEach() that acts like SelectMany() but does not return a new list

//So you can replace 2D "foreach" as well

Yarle.Grid(10,10).ForEachEach(x=>x.ToString().Dump());