//HintName: G.Models.WebhooksTeam1ParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksTeam1ParentPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksTeam1ParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeam1ParentPrivacy value)
        {
            return value switch
            {
                WebhooksTeam1ParentPrivacy.Open => "open",
                WebhooksTeam1ParentPrivacy.Closed => "closed",
                WebhooksTeam1ParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeam1ParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksTeam1ParentPrivacy.Open,
                "closed" => WebhooksTeam1ParentPrivacy.Closed,
                "secret" => WebhooksTeam1ParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}