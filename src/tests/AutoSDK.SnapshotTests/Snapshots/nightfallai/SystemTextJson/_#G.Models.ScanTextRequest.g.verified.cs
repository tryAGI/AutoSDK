//HintName: G.Models.ScanTextRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScanTextRequest
    {
        /// <summary>
        /// List of text strings to scan. Maximum 50,000 items, 500KB total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Payload { get; set; }

        /// <summary>
        /// Inline scan policy with detection rules and alert settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        public global::G.ScanPolicy? Policy { get; set; }

        /// <summary>
        /// UUIDs of pre-configured policies from the Nightfall Dashboard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policyUUIDs")]
        public global::System.Collections.Generic.IList<string>? PolicyUUIDs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanTextRequest" /> class.
        /// </summary>
        /// <param name="payload">
        /// List of text strings to scan. Maximum 50,000 items, 500KB total.
        /// </param>
        /// <param name="policy">
        /// Inline scan policy with detection rules and alert settings
        /// </param>
        /// <param name="policyUUIDs">
        /// UUIDs of pre-configured policies from the Nightfall Dashboard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScanTextRequest(
            global::System.Collections.Generic.IList<string> payload,
            global::G.ScanPolicy? policy,
            global::System.Collections.Generic.IList<string>? policyUUIDs)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Policy = policy;
            this.PolicyUUIDs = policyUUIDs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanTextRequest" /> class.
        /// </summary>
        public ScanTextRequest()
        {
        }
    }
}