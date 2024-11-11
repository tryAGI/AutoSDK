//HintName: G.Models.AutoHighlightResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoHighlightResult
    {
        /// <summary>
        /// The total number of times the key phrase appears in the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// The total relevancy to the overall audio file of this key phrase - a greater number means more relevant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rank", Required = global::Newtonsoft.Json.Required.Always)]
        public float Rank { get; set; } = default!;

        /// <summary>
        /// The text itself of the key phrase
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The timestamp of the of the key phrase
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Timestamp> Timestamps { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightResult" /> class.
        /// </summary>
        /// <param name="count">
        /// The total number of times the key phrase appears in the audio file
        /// </param>
        /// <param name="rank">
        /// The total relevancy to the overall audio file of this key phrase - a greater number means more relevant
        /// </param>
        /// <param name="text">
        /// The text itself of the key phrase
        /// </param>
        /// <param name="timestamps">
        /// The timestamp of the of the key phrase
        /// </param>
        public AutoHighlightResult(
            int count,
            float rank,
            string text,
            global::System.Collections.Generic.IList<global::G.Timestamp> timestamps)
        {
            this.Count = count;
            this.Rank = rank;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Timestamps = timestamps ?? throw new global::System.ArgumentNullException(nameof(timestamps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightResult" /> class.
        /// </summary>
        public AutoHighlightResult()
        {
        }
    }
}