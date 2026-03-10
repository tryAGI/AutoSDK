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
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("utterances", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DubbingTranscriptUtterance> Utterances { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscript" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="utterances"></param>
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