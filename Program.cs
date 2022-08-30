
namespace delegates.example;
public delegate bool NameChanger(string name);
public class Test {
    public string? name;
    private bool changeName(string name) {
        if(name == null) {
            return false;
        }
        this.name = name;
        return true;
    }

    public NameChanger getChanger() {
        NameChanger nameChanger = new NameChanger(changeName);
        return nameChanger;
    }
}

public class Program {
    public static void Main(string[] args) {
        Test t = new Test();
        NameChanger nameChanger = t.getChanger();
        Console.WriteLine(nameChanger("Ajay"));
        Console.WriteLine(t.name);
    }
}
