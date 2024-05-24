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
}