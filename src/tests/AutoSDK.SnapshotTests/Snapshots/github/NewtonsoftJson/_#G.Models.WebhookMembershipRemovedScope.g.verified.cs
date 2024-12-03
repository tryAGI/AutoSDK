//HintName: G.Models.WebhookMembershipRemovedScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The scope of the membership. Currently, can only be `team`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMembershipRemovedScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team")]
        Team,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
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
                WebhookMembershipRemovedScope.Team => "team",
                WebhookMembershipRemovedScope.Organization => "organization",
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
                "team" => WebhookMembershipRemovedScope.Team,
                "organization" => WebhookMembershipRemovedScope.Organization,
                _ => null,
            };
        }
    }
}