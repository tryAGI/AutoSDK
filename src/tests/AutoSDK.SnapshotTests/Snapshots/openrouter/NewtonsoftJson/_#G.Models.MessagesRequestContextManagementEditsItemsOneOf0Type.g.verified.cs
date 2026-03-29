//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestContextManagementEditsItemsOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clear_tool_uses_20250919")]
        ClearToolUses20250919,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf0Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf0Type.ClearToolUses20250919 => "clear_tool_uses_20250919",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "clear_tool_uses_20250919" => MessagesRequestContextManagementEditsItemsOneOf0Type.ClearToolUses20250919,
                _ => null,
            };
        }
    }
}