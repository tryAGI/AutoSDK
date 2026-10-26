using AutoSDK.Models;

namespace AutoSDK.TypeMapping;

/// <summary>Classifies the emitted CLR type independently of schema and extension-hook flags.</summary>
public static class CSharpRuntimeTypeClassifier
{
    /// <summary>
    /// Whether runtime JSON metadata needs value-type semantics. Unknown generated types retain
    /// their enum/union/record classification. This does not change public PrepareArguments hooks.
    /// </summary>
    public static bool IsRuntimeValueType(this TypeData type)
    {
        var name = string.IsNullOrEmpty(type.CSharpTypeWithoutNullability)
            ? type.CSharpTypeRaw?.TrimEnd('?') ?? string.Empty : type.CSharpTypeWithoutNullability;
        var argumentStart = name.IndexOf('<');
        if (argumentStart >= 0)
        {
            var genericName = name.Substring(0, argumentStart);
            if (genericName is "global::System.Collections.Generic.List" or "global::System.Collections.Generic.IList"
                or "global::System.Collections.Generic.IReadOnlyList" or "global::System.Collections.Generic.IEnumerable"
                or "global::System.Collections.Generic.Dictionary" or "global::System.Collections.Generic.IDictionary"
                or "global::System.Collections.Generic.IReadOnlyDictionary" or "global::System.Collections.Generic.ICollection"
                or "global::System.Collections.Generic.IReadOnlyCollection" or "global::System.Collections.Generic.HashSet"
                or "global::System.Collections.Generic.ISet")
            {
                return false;
            }
            if (genericName == "global::System.Nullable")
            {
                return true;
            }
        }
        return name switch
        {
            "bool" or "byte" or "sbyte" or "short" or "ushort" or "int" or "uint" or "long" or "ulong"
                or "float" or "double" or "decimal" or "char"
                or "global::System.Boolean" or "global::System.Byte" or "global::System.SByte"
                or "global::System.Int16" or "global::System.UInt16" or "global::System.Int32" or "global::System.UInt32"
                or "global::System.Int64" or "global::System.UInt64" or "global::System.Single" or "global::System.Double"
                or "global::System.Decimal" or "global::System.Char"
                or "global::System.DateTime" or "global::System.DateTimeOffset" or "global::System.Guid"
                or "global::System.DateOnly" or "global::System.TimeOnly" or "global::System.TimeSpan"
                or "global::System.Text.Json.JsonElement" => true,
            "string" or "object" or "global::System.String" or "global::System.Object" => false,
            _ when name.EndsWith("[]", StringComparison.Ordinal) || type.IsArray => false,
            _ => type.IsValueType,
        };
    }
}
