<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//You may use Yarle.Repeat() to repeat an element several times, but it might be confusing at first

//Without Repeat(), you might do something like this:

new int[10].Select(x=>"Hello!").Dump();

//it's totally readable but feels more like a "hack", plus you have to spend an extra 40 bytes of memory to execute it.
//With Repeat(), you might code the same line like this:

Yarle.Repeat(10).Select(x=>"Hello!").Dump();

Yarle.Repeat(10,"Hello!").Dump();

Yarle.Repeat(10,()=>"Hello!").Dump();


//Here's some more advanced examples:
{
	var i=1;
	Yarle.Repeat(10).Select(x=>string.Format("Row {0}",i++)).Dump();
}

{
	Yarle.Repeat(3,"Text 1").Concat(Yarle.Repeat(5,"Text 2")).Dump();
}