public class Function : Symbol
{
    public string[] Parameters;
    public bool Custom;

    public Function(string name, string[] parameters, bool custom) : base(name)
    {
        Parameters = parameters;
        Custom = custom;
    }

    public static Function FromFunctionDeclarationNode(FunctionDeclarationNode node)
    {
        return new Function(node.Name, node.Parameters.ToArray(), true);
    }
}
