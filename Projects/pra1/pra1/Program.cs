using System;
using System.IO;
using System.IO.Compression;

namespace pra1
{
	class MainClass
	{
		//public static string FindFile(string p, string name)
		//{
		//	string r = "Fail";
		//	var files = Directory.GetFiles(p);
		//	var directories = Directory.GetDirectories(p);
		//	foreach (var f in files) 
		//	{
		//		if (f==name)
		//		{
		//			r = f;
		//		}
		//	}
		//	foreach (var d in directories)
		//	{
		//		return FindFile(d, name);
		//	}
		//	return r;
		//}
		public static void Main(string[] args)
		{
			//var d = Directory.GetDirectories("/Users/Damira/Desktop/first");
			//foreach (var d1 in d)
			//{
			//	Console.WriteLine(FindFile(d1, "/Users/Damira/Desktop/first/second/third/findme.txt"));
			//}
			var stream = new MemoryStream();
			FileStream file = new FileStream(@"/Users/Damira/Desktop/first/new.xml.gz", FileMode.Create, FileAccess.Write);
			GZipStream gzipstream = new GZipStream(file, CompressionLevel.Fastest);
			using (stream)
			{
				using (file)
				{
					using (gzipstream)
					{
						stream.CopyTo(gzipstream);
					}
				}
			}
		}
	}
}
