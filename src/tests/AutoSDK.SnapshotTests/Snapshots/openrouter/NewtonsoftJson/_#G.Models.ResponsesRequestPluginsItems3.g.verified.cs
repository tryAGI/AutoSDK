//HintName: G.Models.ResponsesRequestPluginsItems3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesRequestPluginsItems3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf3IdJsonConverter))]
        public global::G.ResponsesRequestPluginsItemsOneOf3Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the file-parser plugin for this request. Defaults to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Options for PDF parsing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pdf")]
        public global::G.PDFParserOptions? Pdf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItems3" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabled">
        /// Set to false to disable the file-parser plugin for this request. Defaults to true.
        /// </param>
        /// <param name="pdf">
        /// Options for PDF parsing.
        /// </param>
        public ResponsesRequestPluginsItems3(
            global::G.ResponsesRequestPluginsItemsOneOf3Id id,
            bool? enabled,
            global::G.PDFParserOptions? pdf)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.Pdf = pdf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItems3" /> class.
        /// </summary>
        public ResponsesRequestPluginsItems3()
        {
        }
    }
}