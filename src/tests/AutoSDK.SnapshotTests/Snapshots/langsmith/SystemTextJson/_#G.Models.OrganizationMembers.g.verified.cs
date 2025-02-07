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
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OrgMemberIdentity> Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OrgPendingIdentity> Pending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMembers" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="members"></param>
        /// <param name="pending"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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