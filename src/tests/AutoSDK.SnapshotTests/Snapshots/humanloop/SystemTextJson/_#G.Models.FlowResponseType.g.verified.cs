//HintName: G.Models.FlowResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlowResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Flow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlowResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlowResponseType value)
        {
            return value switch
            {
                FlowResponseType.Flow => "flow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlowResponseType? ToEnum(string value)
        {
            return value switch
            {
                "flow" => FlowResponseType.Flow,
                _ => null,
            };
        }
    }
}