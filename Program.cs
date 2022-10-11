using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Making a list to store information of candidates
            List<Candidate> candidateInfo = new List<Candidate>();

            //Making a list to store information of filtered candidates
            List<Candidate> filteredCandidates = new List<Candidate>();

            ////Making a list to store documents information
            //List<Document> documents = new List<Document>();


            Console.WriteLine("Welcome to the TechLift Registration Portal!\nPlease enter your details to get registered with us.");


            //Hardcoded list of 15 candidates registered with Techlift
            List<string>  info = new List<string>() { "Ahmad Ali", "3610115708705", "3.53", "Lahore",
                                                              "Mustafa Hayat", "3610115704367", "3.50", "Lahore",
                                                              "Waqar Anjum", "3610115704368", "3.00", "Rawalpindi",
                                                              "Umar Asif", "3610115704369", "3.59", "Rawalpindi",
                                                              "Ali Hayat", "3610115704370", "2.5", "Karachi",
                                                              "Ibtisam Umer", "3610115704371", "2.75", "Islamabad",
                                                              "Taimoor Pal", "3610115704372", "3.89", "Gujranwala",
                                                              "Ahmad Hussain", "3610115704373", "3.65", "Multan",
                                                              "Faisal Shahid", "3610115704374", "3.20", "Lahore",
                                                              "Omer Ashraf", "3610115704375", "3.10", "Rawalpindi",
                                                              "Junaid Akram", "3610115704376", "2.90", "Lahore",
                                                              "Uzair Ali", "3610115704377", "2.99", "Lahore",
                                                              "Usman Akhtar", "3610115704378", "2.45", "Lahore",
                                                              "Faraz Abbas", "3610115704379", "4.00", "Lahore",
                                                              "Noor Fatima", "3610115704380", "3.78", "Faisalabad",
                                                             };




            //Adding the candidates information into the list, each as a seperate object 
            for (int i = 0; i < info.Count() - 3; i++)
            {
                //Creating an object of Candidate class
                Candidate Can = new Candidate();

                Can.name = info[i];
                Can.CNIC = info[i + 1];
                Can.CGPA = info[i + 2];
                Can.city = info[i + 3];
                i = i + 3;

                //Adding each object into the list
                candidateInfo.Add(Can);
            }





            //Filtering the candidates having more than 3.00 CGPA
            for (int i = 0; i < candidateInfo.Count; i++)
            {
                if (Convert.ToDouble(candidateInfo[i].CGPA) >= 3.00)
                {
                    filteredCandidates.Add(candidateInfo[i]); //Adding the candidates into filtered list having more than 3.00 CGPA
                }
            }











            //Console.WriteLine("***************************************");
            //for (int i = 0; i < filteredCandidates.Count; i++)
            //{
            //    Console.WriteLine(filteredCandidates[i].name);
            //    Console.WriteLine(filteredCandidates[i].CNIC);
            //    Console.WriteLine(filteredCandidates[i].CGPA);
            //    Console.WriteLine(filteredCandidates[i].city);
            //    Console.WriteLine("***************************************");
            //}
                Console.ReadLine();
        }
    }
}
