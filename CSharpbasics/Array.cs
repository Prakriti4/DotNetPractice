class Array{ 
     void Learn1DArray()
     { 
        int[] ages = new int[10];
        double[] ages1=new double[10];
        ages[0] = 34;
        ages[5] = 4;
        
        float[] numbers = new float[] {
            23.4f, 45.6f,12.34f
        };
     }

     void Learn1DArray2()
     { 
        int[,] agesMatrix = new int[10,15];
        agesMatrix[0,0]=4567;
        int[,,]agesMatrix3D = new int[13,1,23];
     }
     string[,] names= new string[,]{{"Bishnu","Raut"},{"Bishnu","Raut"},{"Bishnu","Raut"},{"Bishnu","Raut"}};

     void LearnJaggedArray(){ 
         byte[][] personAges = new byte[3][];
         personAges[0]=new byte[]{34,56};
         personAges[1]= new byte[]{34,56,23,45,67};
         personAges[2]=new byte[] {34,43,78};

     }
}
