#if !NET6_0_OR_GREATER
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
internal sealed class InterpolatedStringHandlerAttribute : Attribute
{
}
#endif
