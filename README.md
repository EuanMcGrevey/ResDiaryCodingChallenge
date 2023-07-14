I used mono[https://www.mono-project.com/docs/about-mono/supported-platforms/linux/] to compile and run this solution. Failing that, paste the files into an online compiler[https://www.onlinegdb.com/online_csharp_compiler] (you may need to move namespaces / sort usings)

# Installation: 
 - sudo apt update
 - sudo apt install mono-complete

# Running:
- mcs -out:solution.exe Program.cs Utils.cs
- mono solution.exe

The Utils.cs file contains the solution method: groupArrayElements, everything else just helps to test that method.