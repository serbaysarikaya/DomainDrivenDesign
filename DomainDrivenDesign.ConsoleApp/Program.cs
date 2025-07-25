using BenchmarkDotNet.Running;
using DomainDrivenDesign.ConsoleApp;

namespace ConsoleApp;


internal class Program
{
    static void Main(string[] args)
    {
        //Order order = new();
        //order.CreateOrder(1, "Domates");
        //order.CreateOrder(2, "Elma");
        //order.CreateOrder(3, "Armut");


        //DomainEventDispacther.Dispatch(order.DomainEvents);
        BenchmarkRunner.Run<BenchMarkService>();
        Console.ReadLine();
    }
}
public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; init; }
    public Entity(Guid id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is not Entity entity)
        {
            return false;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return entity.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public bool Equals(Entity? other)
    {
        if (other is null)
        {
            return false;
        }

        if (other is not Entity entity)
        {
            return false;
        }

        if (other.GetType() != GetType())
        {
            return false;
        }

        return entity.Id == Id;
    }
}


public class A : Entity
{
    public A(Guid id) : base(id)
    {
    }
}