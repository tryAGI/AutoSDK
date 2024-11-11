//HintName: G.Models.SetTenantHandleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetTenantHandleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantHandle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTenantHandleRequest" /> class.
        /// </summary>
        /// <param name="tenantHandle"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SetTenantHandleRequest(
            string tenantHandle)
        {
            this.TenantHandle = tenantHandle ?? throw new global::System.ArgumentNullException(nameof(tenantHandle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTenantHandleRequest" /> class.
        /// </summary>
        public SetTenantHandleRequest()
        {
        }
    }
}