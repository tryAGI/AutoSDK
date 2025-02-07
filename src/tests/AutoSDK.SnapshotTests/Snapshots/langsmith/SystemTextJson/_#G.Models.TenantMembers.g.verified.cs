//HintName: G.Models.TenantMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tenant members schema.
    /// </summary>
    public sealed partial class TenantMembers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MemberIdentity> Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PendingIdentity> Pending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantMembers" /> class.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="members"></param>
        /// <param name="pending"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantMembers(
            global::System.Guid tenantId,
            global::System.Collections.Generic.IList<global::G.MemberIdentity> members,
            global::System.Collections.Generic.IList<global::G.PendingIdentity> pending)
        {
            this.TenantId = tenantId;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.Pending = pending ?? throw new global::System.ArgumentNullException(nameof(pending));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantMembers" /> class.
        /// </summary>
        public TenantMembers()
        {
        }
    }
}