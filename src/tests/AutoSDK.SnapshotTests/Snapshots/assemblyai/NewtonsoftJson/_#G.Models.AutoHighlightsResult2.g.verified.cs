//HintName: G.Models.AutoHighlightsResult2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of results for the Key Phrases model, if it is enabled.<br/>
    /// See [Key phrases](https://www.assemblyai.com/docs/models/key-phrases) for more information.
    /// </summary>
    public sealed partial class AutoHighlightsResult2
    {
        /// <summary>
        /// Either success, or unavailable in the rare case that the model failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AudioIntelligenceModelStatus Status { get; set; } = default!;

        /// <summary>
        /// A temporally-sequential array of Key Phrases
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AutoHighlightResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightsResult2" /> class.
        /// </summary>
        /// <param name="status">
        /// Either success, or unavailable in the rare case that the model failed
        /// </param>
        /// <param name="results">
        /// A temporally-sequential array of Key Phrases
        /// </param>
        public AutoHighlightsResult2(
            global::G.AudioIntelligenceModelStatus status,
            global::System.Collections.Generic.IList<global::G.AutoHighlightResult> results)
        {
            this.Status = status;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightsResult2" /> class.
        /// </summary>
        public AutoHighlightsResult2()
        {
        }
    }
}