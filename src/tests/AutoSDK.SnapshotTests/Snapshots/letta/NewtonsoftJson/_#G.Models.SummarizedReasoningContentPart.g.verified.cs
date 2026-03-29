//HintName: G.Models.SummarizedReasoningContentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizedReasoningContentPart
    {
        /// <summary>
        /// The index of the summary part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The text of the summary part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizedReasoningContentPart" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the summary part.
        /// </param>
        /// <param name="text">
        /// The text of the summary part.
        /// </param>
        public SummarizedReasoningContentPart(
            int index,
            string text)
        {
            this.Index = index;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizedReasoningContentPart" /> class.
        /// </summary>
        public SummarizedReasoningContentPart()
        {
        }
    }
}