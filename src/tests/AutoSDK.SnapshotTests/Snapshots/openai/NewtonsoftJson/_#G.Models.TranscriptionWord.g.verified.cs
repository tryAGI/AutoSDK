//HintName: G.Models.TranscriptionWord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionWord
    {
        /// <summary>
        /// End time of the word in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public float End { get; set; } = default!;

        /// <summary>
        /// Start time of the word in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public float Start { get; set; } = default!;

        /// <summary>
        /// The text content of the word.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word", Required = global::Newtonsoft.Json.Required.Always)]
        public string Word { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionWord" /> class.
        /// </summary>
        /// <param name="end">
        /// End time of the word in seconds.
        /// </param>
        /// <param name="start">
        /// Start time of the word in seconds.
        /// </param>
        /// <param name="word">
        /// The text content of the word.
        /// </param>
        public TranscriptionWord(
            float end,
            float start,
            string word)
        {
            this.End = end;
            this.Start = start;
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionWord" /> class.
        /// </summary>
        public TranscriptionWord()
        {
        }
    }
}