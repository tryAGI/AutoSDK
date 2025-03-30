//HintName: G.Models.ConversationTokenPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationTokenPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="signed_url")]
        SignedUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shareable_link")]
        ShareableLink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationTokenPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationTokenPurpose value)
        {
            return value switch
            {
                ConversationTokenPurpose.SignedUrl => "signed_url",
                ConversationTokenPurpose.ShareableLink => "shareable_link",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationTokenPurpose? ToEnum(string value)
        {
            return value switch
            {
                "signed_url" => ConversationTokenPurpose.SignedUrl,
                "shareable_link" => ConversationTokenPurpose.ShareableLink,
                _ => null,
            };
        }
    }
}