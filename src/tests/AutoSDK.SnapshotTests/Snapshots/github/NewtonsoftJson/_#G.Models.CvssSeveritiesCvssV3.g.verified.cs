//HintName: G.Models.CvssSeveritiesCvssV3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CvssSeveritiesCvssV3
    {
        /// <summary>
        /// The CVSS 3 vector string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_string", Required = global::Newtonsoft.Json.Required.Always)]
        public string? VectorString { get; set; } = default!;

        /// <summary>
        /// The CVSS 3 score.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CvssSeveritiesCvssV3" /> class.
        /// </summary>
        /// <param name="vectorString">
        /// The CVSS 3 vector string.
        /// </param>
        /// <param name="score">
        /// The CVSS 3 score.<br/>
        /// Included only in responses
        /// </param>
        public CvssSeveritiesCvssV3(
            string? vectorString,
            double? score)
        {
            this.VectorString = vectorString ?? throw new global::System.ArgumentNullException(nameof(vectorString));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CvssSeveritiesCvssV3" /> class.
        /// </summary>
        public CvssSeveritiesCvssV3()
        {
        }
    }
}