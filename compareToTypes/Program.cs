using compareToTypes;

public class  Program
{
    public static int Main(string[] args)
    {
        var usuarioMemory = new UsuarioModel(1, "Marcelo", 21, 1.86);
        var listUsuarioMemory = new List<UsuarioModel>()
        {
            new UsuarioModel(1,"teste",21,1.98),
            new UsuarioModel(2,"teste2",22,1.98),
            new UsuarioModel(5,"teste4",21,1.98)
        };
        Console.WriteLine(listUsuarioMemory.GetType() == typeof(List<UsuarioModel>));
        Console.WriteLine(usuarioMemory.GetType() == typeof(UsuarioModel));
        Console.WriteLine(usuarioMemory.ToString());
        Console.WriteLine(usuarioMemory.GetType().ToString());
        return 1;
    }
}