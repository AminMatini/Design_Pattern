using Application.BuilderPatternSample.BuilderInterfaces;
using Application.BuilderPatternSample.Product;

namespace Application.BuilderPatternSample.ConcreteBuilder;

public class SimpleRoomBuilder : IRoomBuilder
{
    public Room Build()
    {
        return new Room("Simple Room")
            .WithBed(1);
    }
}
