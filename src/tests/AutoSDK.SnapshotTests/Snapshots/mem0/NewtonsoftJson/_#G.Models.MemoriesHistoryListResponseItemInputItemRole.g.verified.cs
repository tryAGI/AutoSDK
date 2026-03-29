//HintName: G.Models.MemoriesHistoryListResponseItemInputItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the speaker in the conversation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MemoriesHistoryListResponseItemInputItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemoriesHistoryListResponseItemInputItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoriesHistoryListResponseItemInputItemRole value)
        {
            return value switch
            {
                MemoriesHistoryListResponseItemInputItemRole.Assistant => "assistant",
                MemoriesHistoryListResponseItemInputItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoriesHistoryListResponseItemInputItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MemoriesHistoryListResponseItemInputItemRole.Assistant,
                "user" => MemoriesHistoryListResponseItemInputItemRole.User,
                _ => null,
            };
        }
    }
}