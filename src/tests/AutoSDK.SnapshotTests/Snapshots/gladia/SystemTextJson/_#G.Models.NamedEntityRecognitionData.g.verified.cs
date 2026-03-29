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
        [global::System.Text.Json.Serialization.JsonPropertyName("utterance_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UtteranceId { get; set; }

        /// <summary>
        /// The transcribed utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UtteranceDTO Utterance { get; set; }

        /// <summary>
        /// The NER results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.NamedEntityRecognitionResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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