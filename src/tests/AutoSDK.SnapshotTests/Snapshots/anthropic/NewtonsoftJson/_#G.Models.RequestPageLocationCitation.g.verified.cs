//HintName: G.Models.RequestPageLocationCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestPageLocationCitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RequestPageLocationCitationType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="RequestPageLocationCitation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        public RequestPageLocationCitation(
            string citedText,
            int documentIndex,
            int startPageNumber,
            int endPageNumber,
            global::G.RequestPageLocationCitationType type,
            string? documentTitle)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.StartPageNumber = startPageNumber;
            this.EndPageNumber = endPageNumber;
            this.Type = type;
            this.DocumentTitle = documentTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPageLocationCitation" /> class.
        /// </summary>
        public RequestPageLocationCitation()
        {
        }
    }
}