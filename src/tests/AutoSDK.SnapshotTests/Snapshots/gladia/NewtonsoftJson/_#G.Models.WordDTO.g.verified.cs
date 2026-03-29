//HintName: G.Models.WordDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordDTO
    {
        /// <summary>
        /// Spoken word
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word", Required = global::Newtonsoft.Json.Required.Always)]
        public string Word { get; set; } = default!;

        /// <summary>
        /// Start timestamps in seconds of the spoken word
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// End timestamps in seconds of the spoken word
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// Confidence on the transcribed word (1 = 100% confident)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordDTO" /> class.
        /// </summary>
        /// <param name="word">
        /// Spoken word
        /// </param>
        /// <param name="start">
        /// Start timestamps in seconds of the spoken word
        /// </param>
        /// <param name="end">
        /// End timestamps in seconds of the spoken word
        /// </param>
        /// <param name="confidence">
        /// Confidence on the transcribed word (1 = 100% confident)
        /// </param>
        public WordDTO(
            string word,
            double start,
            double end,
            double confidence)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordDTO" /> class.
        /// </summary>
        public WordDTO()
        {
        }
    }
}