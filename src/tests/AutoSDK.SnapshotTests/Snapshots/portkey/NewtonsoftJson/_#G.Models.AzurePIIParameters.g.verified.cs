//HintName: G.Models.AzurePIIParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzurePIIParameters
    {
        /// <summary>
        /// Domain to check against<br/>
        /// Default Value: none
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzurePIIParametersDomainJsonConverter))]
        public global::G.AzurePIIParametersDomain? Domain { get; set; }

        /// <summary>
        /// API version for the Content Safety API<br/>
        /// Default Value: 2024-11-01
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiVersion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Version of the PII detection model to use<br/>
        /// Default Value: latest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelVersion")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// Whether to redact detected PII<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redact")]
        public bool? Redact { get; set; }

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzurePIIParameters" /> class.
        /// </summary>
        /// <param name="domain">
        /// Domain to check against<br/>
        /// Default Value: none
        /// </param>
        /// <param name="apiVersion">
        /// API version for the Content Safety API<br/>
        /// Default Value: 2024-11-01
        /// </param>
        /// <param name="modelVersion">
        /// Version of the PII detection model to use<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="redact">
        /// Whether to redact detected PII<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
        public AzurePIIParameters(
            global::G.AzurePIIParametersDomain? domain,
            string? apiVersion,
            string? modelVersion,
            bool? redact,
            double? timeout)
        {
            this.Domain = domain;
            this.ApiVersion = apiVersion;
            this.ModelVersion = modelVersion;
            this.Redact = redact;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzurePIIParameters" /> class.
        /// </summary>
        public AzurePIIParameters()
        {
        }
    }
}