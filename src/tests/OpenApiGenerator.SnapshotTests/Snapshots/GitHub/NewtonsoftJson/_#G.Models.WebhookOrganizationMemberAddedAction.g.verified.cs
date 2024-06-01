//HintName: G.Models.WebhookOrganizationMemberAddedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookOrganizationMemberAddedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member_added")]
        MemberAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookOrganizationMemberAddedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookOrganizationMemberAddedAction value)
        {
            return value switch
            {
                WebhookOrganizationMemberAddedAction.MemberAdded => "member_added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookOrganizationMemberAddedAction ToEnum(string value)
        {
            return value switch
            {
                "member_added" => WebhookOrganizationMemberAddedAction.MemberAdded,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}