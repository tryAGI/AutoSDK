//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf0Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf0Type.InputTokens => "input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf0Type.InputTokens,
                _ => null,
            };
        }
    }
}