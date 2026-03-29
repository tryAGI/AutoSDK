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
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation")]
        public string? Pronunciation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PronunciationDetailTypeJsonConverter))]
        public global::G.PronunciationDetailType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDetail" /> class.
        /// </summary>
        /// <param name="pronunciation"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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