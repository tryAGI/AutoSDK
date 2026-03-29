//HintName: G.Models.PillarScanParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PillarScanParameters
    {
        /// <summary>
        /// Scanners to use for content analysis
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scanners", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PillarScanParametersScanner> Scanners { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PillarScanParameters" /> class.
        /// </summary>
        /// <param name="scanners">
        /// Scanners to use for content analysis
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
        public PillarScanParameters(
            global::System.Collections.Generic.IList<global::G.PillarScanParametersScanner> scanners,
            double? timeout)
        {
            this.Scanners = scanners ?? throw new global::System.ArgumentNullException(nameof(scanners));
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PillarScanParameters" /> class.
        /// </summary>
        public PillarScanParameters()
        {
        }
    }
}