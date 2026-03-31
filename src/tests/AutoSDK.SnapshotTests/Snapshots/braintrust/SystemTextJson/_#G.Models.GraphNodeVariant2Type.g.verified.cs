//HintName: G.Models.GraphNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The input to the graph
    /// </summary>
    public enum GraphNodeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Input,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphNodeVariant2Type value)
        {
            return value switch
            {
                GraphNodeVariant2Type.Input => "input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "input" => GraphNodeVariant2Type.Input,
                _ => null,
            };
        }
    }
}