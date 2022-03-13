class DataGeneric<T>
{
	private T Data { get; set; }



	public void PrintData()
	{
		Console.WriteLine("Data yang tersimpan adalah " + this.Data);
	}


	static void Main()
	{
		DataGeneric<string> name = new DataGeneric<string>();
		name.Data = "1302204081";
		name.PrintData();

	}
}

