//HintName: G.Models.SendCallRequestPronunciationGuideItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendCallRequestPronunciationGuideItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word")]
        public string? Word { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation")]
        public string? Pronunciation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendCallRequestPronunciationGuideItem" /> class.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="pronunciation"></param>
        public SendCallRequestPronunciationGuideItem(
            string? word,
            string? pronunciation)
        {
            this.Word = word;
            this.Pronunciation = pronunciation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendCallRequestPronunciationGuideItem" /> class.
        /// </summary>
        public SendCallRequestPronunciationGuideItem()
        {
        }
    }
}