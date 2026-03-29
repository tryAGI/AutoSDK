//HintName: G.Models.ChatSDKRequestConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatSDKRequestConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="app")]
        App,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bot")]
        Bot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatSDKRequestConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSDKRequestConfigType value)
        {
            return value switch
            {
                ChatSDKRequestConfigType.App => "app",
                ChatSDKRequestConfigType.Bot => "bot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSDKRequestConfigType? ToEnum(string value)
        {
            return value switch
            {
                "app" => ChatSDKRequestConfigType.App,
                "bot" => ChatSDKRequestConfigType.Bot,
                _ => null,
            };
        }
    }
}