//HintName: G.Models.SecretScanningUpdateAlertRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningUpdateAlertRequest
    {
        /// <summary>
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SecretScanningUpdateAlertRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SecretScanningUpdateAlertRequestState State { get; set; }

        /// <summary>
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SecretScanningUpdateAlertRequestResolutionJsonConverter))]
        public SecretScanningUpdateAlertRequestResolution? Resolution { get; set; }

        /// <summary>
        /// An optional comment when closing an alert. Cannot be updated or deleted. Must be `null` when changing `state` to `open`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_comment")]
        public string? ResolutionComment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}