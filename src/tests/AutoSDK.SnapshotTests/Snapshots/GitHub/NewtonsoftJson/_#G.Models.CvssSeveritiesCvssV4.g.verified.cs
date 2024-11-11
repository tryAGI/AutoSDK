//HintName: G.Models.CvssSeveritiesCvssV4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CvssSeveritiesCvssV4
    {
        /// <summary>
        /// The CVSS 4 vector string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_string", Required = global::Newtonsoft.Json.Required.Always)]
        public string? VectorString { get; set; } = default!;

        /// <summary>
        /// The CVSS 4 score.<br/>
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
        /// Initializes a new instance of the <see cref="CvssSeveritiesCvssV4" /> class.
        /// </summary>
        /// <param name="vectorString">
        /// The CVSS 4 vector string.
        /// </param>
        /// <param name="score">
        /// The CVSS 4 score.<br/>
        /// Included only in responses
        /// </param>
        public CvssSeveritiesCvssV4(
            string? vectorString,
            double? score)
        {
            this.VectorString = vectorString ?? throw new global::System.ArgumentNullException(nameof(vectorString));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CvssSeveritiesCvssV4" /> class.
        /// </summary>
        public CvssSeveritiesCvssV4()
        {
        }
    }
}