//HintName: G.Models.OrgMembershipState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.
    /// <br/>Example: active
    /// </summary>
    public abstract class OrgMembershipState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Active = "active";
        /// <summary>
        /// 
        /// </summary>
        public const string Pending = "pending";
    }
}