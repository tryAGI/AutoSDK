//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf0KeepType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestContextManagementEditsItemsOneOf0KeepType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_uses")]
        ToolUses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf0KeepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf0KeepType value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf0KeepType.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf0KeepType? ToEnum(string value)
        {
            return value switch
            {
                "tool_uses" => MessagesRequestContextManagementEditsItemsOneOf0KeepType.ToolUses,
                _ => null,
            };
        }
    }
}