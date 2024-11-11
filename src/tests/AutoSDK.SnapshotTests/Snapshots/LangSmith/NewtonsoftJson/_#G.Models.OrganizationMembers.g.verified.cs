//HintName: G.Models.OrganizationMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organization members schema.
    /// </summary>
    public sealed partial class OrganizationMembers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OrgMemberIdentity> Members { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OrgPendingIdentity> Pending { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMembers" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="members"></param>
        /// <param name="pending"></param>
        public OrganizationMembers(
            global::System.Guid organizationId,
            global::System.Collections.Generic.IList<global::G.OrgMemberIdentity> members,
            global::System.Collections.Generic.IList<global::G.OrgPendingIdentity> pending)
        {
            this.OrganizationId = organizationId;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.Pending = pending ?? throw new global::System.ArgumentNullException(nameof(pending));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMembers" /> class.
        /// </summary>
        public OrganizationMembers()
        {
        }
    }
}