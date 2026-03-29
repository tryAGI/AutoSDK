//HintName: G.Models.PostedUserDefinedTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedUserDefinedTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public string Parameters { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PostedUserDefinedTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="fallbackContent"></param>
        public PostedUserDefinedTool(
            string name,
            string parameters,
            string? versionDescription,
            string? description,
            string? fallbackContent)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VersionDescription = versionDescription;
            this.Description = description;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.FallbackContent = fallbackContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUserDefinedTool" /> class.
        /// </summary>
        public PostedUserDefinedTool()
        {
        }
    }
}