//HintName: G.Models.SecretScanningCreatePushProtectionBypassRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningCreatePushProtectionBypassRequest
    {
        /// <summary>
        /// The reason for bypassing push protection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SecretScanningPushProtectionBypassReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SecretScanningPushProtectionBypassReason Reason { get; set; }

        /// <summary>
        /// The ID of the push protection bypass placeholder. This value is returned on any push protected routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaceholderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCreatePushProtectionBypassRequest" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason for bypassing push protection.
        /// </param>
        /// <param name="placeholderId">
        /// The ID of the push protection bypass placeholder. This value is returned on any push protected routes.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SecretScanningCreatePushProtectionBypassRequest(
            global::G.SecretScanningPushProtectionBypassReason reason,
            string placeholderId)
        {
            this.Reason = reason;
            this.PlaceholderId = placeholderId ?? throw new global::System.ArgumentNullException(nameof(placeholderId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCreatePushProtectionBypassRequest" /> class.
        /// </summary>
        public SecretScanningCreatePushProtectionBypassRequest()
        {
        }
    }
}