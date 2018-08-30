using System; 

public class Legolas { 

	public static void Main() { 

		int arrows = 3; 
		int enemies = 4; 
        int percent = 0;
        bool legolasLives;
        

        

		Console.WriteLine("Legolas faces 4 enemies"); 

		for(int numberOfArrows = 1; numberOfArrows <= 3; numberOfArrows++) { 
            
            
			arrows--; 
			enemies--; 

			Console.WriteLine("Legolas kills one enemy"); 
			Console.WriteLine("There are " + enemies + " enemies left"); 

            if(enemies == 0) { 
                legolasLives = true; 
            }else { 
                legolasLives = false; 
            }    
		} 

            if(legolasLives) {
                Console.WriteLine("Legolas lives!");
            }else {
                Console.WriteLine("Legolas dies!");
            }

		 

        if(enemies == 0) {
            //Do this
        }esle if(enemies == 1) {
            //Do this
        }else if(enemies == 2){
            //Do this
        }else {
            //Do this
        }

        switch(enemies) {
            case 0:
                Console.WriteLine("Legolas lives!")
                break;
            case 1:
                console.WriteLine("Legolas dies!")
        }
	} 
} 