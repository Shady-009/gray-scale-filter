namespace Recognizer
{
	public static class GrayscaleTask
	{
		/* 
		 * Переведите изображение в серую гамму.
		 * 
		 * original[x, y] - массив пикселей с координатами x, y. 
		 * Каждый канал R,G,B лежит в диапазоне от 0 до 255.
		 * 
		 * Получившийся массив должен иметь те же размеры, 
		 * grayscale[x, y] - яркость пикселя (x,y) в диапазоне от 0.0 до 1.0
		 *
		 * Используйте формулу:
		 * Яркость = (0.299*R + 0.587*G + 0.114*B) / 255
		 * 
		 * Почему формула именно такая — читайте в википедии 
		 * http://ru.wikipedia.org/wiki/Оттенки_серого
		 */
		const double Red = 0.299;
		const double Green = 0.587;
		const double Blue = 0.114;
		const double Shades = 255;
		
		public static double[,] ToGrayscale(Pixel[,] original)
		{			
			var grayScale = new double[original.GetLength(0), original.GetLength(1)]; 
			for (var x = 0; x < original.GetLength(0); x++)
            {
				for (var y=0; y < original.GetLength(1); y++)
                {
					grayScale[x,y] =(Red * original[x, y].R + Green * original[x, y].G + Blue * original[x, y].B) / Shades;
				}
            }
			return grayScale;
		}
	}
}
