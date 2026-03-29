//HintName: G.Models.ChatRequestServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The service tier to use for processing this request.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatRequestServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flex")]
        Flex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="priority")]
        Priority,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scale")]
        Scale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestServiceTier value)
        {
            return value switch
            {
                ChatRequestServiceTier.Auto => "auto",
                ChatRequestServiceTier.Default => "default",
                ChatRequestServiceTier.Flex => "flex",
                ChatRequestServiceTier.Priority => "priority",
                ChatRequestServiceTier.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatRequestServiceTier.Auto,
                "default" => ChatRequestServiceTier.Default,
                "flex" => ChatRequestServiceTier.Flex,
                "priority" => ChatRequestServiceTier.Priority,
                "scale" => ChatRequestServiceTier.Scale,
                _ => null,
            };
        }
    }
}