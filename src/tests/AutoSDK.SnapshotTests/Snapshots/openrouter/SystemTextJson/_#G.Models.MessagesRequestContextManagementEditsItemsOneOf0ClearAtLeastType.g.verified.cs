//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastType
    {
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastType value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastType.InputTokens => "input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastType? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastType.InputTokens,
                _ => null,
            };
        }
    }
}