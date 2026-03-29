//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestContextManagementEditsItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clear_thinking_20251015")]
        ClearThinking20251015,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf1Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf1Type.ClearThinking20251015 => "clear_thinking_20251015",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "clear_thinking_20251015" => MessagesRequestContextManagementEditsItemsOneOf1Type.ClearThinking20251015,
                _ => null,
            };
        }
    }
}