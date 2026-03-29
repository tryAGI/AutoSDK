//HintName: G.Models.NamedEntityRecognitionData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NamedEntityRecognitionData
    {
        /// <summary>
        /// Id of the utterance used for this result<br/>
        /// Example: 00-00000011
        /// </summary>
        /// <example>00-00000011</example>
        [global::Newtonsoft.Json.JsonProperty("utterance_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UtteranceId { get; set; } = default!;

        /// <summary>
        /// The transcribed utterance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("utterance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UtteranceDTO Utterance { get; set; } = default!;

        /// <summary>
        /// The NER results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.NamedEntityRecognitionResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityRecognitionData" /> class.
        /// </summary>
        /// <param name="utteranceId">
        /// Id of the utterance used for this result<br/>
        /// Example: 00-00000011
        /// </param>
        /// <param name="utterance">
        /// The transcribed utterance
        /// </param>
        /// <param name="results">
        /// The NER results
        /// </param>
        public NamedEntityRecognitionData(
            string utteranceId,
            global::G.UtteranceDTO utterance,
            global::System.Collections.Generic.IList<global::G.NamedEntityRecognitionResult> results)
        {
            this.UtteranceId = utteranceId ?? throw new global::System.ArgumentNullException(nameof(utteranceId));
            this.Utterance = utterance ?? throw new global::System.ArgumentNullException(nameof(utterance));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityRecognitionData" /> class.
        /// </summary>
        public NamedEntityRecognitionData()
        {
        }
    }
}