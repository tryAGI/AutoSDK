//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        ThinkingTurns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0Type.ThinkingTurns => "thinking_turns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "thinking_turns" => MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0Type.ThinkingTurns,
                _ => null,
            };
        }
    }
}