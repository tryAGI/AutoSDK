//HintName: G.Models.MessagesRequestToolsItemsOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bash20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf1Type value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf1Type.Bash20250124 => "bash_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_20250124" => MessagesRequestToolsItemsOneOf1Type.Bash20250124,
                _ => null,
            };
        }
    }
}