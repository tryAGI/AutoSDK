//HintName: G.Models.HumanMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: human
    /// </summary>
    public enum HumanMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Human,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HumanMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HumanMessageType value)
        {
            return value switch
            {
                HumanMessageType.Human => "human",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HumanMessageType? ToEnum(string value)
        {
            return value switch
            {
                "human" => HumanMessageType.Human,
                _ => null,
            };
        }
    }
}