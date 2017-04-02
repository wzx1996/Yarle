<Query Kind="Statements">
  <NuGetReference>org.flamerat.Yarle</NuGetReference>
  <Namespace>org.flamerat.Yarle</Namespace>
</Query>

//Kindly reminder: Dump() is LINQPad's fancy way of saying "print out the whole list"

//Do you feel like having a list that just go on forever,
//but you just hate using "while"?

//Well, here's something easier to use. You only need one (or two) initial value(s) to
//generate a list that goes on forever, and you can just snip a part of the list out
//to make use of it.

Yarle.InfiniteList(x=>x+1,1).Take(100).Dump();

Yarle.InfiniteList((x1,x2)=>x1+x2,1UL,1UL).Take(60).Dump();

//There's never an easier way to generate Fibonacci list in C#, isn't it? :)

//Oh, you can use this for calculating square root because, well, why not?

{
	var n=123456.0;
	Func<double,double> newtonian=x=>0.5*(x+n/x);
	Yarle.InfiniteList(newtonian,n).Take(20).Dump();
	Yarle.InfiniteList(newtonian,n).ElementAt(100).Dump();
}