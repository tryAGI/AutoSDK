//HintName: G.Models.TranscriptionConfigAdditionalVocabItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionConfigAdditionalVocabItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sounds_like")]
        public global::System.Collections.Generic.IList<string>? SoundsLike { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigAdditionalVocabItem" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="soundsLike"></param>
        public TranscriptionConfigAdditionalVocabItem(
            string content,
            global::System.Collections.Generic.IList<string>? soundsLike)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.SoundsLike = soundsLike;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigAdditionalVocabItem" /> class.
        /// </summary>
        public TranscriptionConfigAdditionalVocabItem()
        {
        }
    }
}