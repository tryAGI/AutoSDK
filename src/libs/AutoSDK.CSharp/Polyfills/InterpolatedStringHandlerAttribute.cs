#if !NET6_0_OR_GREATER
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
internal sealed class InterpolatedStringHandlerAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Parameter)]
internal sealed class InterpolatedStringHandlerArgumentAttribute : Attribute
{
    public InterpolatedStringHandlerArgumentAttribute(string argument)
    {
        Argument = argument;
        Arguments = [argument];
    }

    public string Argument { get; }
    public string[] Arguments { get; }
}
#endif
