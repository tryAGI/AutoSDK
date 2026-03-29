//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf2TriggerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestContextManagementEditsItemsOneOf2TriggerType
    {
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf2TriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf2TriggerType value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf2TriggerType.InputTokens => "input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf2TriggerType? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => MessagesRequestContextManagementEditsItemsOneOf2TriggerType.InputTokens,
                _ => null,
            };
        }
    }
}