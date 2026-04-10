//HintName: G.Models.PostedBuiltinTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedBuiltinTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostedBuiltinToolNameJsonConverter))]
        public global::G.PostedBuiltinToolName? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback_content")]
        public string? FallbackContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedBuiltinTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fallbackContent"></param>
        public PostedBuiltinTool(
            global::G.PostedBuiltinToolName? name,
            string? fallbackContent)
        {
            this.Name = name;
            this.FallbackContent = fallbackContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedBuiltinTool" /> class.
        /// </summary>
        public PostedBuiltinTool()
        {
        }
    }
}