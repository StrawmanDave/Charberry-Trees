# Charberry-Trees
This is for the challenge Charberry Trees in the book C# Players Guide Fifth Editon.

CharberryTree tree = new CharberryTree();

while(true)
    tree.MaybeGrow();

public class CharberryTree
{
    private Random _random = new Random();
    public bool Ripe {get; set;}

    public void MayGrow()
    {
        // Only a tiny chance of ripening each time, but we try a lot!
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
        }
    }
}

Objectives:
Make a new project that includes the above code.    
Add a Ripened event to the CharberryTree class that is raised when the tree ripens.
Make a Notifier class that knows about the tree (Hint: perhpas pass it in as a constructor parameter)
and subsribes to its Ripened event. Attach a handler that displays something like "A charberry fruit has ripened!" to the console window.
Make a Harvester class that knows abou the tre (Hint: like the notifier, this could be passed as a constuctor parameter)
and subsribes to its Ripened event. Attach a handler that sets the tree's Ripe property back to false.
Update your main method to create a tree, notifer, and harvester, and get them to work together to grow, notify and harvest forever.