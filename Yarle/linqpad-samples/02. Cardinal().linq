<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//You certainly used a lot of for-statements, for example, this:
{
	List<int> list=new List<int>();
	for(int i=0;i<10;i++) list.Add(i);
	list.Dump();
}

//It's kinda not so fun anymore, isn't it?

//Well, fear not, as Cardinal() for the rescue!

//Now you simply type this to do the same thing:

Yarle.Cardinal(10).Dump();

//Simple, right?

//It comes with other forms as well, so that you can almost never use "for" again:

Yarle.Cardinal(1,5).Dump();

Yarle.Cardinal(5,1).Dump();//Cardinal() is smart enough to generate descending list

Yarle.Cardinal(from: 10,to: 100, step: 10).Dump();

Yarle.Cardinal(100,10,-10).Dump();

Yarle.Cardinal(1.0,10.0,0.5).Dump(); //Beware that it's not guaranteed you get the last value if you use float point value, as they are always inaccurate

//And now, some advanced usage example:

Yarle.Cardinal(1,10).Select(x=>x*x).Dump();

Yarle.Cardinal(1,100).Sum().Dump();