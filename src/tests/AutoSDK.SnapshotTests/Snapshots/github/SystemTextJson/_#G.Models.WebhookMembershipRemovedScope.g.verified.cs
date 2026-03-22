//HintName: G.Models.WebhookMembershipRemovedScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The scope of the membership. Currently, can only be `team`.
    /// </summary>
    public enum WebhookMembershipRemovedScope
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMembershipRemovedScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMembershipRemovedScope value)
        {
            return value switch
            {
                WebhookMembershipRemovedScope.Organization => "organization",
                WebhookMembershipRemovedScope.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMembershipRemovedScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => WebhookMembershipRemovedScope.Organization,
                "team" => WebhookMembershipRemovedScope.Team,
                _ => null,
            };
        }
    }
}