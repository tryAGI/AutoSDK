//HintName: G.Models.BetaResponsePageLocationCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponsePageLocationCitation
    {
        /// <summary>
        /// Default Value: page_location
        /// </summary>
        /// <default>global::G.BetaResponsePageLocationCitationType.PageLocation</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaResponsePageLocationCitationType Type { get; set; } = global::G.BetaResponsePageLocationCitationType.PageLocation;

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
        [global::Newtonsoft.Json.JsonProperty("start_page_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartPageNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_page_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndPageNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponsePageLocationCitation" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="documentTitle"></param>
        /// <param name="type">
        /// Default Value: page_location
        /// </param>
        public BetaResponsePageLocationCitation(
            string citedText,
            int documentIndex,
            int startPageNumber,
            int endPageNumber,
            string? documentTitle,
            global::G.BetaResponsePageLocationCitationType type = global::G.BetaResponsePageLocationCitationType.PageLocation)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle;
            this.StartPageNumber = startPageNumber;
            this.EndPageNumber = endPageNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponsePageLocationCitation" /> class.
        /// </summary>
        public BetaResponsePageLocationCitation()
        {
        }
    }
}