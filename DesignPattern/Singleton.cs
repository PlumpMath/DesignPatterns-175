using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
	/// <summary>
	/// シングルトンの実装
	/// </summary>
	class Singleton
	{
		// 唯一のインスタンス
		private static Singleton singleton = new Singleton();

		/// <summary>
		/// コンストラクタ
		/// </summary>
		private Singleton()
		{
			// 別に何もしない
		}

		/// <summary>
		/// 唯一のインスタンスを取得
		/// </summary>
		/// <returns></returns>
		public static Singleton GetInstance()
		{
			return singleton;
		}
	}
}
