//HintName: G.Models.RemoveAllChatMessagesChatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RemoveAllChatMessagesChatType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EXTERNAL")]
        External,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INTERNAL")]
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveAllChatMessagesChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAllChatMessagesChatType value)
        {
            return value switch
            {
                RemoveAllChatMessagesChatType.External => "EXTERNAL",
                RemoveAllChatMessagesChatType.Internal => "INTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAllChatMessagesChatType? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => RemoveAllChatMessagesChatType.External,
                "INTERNAL" => RemoveAllChatMessagesChatType.Internal,
                _ => null,
            };
        }
    }
}