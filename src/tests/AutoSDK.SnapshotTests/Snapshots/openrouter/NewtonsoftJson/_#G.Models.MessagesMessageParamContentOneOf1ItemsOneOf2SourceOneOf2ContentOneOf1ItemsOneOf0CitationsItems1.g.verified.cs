//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf1TypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cited_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string CitedText { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_index", Required = global::Newtonsoft.Json.Required.Always)]
        public double DocumentIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_title")]
        public string? DocumentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_page_number", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartPageNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_page_number", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndPageNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems1" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="startPageNumber"></param>
        /// <param name="endPageNumber"></param>
        /// <param name="type"></param>
        /// <param name="documentTitle"></param>
        public MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems1(
            string citedText,
            double documentIndex,
            double startPageNumber,
            double endPageNumber,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf1Type type,
            string? documentTitle)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle;
            this.StartPageNumber = startPageNumber;
            this.EndPageNumber = endPageNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems1" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems1()
        {
        }
    }
}