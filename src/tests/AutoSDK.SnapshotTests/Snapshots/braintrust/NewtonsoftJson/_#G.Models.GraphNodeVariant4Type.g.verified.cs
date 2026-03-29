//HintName: G.Models.GraphNodeVariant4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphNodeVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="literal")]
        Literal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphNodeVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphNodeVariant4Type value)
        {
            return value switch
            {
                GraphNodeVariant4Type.Literal => "literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphNodeVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "literal" => GraphNodeVariant4Type.Literal,
                _ => null,
            };
        }
    }
}