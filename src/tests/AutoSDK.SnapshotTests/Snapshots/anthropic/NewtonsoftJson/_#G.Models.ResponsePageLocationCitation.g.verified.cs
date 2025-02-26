//HintName: G.Models.ResponsePageLocationCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsePageLocationCitation
    {
        /// <summary>
        /// Default Value: page_location
        /// </summary>
        /// <default>global::G.ResponsePageLocationCitationType.PageLocation</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponsePageLocationCitationType Type { get; set; } = global::G.ResponsePageLocationCitationType.PageLocation;

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
        [global::Newtonsoft.Json.JsonProperty("document_title", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DocumentTitle { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ResponsePageLocationCitation" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: page_location
        /// </param>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        public ResponsePageLocationCitation(
            string citedText,
            int documentIndex,
            string? documentTitle,
            int startPageNumber,
            int endPageNumber,
            global::G.ResponsePageLocationCitationType type = global::G.ResponsePageLocationCitationType.PageLocation)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle ?? throw new global::System.ArgumentNullException(nameof(documentTitle));
            this.StartPageNumber = startPageNumber;
            this.EndPageNumber = endPageNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePageLocationCitation" /> class.
        /// </summary>
        public ResponsePageLocationCitation()
        {
        }
    }
}