//HintName: G.Models.ToolTemplateSetup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolTemplateSetup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("videoUrl")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docsUrl")]
        public string? DocsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTemplateSetup" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="videoUrl"></param>
        /// <param name="docsUrl"></param>
        public ToolTemplateSetup(
            string title,
            string? description,
            string? videoUrl,
            string? docsUrl)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.VideoUrl = videoUrl;
            this.DocsUrl = docsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTemplateSetup" /> class.
        /// </summary>
        public ToolTemplateSetup()
        {
        }
    }
}