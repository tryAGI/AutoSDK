//HintName: G.Models.WebhookMembershipAddedScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The scope of the membership. Currently, can only be `team`.
    /// </summary>
    public enum WebhookMembershipAddedScope
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMembershipAddedScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMembershipAddedScope value)
        {
            return value switch
            {
                WebhookMembershipAddedScope.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMembershipAddedScope ToEnum(string value)
        {
            return value switch
            {
                "team" => WebhookMembershipAddedScope.Team,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}