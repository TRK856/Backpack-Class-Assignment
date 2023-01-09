public class Backpack
{
    public string color;
    public string size;
    public List<string> items = new List<string>();
    public bool open = false;

    public Backpack(string color, string size)
    {
        this.color = color;
        this.size = size;
        Console.WriteLine($"{size} {color} Backpack Created!");
    }

    public void OpenBag()
    {
        this.open = true;
        Console.WriteLine($"{this.size} {this.color} Bag Opened!");
    }

    public void CloseBag()
    {
        this.open = false;
        Console.WriteLine($"{this.size} {this.color} Bag Closed!");
    }

    public void PutIn(string item)
    {
        if (this.open)
        {
            this.items.Add(item);
            Console.WriteLine($"{this.size} {this.color} Bag has added a {item}!");
        }
    }

    public void TakeOut(string item)
    {
        if (this.open)
        {
            this.items.Remove(item);
            Console.WriteLine($"{this.size} {this.color} Bag has removed a {item}!");
        }
    }
}
