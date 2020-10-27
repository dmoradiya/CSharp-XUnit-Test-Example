using System;
using Xunit;
using XUnit_Example;
using XUnit_Example.Shapes;

namespace XUnit_Example_Test
{
    public class Circle_Tests
    {
      
       
            [Theory]
            [InlineData(5, 20, 10)]
            [InlineData(100, 50, 25)]
            public void Diameter_Set(int initialRadius, int newDiameter, int expectedRadius)
            {
                // Arrange
                Circle myCircle = new Circle(Shape.ColourValue.Red, initialRadius);

                // Act
                myCircle.Diameter = newDiameter;

                // Assert
                Assert.Equal(expectedRadius, myCircle.Radius);


            }
    }
}
