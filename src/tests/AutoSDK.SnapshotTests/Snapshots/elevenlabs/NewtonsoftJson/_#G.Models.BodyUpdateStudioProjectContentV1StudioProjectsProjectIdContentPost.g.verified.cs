//HintName: G.Models.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost
    {
        /// <summary>
        /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_url")]
        public string? FromUrl { get; set; }

        /// <summary>
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_document")]
        public byte[]? FromDocument { get; set; }

        /// <summary>
        ///     An optional content to initialize the Studio project with. If this is set, 'from_url' and 'from_document' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.<br/>
        ///     Example:<br/>
        ///     [{"name": "Chapter A", "blocks": [{"sub_type": "p", "nodes": [{"voice_id": "6lCwbsX1yVjD49QmpkT0", "text": "A", "type": "tts_node"}, {"voice_id": "6lCwbsX1yVjD49QmpkT1", "text": "B", "type": "tts_node"}]}, {"sub_type": "h1", "nodes": [{"voice_id": "6lCwbsX1yVjD49QmpkT0", "text": "C", "type": "tts_node"}, {"voice_id": "6lCwbsX1yVjD49QmpkT1", "text": "D", "type": "tts_node"}]}]}, {"name": "Chapter B", "blocks": [{"sub_type": "p", "nodes": [{"voice_id": "6lCwbsX1yVjD49QmpkT0", "text": "E", "type": "tts_node"}, {"voice_id": "6lCwbsX1yVjD49QmpkT1", "text": "F", "type": "tts_node"}]}, {"sub_type": "h2", "nodes": [{"voice_id": "6lCwbsX1yVjD49QmpkT0", "text": "G", "type": "tts_node"}, {"voice_id": "6lCwbsX1yVjD49QmpkT1", "text": "H", "type": "tts_node"}]}]}]<br/>
        ///     
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_content_json")]
        public string? FromContentJson { get; set; }

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
        /// Initializes a new instance of the <see cref="BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost" /> class.
        /// </summary>
        /// <param name="fromUrl">
        /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.
        /// </param>
        /// <param name="fromDocument">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.
        /// </param>
        /// <param name="fromContentJson">
        ///     An optional content to initialize the Studio project with. If this is set, 'from_url' and 'from_document' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.<br/>
        ///     Example:<br/>
        ///     [{"name": "Chapter A", "blocks": [{"sub_type": "p", "nodes": [{"voice_id": "6lCwbsX1yVjD49QmpkT0", "text": "A", "type": "tts_node"}, {"voice_id": "6lCwbsX1yVjD49QmpkT1", "text": "B", "type": "tts_node"}]}, {"sub_type": "h1", "nodes": [{"voice_id": "6lCwbsX1yVjD49QmpkT0", "text": "C", "type": "tts_node"}, {"voice_id": "6lCwbsX1yVjD49QmpkT1", "text": "D", "type": "tts_node"}]}]}, {"name": "Chapter B", "blocks": [{"sub_type": "p", "nodes": [{"voice_id": "6lCwbsX1yVjD49QmpkT0", "text": "E", "type": "tts_node"}, {"voice_id": "6lCwbsX1yVjD49QmpkT1", "text": "F", "type": "tts_node"}]}, {"sub_type": "h2", "nodes": [{"voice_id": "6lCwbsX1yVjD49QmpkT0", "text": "G", "type": "tts_node"}, {"voice_id": "6lCwbsX1yVjD49QmpkT1", "text": "H", "type": "tts_node"}]}]}]<br/>
        ///     
        /// </param>
        /// <param name="autoConvert">
        /// Whether to auto convert the Studio project to audio or not.<br/>
        /// Default Value: false
        /// </param>
        public BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost(
            string? fromUrl,
            byte[]? fromDocument,
            string? fromContentJson,
            bool? autoConvert)
        {
            this.FromUrl = fromUrl;
            this.FromDocument = fromDocument;
            this.FromContentJson = fromContentJson;
            this.AutoConvert = autoConvert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost" /> class.
        /// </summary>
        public BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost()
        {
        }
    }
}