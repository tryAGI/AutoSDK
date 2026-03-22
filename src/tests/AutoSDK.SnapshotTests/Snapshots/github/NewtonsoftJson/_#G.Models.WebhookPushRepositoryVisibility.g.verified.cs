//HintName: G.Models.WebhookPushRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPushRepositoryVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPushRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPushRepositoryVisibility value)
        {
            return value switch
            {
                WebhookPushRepositoryVisibility.Internal => "internal",
                WebhookPushRepositoryVisibility.Private => "private",
                WebhookPushRepositoryVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPushRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPushRepositoryVisibility.Internal,
                "private" => WebhookPushRepositoryVisibility.Private,
                "public" => WebhookPushRepositoryVisibility.Public,
                _ => null,
            };
        }
    }
}