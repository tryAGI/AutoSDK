//HintName: G.Models.ProxycredentialsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payload for requesting temporary credentials.
    /// </summary>
    public sealed partial class ProxycredentialsRequest
    {
        /// <summary>
        /// Granted model name. Null/undefined to grant usage of all models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// TTL of the temporary credential. 10 minutes by default.<br/>
        /// Default Value: 600
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl_seconds")]
        public double? TtlSeconds { get; set; }

        /// <summary>
        /// If present, proxy will log requests to the given Braintrust project name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logging")]
        public global::G.ProxycredentialsRequestLogging? Logging { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxycredentialsRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Granted model name. Null/undefined to grant usage of all models.
        /// </param>
        /// <param name="ttlSeconds">
        /// TTL of the temporary credential. 10 minutes by default.<br/>
        /// Default Value: 600
        /// </param>
        /// <param name="logging">
        /// If present, proxy will log requests to the given Braintrust project name.
        /// </param>
        public ProxycredentialsRequest(
            string? model,
            double? ttlSeconds,
            global::G.ProxycredentialsRequestLogging? logging)
        {
            this.Model = model;
            this.TtlSeconds = ttlSeconds;
            this.Logging = logging;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxycredentialsRequest" /> class.
        /// </summary>
        public ProxycredentialsRequest()
        {
        }
    }
}