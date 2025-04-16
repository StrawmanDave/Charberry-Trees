using CharBerryTree;
CharberryTree tree = new CharberryTree();

Notifier announcer = new Notifier(tree);
Harvester harvester = new Harvester(tree);
while(true)
{
    tree.MaybeGrow();
}
