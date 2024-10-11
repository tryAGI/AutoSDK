//HintName: G.Models.InfoGetResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The LangSmith server info.
    /// </summary>
    public sealed partial class InfoGetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license_expiration_time")]
        public global::G.AnyOf<global::System.DateTime?, object>? LicenseExpirationTime { get; set; }

        /// <summary>
        /// Batch ingest config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_ingest_config")]
        public global::G.BatchIngestConfig? BatchIngestConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instance_flags")]
        public object? InstanceFlags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}