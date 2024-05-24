//HintName: G.Models.OrgMembershipRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The user's membership type in the organization.
    /// <br/>Example: admin
    /// </summary>
    public abstract class OrgMembershipRole
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Admin = "admin";
        /// <summary>
        /// 
        /// </summary>
        public const string Member = "member";
        /// <summary>
        /// 
        /// </summary>
        public const string BillingManager = "billing_manager";
    }
}