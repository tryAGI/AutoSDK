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
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SecretScanningPushProtectionBypassReason Reason { get; set; } = default!;

        /// <summary>
        /// The ID of the push protection bypass placeholder. This value is returned on any push protected routes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("placeholder_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PlaceholderId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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