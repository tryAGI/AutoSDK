//HintName: G.Models.ListHallucinationCorrectorsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of hallucination correctors.
    /// </summary>
    public sealed partial class ListHallucinationCorrectorsResponse
    {
        /// <summary>
        /// An array of hallucination correctors that match the request parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hallucination_correctors")]
        public global::System.Collections.Generic.IList<global::G.HallucinationCorrector>? HallucinationCorrectors { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListHallucinationCorrectorsResponse" /> class.
        /// </summary>
        /// <param name="hallucinationCorrectors">
        /// An array of hallucination correctors that match the request parameters.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
        public ListHallucinationCorrectorsResponse(
            global::System.Collections.Generic.IList<global::G.HallucinationCorrector>? hallucinationCorrectors,
            global::G.ListMetadata? metadata)
        {
            this.HallucinationCorrectors = hallucinationCorrectors;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListHallucinationCorrectorsResponse" /> class.
        /// </summary>
        public ListHallucinationCorrectorsResponse()
        {
        }
    }
}