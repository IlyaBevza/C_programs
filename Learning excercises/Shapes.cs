using System;
namespace Shapes
{
abstract class Shape
{
	public string PetName{get;set;}
	public Shape(string name="No name"){
	PetName=name;}
	public abstract void Draw();
	
}

class Circle:Shape{
	public Circle(){}
	public Circle(string name):base(name){}
	public override void Draw(){
		Console.WriteLine("Drawing {0} the Circle",PetName);
	}
	
}
class Hexagon:Shape,IPointy{
	public  Hexagon(){}
	public Hexagon(string name):base(name){}

        public byte Points { get { return 6; } }

        public override void Draw()
	{
		Console.WriteLine("Drawing {0} the Hexagon",PetName);
	}
	
}
class Triangle:Shape,IPointy{
	public Triangle(){}
	public Triangle(string name):base(name){}
	public override void Draw()
	{
		Console.WriteLine("Drawing {0} the Triangle",this.PetName);
	}
	public byte Points{get{return 3;}}
}
 public class BitmapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        public void DrawInBoundingBox(int top, int left, int right, int bottom)
        {
            Console.WriteLine("Drawing in a box...");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside down");
        }
    }
class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw...");
        }

        public int GetNumberOfSides()
        {return 4;}

        public void Print()
        {
            Console.WriteLine("Print..");
        }
    }

    class Square : IShape
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("To draw..");
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("To draw with printer...");
        }

        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Print...");
        }
    }

    // ИНТЕРФЕЙСЫ

    public interface IPointy
    {
        byte Points { get; }
    }
    public interface IPrintable
    {
        void Print();
        void Draw();
    }
    public interface IDrawable
    {
        void Draw();
    }
    public interface IAdvancedDraw : IDrawable
    {
        void DrawInBoundingBox(int top, int left, int right, int bottom);
        void DrawUpsideDown();
    }
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }

}