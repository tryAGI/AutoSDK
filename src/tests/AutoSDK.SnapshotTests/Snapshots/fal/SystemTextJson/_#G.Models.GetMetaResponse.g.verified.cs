//HintName: G.Models.GetMetaResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Platform metadata including webhook IP ranges for allowlisting<br/>
    /// Example: {"webhook_ip_ranges":["34.123.59.101/32","34.135.41.243/32","35.239.83.87/32","104.198.204.37/32","34.56.20.205/32","34.170.94.127/32","35.224.184.236/32","136.114.56.197/32","34.29.37.237/32","35.225.160.28/32","34.56.205.145/32","34.59.170.72/32","34.10.147.45/32","104.198.64.245/32","34.9.1.255/32"]}
    /// </summary>
    public sealed partial class GetMetaResponse
    {
        /// <summary>
        /// IP address ranges (CIDR notation) used by fal.ai webhooks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_ip_ranges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> WebhookIpRanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMetaResponse" /> class.
        /// </summary>
        /// <param name="webhookIpRanges">
        /// IP address ranges (CIDR notation) used by fal.ai webhooks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMetaResponse(
            global::System.Collections.Generic.IList<string> webhookIpRanges)
        {
            this.WebhookIpRanges = webhookIpRanges ?? throw new global::System.ArgumentNullException(nameof(webhookIpRanges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMetaResponse" /> class.
        /// </summary>
        public GetMetaResponse()
        {
        }
    }
}