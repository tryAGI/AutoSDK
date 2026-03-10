//HintName: G.Models.DubbingTranscript.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingTranscript
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DubbingTranscriptUtterance> Utterances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscript" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="utterances"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingTranscript(
            string language,
            global::System.Collections.Generic.IList<global::G.DubbingTranscriptUtterance> utterances)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Utterances = utterances ?? throw new global::System.ArgumentNullException(nameof(utterances));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscript" /> class.
        /// </summary>
        public DubbingTranscript()
        {
        }
    }
}