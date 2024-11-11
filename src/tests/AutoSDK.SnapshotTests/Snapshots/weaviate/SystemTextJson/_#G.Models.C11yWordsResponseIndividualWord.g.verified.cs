//HintName: G.Models.C11yWordsResponseIndividualWord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class C11yWordsResponseIndividualWord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("present")]
        public bool? Present { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        public global::G.C11yWordsResponseIndividualWordInfo? Info { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yWordsResponseIndividualWord" /> class.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="present"></param>
        /// <param name="info"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public C11yWordsResponseIndividualWord(
            string? word,
            bool? present,
            global::G.C11yWordsResponseIndividualWordInfo? info)
        {
            this.Word = word;
            this.Present = present;
            this.Info = info;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yWordsResponseIndividualWord" /> class.
        /// </summary>
        public C11yWordsResponseIndividualWord()
        {
        }
    }
}