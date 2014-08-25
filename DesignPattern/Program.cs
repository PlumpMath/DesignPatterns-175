using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// シングルトン使用例
			UseSingleton();

			// 停止
			Console.ReadLine();
		}

		public static void UseSingleton()
		{
			Singleton singleton1 = Singleton.GetInstance();
			Singleton singleton2 = Singleton.GetInstance();
			Hoge dummy1 = new Hoge();
			Hoge dummy2 = new Hoge();

			if (singleton1 == singleton2)
			{
				// こちらに入る
			}
			else
			{
				// こちらには入らない
			}

			if (dummy1 == dummy2)
			{
				// こちらには入らない
			}
			else
			{
				// こちらに入る
			}
		}
	}
}
