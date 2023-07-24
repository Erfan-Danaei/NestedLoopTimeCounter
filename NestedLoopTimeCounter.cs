using System.Diagnostics;

public static class GlobalMembers
{
	static Stopwatch timer = new Stopwatch();

	public static double f(double[] X, int array_size)
	{
		double sum = 0;
		for (int i = 0; i < array_size; i++)
		{
			sum += Math.Sin(X[i]);
		}
		return sum;
	}
		public static void printout(double y_max, double[] maxX, int size)
	{
        Console.WriteLine($"y_max = {y_max}");
		for (int i = 0; i < size; i++)
		{
            Console.WriteLine($"X{i+1}_max = {maxX[i]}");
		}
	}
	public static void Dim1(double step)
	{

		double[] X = new double[1]; 
		double[] maxX = new double[1]; 
		double y;
		double y_max = double.MinValue;
		timer.Start();
		for (X[0] = 0; X[0] < 10; X[0] += step)
		{
			y = Math.Sin(X[0]); 
			if (y > y_max)
			{
				y_max = y;
				maxX[0] = X[0];
			}
		}
		
		Console.WriteLine( timer.Elapsed.ToString());
		timer.Stop();
		printout(y_max,maxX,1);
	}
	
	public static void Dim2(double step)
	{
		
		double[] X = new double[2];
		double[] maxX = new double[2];
		double y;
		double y_max = double.MinValue;
		timer.Restart();
		for (X[0] = 0; X[0] < 10; X[0] += step)
		{
			for (X[1] = 0; X[1] < 10; X[1] += step)
			{
				y = f(X, 2);
				if (y > y_max)
				{
					y_max = y;
					for (int i = 0; i <= 1; i++)
					{
						maxX[i] = X[i];
					}
				}
			}
		}
		
		Console.WriteLine( timer.Elapsed.ToString());
		timer.Stop();
		printout(y_max, maxX, 2);
		
	}
	public static void Dim3(double step)
	{
		double[] X = new double[3];
		double[] maxX = new double[3];
		double y;
		double y_max = double.MinValue;
		timer.Restart();

		
		for (X[0] = 0; X[0] < 10; X[0] += step)
		{
			for (X[1] = 0; X[1] < 10; X[1] += step)
			{
				for (X[2] = 0; X[2] < 10; X[2] += step)
				{
					y = f(X, 3);
					if (y > y_max)
					{
						y_max = y;
						for (int i = 0; i <= 2; i++)
						{
							maxX[i] = X[i];
						}
					}
				}
			}
		}
		
		Console.WriteLine( timer.Elapsed.ToString());
		timer.Stop();
		printout(y_max, maxX, 3);
		
	}
	public static void Dim4(double step)
	{
		double[] X = new double[4];
		double[] maxX = new double[4];
		double y;
		double y_max = double.MinValue;
	timer.Restart();
		for (X[0] = 0; X[0] < 10; X[0] += step)
		{
			for (X[1] = 0; X[1] < 10; X[1] += step)
			{
				for (X[2] = 0; X[2] < 10; X[2] += step)
				{
					for (X[3] = 0; X[3] < 10; X[3] += step)
					{
						y = f(X, 4);
						if (y > y_max)
						{
							y_max = y;
							for (int i = 0; i <= 3; i++)
							{
								maxX[i] = X[i];
							}
						}
					}
				}
			}
		}
		
		Console.WriteLine( timer.Elapsed.ToString());
		timer.Stop();
		printout(y_max, maxX, 4);
		
	}
	public static void Dim5(double step)
	{
		double[] X = new double[5];
		double[] maxX = new double[5];
		double y;
		double y_max = double.MinValue;
		timer.Restart();
		for (X[0] = 0; X[0] < 10; X[0] += step)
		{
			for (X[1] = 0; X[1] < 10; X[1] += step)
			{
				for (X[2] = 0; X[2] < 10; X[2] += step)
				{
					for (X[3] = 0; X[3] < 10; X[3] += step)
					{
						for (X[4] = 0; X[4] < 10; X[4] += step)
						{
							y = f(X, 5);
							if (y > y_max)
							{
								y_max = y;
								for (int i = 0; i <= 4; i++)
								{
									maxX[i] = X[i];
								}
							}
						}
					}
				}
			}
		}
		
		Console.WriteLine(timer.Elapsed.ToString());
		timer.Stop();
		printout(y_max, maxX, 5);
		
	}
	static void Main(string[] args)
	{

		// you can use your time in states
		Dim1(0.1);
		Dim2(0.1);
		Dim3(0.1);
		Dim4(0.1);
		Dim5(0.1);

	}
}
