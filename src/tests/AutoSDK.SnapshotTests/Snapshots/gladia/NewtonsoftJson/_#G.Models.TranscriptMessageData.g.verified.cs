//HintName: G.Models.TranscriptMessageData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptMessageData
    {
        /// <summary>
        /// Id of the utterance<br/>
        /// Example: 00-00000011
        /// </summary>
        /// <example>00-00000011</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Flag to indicate if the transcript is final or not<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_final", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsFinal { get; set; } = default!;

        /// <summary>
        /// The transcribed utterance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("utterance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UtteranceDTO Utterance { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMessageData" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the utterance<br/>
        /// Example: 00-00000011
        /// </param>
        /// <param name="isFinal">
        /// Flag to indicate if the transcript is final or not<br/>
        /// Example: true
        /// </param>
        /// <param name="utterance">
        /// The transcribed utterance
        /// </param>
        public TranscriptMessageData(
            string id,
            bool isFinal,
            global::G.UtteranceDTO utterance)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsFinal = isFinal;
            this.Utterance = utterance ?? throw new global::System.ArgumentNullException(nameof(utterance));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMessageData" /> class.
        /// </summary>
        public TranscriptMessageData()
        {
        }
    }
}