//HintName: G.Models.GraphNodeVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output of the graph
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphNodeVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output")]
        Output,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphNodeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphNodeVariant3Type value)
        {
            return value switch
            {
                GraphNodeVariant3Type.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphNodeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "output" => GraphNodeVariant3Type.Output,
                _ => null,
            };
        }
    }
}