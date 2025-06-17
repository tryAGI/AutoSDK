//HintName: G.Models.BodyEditProjectContentV1ProjectsProjectIdContentPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditProjectContentV1ProjectsProjectIdContentPost
    {
        /// <summary>
        /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.<br/>
        /// Example: https://blog.elevenlabs.io/the_first_ai_that_can_laugh/
        /// </summary>
        /// <example>https://blog.elevenlabs.io/the_first_ai_that_can_laugh/</example>
        [global::Newtonsoft.Json.JsonProperty("from_url")]
        public string? FromUrl { get; set; }

        /// <summary>
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_document")]
        public byte[]? FromDocument { get; set; }

        /// <summary>
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_documentname")]
        public string? FromDocumentname { get; set; }

        /// <summary>
        /// Whether to auto convert the Studio project to audio or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_convert")]
        public bool? AutoConvert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditProjectContentV1ProjectsProjectIdContentPost" /> class.
        /// </summary>
        /// <param name="fromUrl">
        /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.<br/>
        /// Example: https://blog.elevenlabs.io/the_first_ai_that_can_laugh/
        /// </param>
        /// <param name="fromDocument">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.
        /// </param>
        /// <param name="fromDocumentname">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.
        /// </param>
        /// <param name="autoConvert">
        /// Whether to auto convert the Studio project to audio or not.<br/>
        /// Default Value: false
        /// </param>
        public BodyEditProjectContentV1ProjectsProjectIdContentPost(
            string? fromUrl,
            byte[]? fromDocument,
            string? fromDocumentname,
            bool? autoConvert)
        {
            this.FromUrl = fromUrl;
            this.FromDocument = fromDocument;
            this.FromDocumentname = fromDocumentname;
            this.AutoConvert = autoConvert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditProjectContentV1ProjectsProjectIdContentPost" /> class.
        /// </summary>
        public BodyEditProjectContentV1ProjectsProjectIdContentPost()
        {
        }
    }
}