//DateTime TarigiSaati = DateTime.Now;
     Console.WriteLine("Sheiyvanet Saati");

     TimeSpan Dro = TimeSpan.Parse(Console.ReadLine());

   //TimeSpan Dro = TarigiSaati.TimeOfDay; 

       
   TimeSpan Dila = new TimeSpan(5, 0, 0);  
   TimeSpan DilisDasasruli = new TimeSpan(11, 59, 59);  

   TimeSpan ShuaDge = new TimeSpan(12, 0, 0); 
   TimeSpan ShuaDgisDasasruli = new TimeSpan(16, 59, 59); 

   TimeSpan Sagamo = new TimeSpan(17, 0, 0);   
   TimeSpan SagamosDasasruli = new TimeSpan(20, 59, 59);   

   TimeSpan Game = new TimeSpan(21, 0, 0);     
   TimeSpan GamisDasasruli = new TimeSpan(4, 59, 59);      

        
        if (Dro >= Dila && Dro <= DilisDasasruli)
        {
            Console.WriteLine("Good Morning");
        }
        else if (Dro >= ShuaDge && Dro <= ShuaDgisDasasruli)
        {
            Console.WriteLine("Good Afternoon");
        }
        else if (Dro >= Sagamo && Dro <= SagamosDasasruli)
        {
            Console.WriteLine("Good Evening");
        }
        else if (Dro >= Game || Dro <= GamisDasasruli)
        {
            Console.WriteLine("Good Night");
        }
        else
        {
            Console.WriteLine("Araswori Dro.");
        }

        Console.ReadLine(); 
    

