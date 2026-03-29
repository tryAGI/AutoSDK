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
        /// The transcribed word.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word", Required = global::Newtonsoft.Json.Required.Always)]
        public string Word { get; set; } = default!;

        /// <summary>
        /// Start time of the word in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// End time of the word in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionWord" /> class.
        /// </summary>
        /// <param name="word">
        /// The transcribed word.
        /// </param>
        /// <param name="start">
        /// Start time of the word in seconds.
        /// </param>
        /// <param name="end">
        /// End time of the word in seconds.
        /// </param>
        public TranscriptionWord(
            string word,
            double start,
            double end)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionWord" /> class.
        /// </summary>
        public TranscriptionWord()
        {
        }
    }
}