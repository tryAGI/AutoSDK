namespace AutoSDK.Naming.Methods;

internal static class CSharpMethodNamingSeparators
{
    internal static readonly char[] MethodSeparators =
        ['\\', '-', '.', '_', '/', '}', '{', '<', '>', ' ', '(', ')'];

    internal static readonly char[] PathSeparators =
        ['/', '\\', '-', '.', '_', '/', '}', '{'];
}
