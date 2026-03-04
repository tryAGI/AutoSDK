//HintName: G.Models.WebhookForkForkeeRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookForkForkeeRepositoryVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookForkForkeeRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookForkForkeeRepositoryVisibility value)
        {
            return value switch
            {
                WebhookForkForkeeRepositoryVisibility.Public => "public",
                WebhookForkForkeeRepositoryVisibility.Private => "private",
                WebhookForkForkeeRepositoryVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookForkForkeeRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookForkForkeeRepositoryVisibility.Public,
                "private" => WebhookForkForkeeRepositoryVisibility.Private,
                "internal" => WebhookForkForkeeRepositoryVisibility.Internal,
                _ => null,
            };
        }
    }
}