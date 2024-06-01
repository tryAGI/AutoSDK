//HintName: G.Models.OrgsSetMembershipForUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsSetMembershipForUserRequest
    {
        /// <summary>
        /// The role to give the user in the organization. Can be one of:  
        ///  * `admin` - The user will become an owner of the organization.  
        ///  * `member` - The user will become a non-owner member of the organization.
        /// <br/>Default Value: member
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public OrgsSetMembershipForUserRequestRole? Role { get; set; } = OrgsSetMembershipForUserRequestRole.Member;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}