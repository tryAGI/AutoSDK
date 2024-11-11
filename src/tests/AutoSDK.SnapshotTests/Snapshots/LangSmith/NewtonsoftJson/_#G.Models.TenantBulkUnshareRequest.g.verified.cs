//HintName: G.Models.TenantBulkUnshareRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantBulkUnshareRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("share_tokens")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ShareTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantBulkUnshareRequest" /> class.
        /// </summary>
        /// <param name="shareTokens"></param>
        public TenantBulkUnshareRequest(
            global::System.Collections.Generic.IList<global::System.Guid>? shareTokens)
        {
            this.ShareTokens = shareTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantBulkUnshareRequest" /> class.
        /// </summary>
        public TenantBulkUnshareRequest()
        {
        }
    }
}