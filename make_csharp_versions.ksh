#!/bin/bash
# This is a simple shell to create the C# projects base from each of the Python code sources for CS212


# try just one:
# for s in `ls Python/01-prove_multiples_of*.py`

for s in `ls Python/*.py`
do
	fname=`basename ${s}|cut -d'.' -f1`
	h="/tmp/head$$"
	head -10 ${s} |grep -v '"""' > ${h}
	lab=`head -10 ${s} |egrep "^[0-9]"`;lab="CSE212:  ${lab}"
	dotnet6="//---  Created from: dotnet new console.   See https://aka.ms/new-console-template for more information  ---//"
	rm -rf  C-Sharp/${fname}
	dotnet new console -o C-Sharp/${fname} 2>&1 > /dev/null
	# get rid of the default "Program.cs"
	rm C-Sharp/${fname}/Program.cs
	# I'll add the MS comment so students know about the template
	newcs="C-Sharp/${fname}/${fname}.cs"
	echo "/********" > $newcs
	cat $h >> $newcs
	echo ${dotnet6} >>  ${newcs}
	echo "********/" >> ${newcs}
	echo "Console.WriteLine(\"${lab}\");  // Comment out this line" >>${newcs}
	echo "Did:  ${fname}"
done

