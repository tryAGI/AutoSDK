﻿//HintName: G.Models.SecretScanningUpdateAlertRequest.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SecretScanningAlertState State { get; set; } = default!;

        /// <summary>
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolution")]
        public global::G.SecretScanningAlertResolution? Resolution { get; set; }

        /// <summary>
        /// An optional comment when closing an alert. Cannot be updated or deleted. Must be `null` when changing `state` to `open`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolution_comment")]
        public string? ResolutionComment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateAlertRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </param>
        /// <param name="resolution">
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </param>
        /// <param name="resolutionComment">
        /// An optional comment when closing an alert. Cannot be updated or deleted. Must be `null` when changing `state` to `open`.
        /// </param>
        public SecretScanningUpdateAlertRequest(
            global::G.SecretScanningAlertState state,
            global::G.SecretScanningAlertResolution? resolution,
            string? resolutionComment)
        {
            this.State = state;
            this.Resolution = resolution;
            this.ResolutionComment = resolutionComment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateAlertRequest" /> class.
        /// </summary>
        public SecretScanningUpdateAlertRequest()
        {
        }
    }
}