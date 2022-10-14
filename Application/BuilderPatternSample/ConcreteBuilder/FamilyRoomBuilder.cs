using Application.BuilderPatternSample.BuilderInterfaces;
using Application.BuilderPatternSample.Product;

namespace Application.BuilderPatternSample.ConcreteBuilder;

public class FamilyRoomBuilder : IRoomBuilder
{
    public Room Build()
    {
        return new Room("Family Room")
            .WithBed(4)
            .WithWiFi()
            .WithBalcony();
    }
}
