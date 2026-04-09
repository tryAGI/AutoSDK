//HintName: G.Models.ReturnUserDefinedTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnUserDefinedTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReturnUserDefinedToolToolTypeJsonConverter))]
        public global::G.ReturnUserDefinedToolToolType? ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_type")]
        public string? VersionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_on")]
        public long? CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_on")]
        public long? ModifiedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public string? Parameters { get; set; }

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
        /// Initializes a new instance of the <see cref="ReturnUserDefinedTool" /> class.
        /// </summary>
        /// <param name="toolType"></param>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="versionType"></param>
        /// <param name="versionDescription"></param>
        /// <param name="name"></param>
        /// <param name="createdOn"></param>
        /// <param name="modifiedOn"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="fallbackContent"></param>
        public ReturnUserDefinedTool(
            global::G.ReturnUserDefinedToolToolType? toolType,
            string? id,
            int? version,
            string? versionType,
            string? versionDescription,
            string? name,
            long? createdOn,
            long? modifiedOn,
            string? description,
            string? parameters,
            string? fallbackContent)
        {
            this.ToolType = toolType;
            this.Id = id;
            this.Version = version;
            this.VersionType = versionType;
            this.VersionDescription = versionDescription;
            this.Name = name;
            this.CreatedOn = createdOn;
            this.ModifiedOn = modifiedOn;
            this.Description = description;
            this.Parameters = parameters;
            this.FallbackContent = fallbackContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnUserDefinedTool" /> class.
        /// </summary>
        public ReturnUserDefinedTool()
        {
        }
    }
}