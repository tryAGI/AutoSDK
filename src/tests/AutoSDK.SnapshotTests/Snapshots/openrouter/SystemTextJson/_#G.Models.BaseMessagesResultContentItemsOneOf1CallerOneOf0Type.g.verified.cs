//HintName: G.Models.BaseMessagesResultContentItemsOneOf1CallerOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf1CallerOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf1CallerOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf1CallerOneOf0Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf1CallerOneOf0Type.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf1CallerOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BaseMessagesResultContentItemsOneOf1CallerOneOf0Type.Direct,
                _ => null,
            };
        }
    }
}