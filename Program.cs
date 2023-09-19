/*
 * Author:          Sydnie Dery
 * Date:            9/9/23
 * Purpse:          Read in .csv file of video games. Offer user option to get data on Genres or Publishers. 
 * 
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Numerics;
using System.Globalization;
using DictionaryLab;
using System.Security.Policy;
using System.Diagnostics;

namespace DictionaryLab
{
    public class Program
    {

        static void Main(string[] args)
        {
            //create dictionary and a list of video games for each platform. add each list into the dictionary with the key being the name of the platform
            Dictionary<string,List<VideoGame>> allGames = new Dictionary<string,List<VideoGame>>();
            List<VideoGame> list2600 = new List<VideoGame>();
            allGames.Add("2600", list2600);
            List <VideoGame> list3DO = new List<VideoGame>();
            allGames.Add("3DO",list3DO);
            List<VideoGame> list3DS = new List<VideoGame>();
            allGames.Add("3DS",list3DS);
            List<VideoGame> listDC = new List<VideoGame>();
            allGames.Add("DC",listDC);
            List<VideoGame> listDS = new List<VideoGame>();
            allGames.Add("DS",listDS);
            List<VideoGame> listGBA = new List<VideoGame>();
            allGames.Add("GBA",listGBA);
            List<VideoGame> listGC = new List<VideoGame>();
            allGames.Add("GC",listGC);
            List<VideoGame> listGEN = new List<VideoGame>();
            allGames.Add("GEN",listGEN);
            List<VideoGame> listGG = new List<VideoGame>();
            allGames.Add("GG",listGG);
            List<VideoGame> listN64 = new List<VideoGame>();
            allGames.Add("N64",listN64);
            List<VideoGame> listNES = new List<VideoGame>();
            allGames.Add("NES",listNES);
            List<VideoGame> listNG = new List<VideoGame>();
            allGames.Add("NG",listNG);
            List<VideoGame> listPC = new List<VideoGame>();
            allGames.Add("PC", listPC);
            List<VideoGame> listPCFX = new List<VideoGame>();
            allGames.Add("PCFX",listPCFX);
            List<VideoGame> listPS = new List<VideoGame>();
            allGames.Add("PS",listPS);
            List<VideoGame> listPS2 = new List<VideoGame>();
            allGames.Add("PS2",listPS2);
            List<VideoGame> listPS3 = new List<VideoGame>();
            allGames.Add("PS3",listPS3);
            List<VideoGame> listPS4 = new List<VideoGame>();
            allGames.Add("PS4",listPS4);
            List<VideoGame> listPSP = new List<VideoGame>();
            allGames.Add("PSP",listPSP);
            List<VideoGame> listPSV = new List<VideoGame>();
            allGames.Add("PSV", listPSV);
            List<VideoGame> listSAT = new List<VideoGame>();
            allGames.Add("SAT",listSAT);
            List<VideoGame> listSCD = new List<VideoGame>();
            allGames.Add("SCD",listSCD);
            List<VideoGame> listSNES = new List<VideoGame>();
            allGames.Add("SNES",listSNES);
            List<VideoGame> listTG16 = new List<VideoGame>();
            allGames.Add("TG16",listTG16);
            List<VideoGame> listWii = new List<VideoGame>();
            allGames.Add("Wii",listWii);
            List<VideoGame> listWiiU = new List<VideoGame>();
            allGames.Add("WiiU",listWiiU);
            List<VideoGame> listWS = new List<VideoGame>();
            allGames.Add("WS",listWS);
            List<VideoGame> listX360 = new List<VideoGame>();
            allGames.Add("X360", listX360);
            List<VideoGame> listXB = new List<VideoGame>();
            allGames.Add("XB",listXB);
            List<VideoGame> listXOne = new List<VideoGame>();
            allGames.Add("XOne", listXOne);

            string filePath = @"..\..\Data\videogames.csv";


            //  @"C:\Users\sydni\OneDrive - East Tennessee State University\Semester 7\Server Side\Labs\VideoGameLab\VideoGameLab\Data\videogames.csv";
            StreamReader reader = null;
            //only do this if the path is right 
            if (File.Exists(filePath))
            {


                reader = new StreamReader(File.OpenRead(filePath));
                var line = reader.ReadLine();
                //read each line of the csv and create a VideoGame object and add it to the list.
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var values = line.Split(',');
                    Genre inputAsEnum = decideGenre(values[3]);
                    VideoGame game = new VideoGame(values[0], values[1], values[2], inputAsEnum, values[4], values[5], values[6], values[7], values[8], values[9]);
                    switch (values[1]) 
                    {
                        case "2600":
                            list2600.Add(game);
                            break;
                        case "3DO":
                            list3DO.Add(game);
                            break;
                        case "3DS":
                            list3DS.Add(game);
                            break;
                        case "DC":
                            listDC.Add(game);
                            break;
                        case "DS":
                            listDS.Add(game);   
                            break;
                        case "GBA":
                            listGBA.Add(game);
                            break;
                        case "GC":
                            listGC.Add(game);
                            break;
                        case "GEN":
                            listGEN.Add(game);
                            break;
                        case "GG":
                            listGG.Add(game);
                            break;
                        case "N64":
                            listN64.Add(game);
                            break;
                        case "NES":
                            listNES.Add(game);
                            break;
                        case "NG":
                            listNG.Add(game);
                            break;
                        case "PC":
                            listPC.Add(game);
                            break;
                        case "PCFX":
                            listPCFX.Add(game);
                            break;
                        case "PS":
                            listPS.Add(game);
                            break;
                        case "PS2":
                            listPS2.Add(game);
                            break;
                        case "PS3":
                            listPS3.Add(game);
                            break;
                        case "PS4":
                            listPS4.Add(game);
                            break;
                        case "PSP":
                            listPSP.Add(game);
                            break;
                        case "PSV":
                            listPSV.Add(game);
                            break;
                        case "SAT":
                            listSAT.Add(game);
                            break;
                        case "SCD":
                            listSCD.Add(game);
                            break;
                        case "SNES":
                            listSNES.Add(game);
                            break;
                        case "TG16":
                            listTG16.Add(game);
                            break;
                        case "Wii":
                            listWii.Add(game);
                            break;
                        case "WiiU":
                            listWiiU.Add(game);
                            break;
                        case "WS":
                            listWS.Add(game);
                            break;
                        case "X360":
                            listX360.Add(game);
                            break;
                        case "XB":
                            listXB.Add(game);
                            break;
                        case "XOne":
                            listXOne.Add(game);
                            break;

                    }
                }//end while 
            }//end if 
            else
            {
                Console.WriteLine("File doesn't exist");
            }//end else 

            foreach (var entry in allGames)
            {

                var top5 = entry.Value.OrderByDescending(game => game.Global_Sales).Take(5);
                foreach (var game in top5)
                {
                    Console.WriteLine(game.ToString());

                }//end foreach
             }
            Console.WriteLine("What platform would you like data on?");
            string platform = Console.ReadLine();
            var platform5 = allGames[platform].OrderByDescending(game => game.Global_Sales).Take(5);
            foreach (var game in platform5)
            {
                Console.WriteLine(game.ToString());
            }
               

            Console.ReadLine();
        }//end main

        
        //Method to decide which genre was input and return a Genre Enum object. 
        public static Genre decideGenre(string inputString)
        {
            Genre inputasenum = new Genre();
            switch (inputString)
            {
                case "Action":
                    inputasenum = Genre.Action;
                    break;
                case "Adventure":
                    inputasenum = Genre.Adventure;
                    break;
                case "Fighting":
                    inputasenum = Genre.Fighting;
                    break;
                case "Misc":
                    inputasenum = Genre.Misc;
                    break;
                case "Platform":
                    inputasenum = Genre.Platform;
                    break;
                case "Puzzle":
                    inputasenum = Genre.Puzzle;
                    break;
                case "Racing":
                    inputasenum = Genre.Racing;
                    break;
                case "Role-Playing":
                    inputasenum = Genre.RolePlaying;
                    break;
                case "Shooter":
                    inputasenum = Genre.Action;
                    break;
                case "Simulation":
                    inputasenum = Genre.Simulation;
                    break;
                case "Sports":
                    inputasenum = Genre.Sports;
                    break;
                case "Strategy":
                    inputasenum = Genre.Strategy;
                    break;
            }//end switch 
            return inputasenum;
        }//end method

    }
}