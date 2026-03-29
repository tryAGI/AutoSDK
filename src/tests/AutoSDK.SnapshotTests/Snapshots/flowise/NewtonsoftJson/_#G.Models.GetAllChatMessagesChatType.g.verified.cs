//HintName: G.Models.GetAllChatMessagesChatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAllChatMessagesChatType
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
    public static class GetAllChatMessagesChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChatMessagesChatType value)
        {
            return value switch
            {
                GetAllChatMessagesChatType.External => "EXTERNAL",
                GetAllChatMessagesChatType.Internal => "INTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChatMessagesChatType? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => GetAllChatMessagesChatType.External,
                "INTERNAL" => GetAllChatMessagesChatType.Internal,
                _ => null,
            };
        }
    }
}