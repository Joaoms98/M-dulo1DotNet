programa {
	funcao inicio() {
		real notas[4][4] = 
        {
		    {5.9, 6.2, 4.5, 5.5},
		    {6.6, 7.1, 8.7, 5.8},
		    {6.8, 7.5, 8.8, 5.7},
		    {6.7, 7.8, 8.9, 5.8}
	    }	
		
	    para (inteiro l = 0; l < 4; l++)
	    {
		    para (inteiro c = 0; c < 4; c++) 
            {
                escreva (" | ", notas[l][c])
            }
	        escreva("|\n")
	    }
    }
}
