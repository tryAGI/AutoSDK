//HintName: G.Models.BaseMessagesResultContentItemsOneOf0CitationsItems0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf0CitationsItems0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf0TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf0Type Type { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("start_char_index", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartCharIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_char_index", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndCharIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf0CitationsItems0" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="startCharIndex"></param>
        /// <param name="endCharIndex"></param>
        /// <param name="type"></param>
        /// <param name="documentTitle"></param>
        /// <param name="fileId"></param>
        public BaseMessagesResultContentItemsOneOf0CitationsItems0(
            string citedText,
            double documentIndex,
            double startCharIndex,
            double endCharIndex,
            global::G.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf0Type type,
            string? documentTitle,
            string? fileId)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle;
            this.StartCharIndex = startCharIndex;
            this.EndCharIndex = endCharIndex;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf0CitationsItems0" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf0CitationsItems0()
        {
        }
    }
}