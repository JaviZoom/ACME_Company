# ACME_Company
Overview   
The program is a console program.
When the program is compiled, it automatically throw the answer or output.
The program read a file that has the datasets, then it start to analize each line of the document, and each line is saved into a List. After this,
each line saved in the list is analized individually in order to get the necessary information about each employee.
After this, the program create an object employee which has the atributes of the class Employe, then the schedule of all the employees that are in the list are compared 
in order to know if they have coincided in the office, if yes, the days that the employees coincided is summed, so now we know how many times they have coincided.
Then the program write the output with the counter of days that they have coincided. 
If there are many input datasets, the program automatically analize the information and write "-------" between each dataset.
I didn't use testing for the solution of this program because I analized each iteration step by step in order to know the information saved in each variable, to know with which information
I was working with.
Example 
char a= 'a';
string aux="";
for (int i=0;i<5;i++)
	{
		aux=aux+a;
	}
Going step by step I know that when i=0 aux = "a", when i=1 aux = "aa", when i=2 aux = "aaa", when i=3 aux = "aaaa", when i=4 aux = "aaaaa"


Architecture
The program has two different classes. 
The first class is the class of the solution, here we can find many functions needed in order to obtain determined information, also here we can find the Main logic of the solution.
The second class is used to create the object employee which has its own atributes, needed to compare the information of each employee.

Approach and methodology             
In order to obtain the solution, I had to analize each problem individually.
The first thing that I had to do, was to determine the location of the document file and then obtain the necessary information of this document.
Once determined the solution of reading the file I had to analize the information, because it all has a string type, so I had to determine the name and the work schedule of each employee.
After this I needed to save this information so I created lists in order to save this information.
Once the information were saved, I had to compare each employee work scredule to obtain the coincidence of the employees compared, for this, I started with the comparison with the first and
the second employee (in case of being more than one employee), then the first and the third, etc. Then the second with the third, the second with the fourth, etc, until the last employee is reached.
With this information the solution was created and published in the console.
 
 
Instructions how to run the program locally            
*The program is written in C#, so it can run using Visual Studio or Visual Studio Code.
*There is no problem with the reading and writing of the document .txt, because it is inside the bin folder of the solution.
(in case of adding new datasets, consider the correct format of the datasets which is:)
INPUT:
RENE=MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00- 21:00
ASTRID=MO10:00-12:00,TH12:00-14:00,SU20:00-21:00
ANDRES=MO10:00-12:00,TH12:00-14:00,SU20:00-21:00
*After "INPUT" there must be ":" otherwise, the program will not analize that dataset.
*After the name there must be "=" otherwise the program will not run propperly.
*Days and work schedule must have this format: First two letter of the day, period of work separated with "-". Ex. "MO10:00-12:00".
*In case of more than one work day, separate days using ",".
