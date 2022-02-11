using System;

namespace RectangleGenerator
{
	class Rectangle {
		// Attributes
		public double
			width,
			height,
			area,
			perimeter;

		// Constructors
		public Rectangle() {
			// Default Constructor
			width = 0;
			height = 0;
			area = 0.0;
			perimeter = 0.0;
		}

		public Rectangle(int min, int max) {
			// Specialized constructor
			var rand = new Random();

			width = rand.Next(min, max);
			height = rand.Next(min, max);
			Utility.calcArea(this);
			Utility.calcPerimeter(this);
		}

		// Method for display
		public override string ToString() {

			return '\n' +

				"Height: " + Convert.ToString(height) + '\n' +
				"Width: " + Convert.ToString(width) + '\n' +
				"Area: " + Convert.ToString(area) + '\n' +
				"Perimeter: " + Convert.ToString(perimeter) + '\n';
		}
	}

	class Utility {

		// Calculate area given width and height
		public static double calcArea(double w, double h)
			{ return w * h; }

		// Calculate area given a Rectangle object
		public static void calcArea(Rectangle r)
			{ r.area = r.width * r.height; }

		// Calculate perimeter given width and height
		public static double calcPerimeter(double w, double h)
			{ return (w * 2) + (h * 2); }

		// Calculate perimeter given a Rectangle object
		public static void calcPerimeter(Rectangle r)
			{ r.perimeter = (r.width * 2) + (r.height * 2); }

		// Generate Rectangle given min and max ranges, then using "out" parameters to pass width and height
		public static void makeRectangle(int min, int max, out double width, out double height) {

			Rectangle r = new Rectangle(min, max);

			width = r.width;
			height = r.height;
		}
	}

	class Run { // Run class
		public static void Main(string[] args) {

			Rectangle r = new Rectangle(); // Blank rectangle

			Utility.makeRectangle(10, 100, out r.width, out r.height);
			Utility.calcArea(r);
			Utility.calcPerimeter(r);

			Console.WriteLine(r);
		} 
	}
}
