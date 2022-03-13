class DataGeneric<T>
{
	private T Data { get; set; }



	public void PrintData()
	{
		Console.WriteLine("Data yang tersimpan adalah " + this.Data);
	}


}
