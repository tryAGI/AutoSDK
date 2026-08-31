#if !NET6_0_OR_GREATER
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
internal sealed class InterpolatedStringHandlerAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Parameter)]
internal sealed class InterpolatedStringHandlerArgumentAttribute : Attribute
{
    public InterpolatedStringHandlerArgumentAttribute(params string[] arguments)
    {
        Arguments = arguments;
        Argument = arguments.Length > 0 ? arguments[0] : string.Empty;
    }

    public string Argument { get; }
    public string[] Arguments { get; }
}
#endif
