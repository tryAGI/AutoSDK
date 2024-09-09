//HintName: G.Models.WebhookOrgBlockBlockedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookOrgBlockBlockedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blocked")]
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookOrgBlockBlockedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookOrgBlockBlockedAction value)
        {
            return value switch
            {
                WebhookOrgBlockBlockedAction.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookOrgBlockBlockedAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => WebhookOrgBlockBlockedAction.Blocked,
                _ => null,
            };
        }
    }
}