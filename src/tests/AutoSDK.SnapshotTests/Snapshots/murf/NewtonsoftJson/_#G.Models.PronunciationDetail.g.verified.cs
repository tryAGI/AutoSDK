//HintName: G.Models.PronunciationDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object used to define custom pronunciations. <br/>
    ///  Example 1: {"live":{"type": "IPA", "pronunciation": "laɪv"}}. <br/>
    ///  Example 2: {"2022":{"type": "SAY_AS", "pronunciation": "twenty twenty two"}}
    /// </summary>
    public sealed partial class PronunciationDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation")]
        public string? Pronunciation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PronunciationDetailTypeJsonConverter))]
        public global::G.PronunciationDetailType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDetail" /> class.
        /// </summary>
        /// <param name="pronunciation"></param>
        /// <param name="type"></param>
        public PronunciationDetail(
            string? pronunciation,
            global::G.PronunciationDetailType? type)
        {
            this.Pronunciation = pronunciation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDetail" /> class.
        /// </summary>
        public PronunciationDetail()
        {
        }
    }
}