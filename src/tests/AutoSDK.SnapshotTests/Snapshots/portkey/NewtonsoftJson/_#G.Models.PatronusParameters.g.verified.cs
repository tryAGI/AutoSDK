//HintName: G.Models.PatronusParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatronusParameters
    {
        /// <summary>
        /// Whether to redact detected content<br/>
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
        /// Initializes a new instance of the <see cref="PatronusParameters" /> class.
        /// </summary>
        /// <param name="redact">
        /// Whether to redact detected content<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
        public PatronusParameters(
            bool? redact,
            double? timeout)
        {
            this.Redact = redact;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatronusParameters" /> class.
        /// </summary>
        public PatronusParameters()
        {
        }
    }
}