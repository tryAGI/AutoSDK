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
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MemberIdentity> Members { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PendingIdentity> Pending { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantMembers" /> class.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="members"></param>
        /// <param name="pending"></param>
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