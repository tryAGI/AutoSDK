//HintName: G.Models.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType.ToolReference => "tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType? ToEnum(string value)
        {
            return value switch
            {
                "tool_reference" => BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType.ToolReference,
                _ => null,
            };
        }
    }
}