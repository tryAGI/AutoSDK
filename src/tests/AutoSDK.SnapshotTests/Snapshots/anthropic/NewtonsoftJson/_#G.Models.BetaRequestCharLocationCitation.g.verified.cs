//HintName: G.Models.BetaRequestCharLocationCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestCharLocationCitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaRequestCharLocationCitationType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cited_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string CitedText { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int DocumentIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_title")]
        public string? DocumentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_char_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartCharIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_char_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndCharIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestCharLocationCitation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="startCharIndex"></param>
        /// <param name="endCharIndex"></param>
        public BetaRequestCharLocationCitation(
            string citedText,
            int documentIndex,
            int startCharIndex,
            int endCharIndex,
            global::G.BetaRequestCharLocationCitationType type,
            string? documentTitle)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.StartCharIndex = startCharIndex;
            this.EndCharIndex = endCharIndex;
            this.Type = type;
            this.DocumentTitle = documentTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestCharLocationCitation" /> class.
        /// </summary>
        public BetaRequestCharLocationCitation()
        {
        }
    }
}