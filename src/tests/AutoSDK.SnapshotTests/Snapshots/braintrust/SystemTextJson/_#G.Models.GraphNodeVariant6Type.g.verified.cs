//HintName: G.Models.GraphNodeVariant6Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GraphNodeVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphNodeVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphNodeVariant6Type value)
        {
            return value switch
            {
                GraphNodeVariant6Type.Gate => "gate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphNodeVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "gate" => GraphNodeVariant6Type.Gate,
                _ => null,
            };
        }
    }
}