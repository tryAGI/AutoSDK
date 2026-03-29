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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Flag to indicate if the transcript is final or not<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinal { get; set; }

        /// <summary>
        /// The transcribed utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UtteranceDTO Utterance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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