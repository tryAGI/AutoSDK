//HintName: G.Models.ChapterizationSentence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterizationSentence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentence", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sentence { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WordDTO> Words { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterizationSentence" /> class.
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="words"></param>
        public ChapterizationSentence(
            string sentence,
            double start,
            double end,
            global::System.Collections.Generic.IList<global::G.WordDTO> words)
        {
            this.Sentence = sentence ?? throw new global::System.ArgumentNullException(nameof(sentence));
            this.Start = start;
            this.End = end;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterizationSentence" /> class.
        /// </summary>
        public ChapterizationSentence()
        {
        }
    }
}