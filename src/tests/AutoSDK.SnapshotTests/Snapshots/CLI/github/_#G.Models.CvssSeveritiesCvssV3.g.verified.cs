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
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_string")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? VectorString { get; set; }

        /// <summary>
        /// The CVSS 3 score.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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