//HintName: G.Models.PostedUserDefinedToolVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedUserDefinedToolVersion
    {
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
        /// Initializes a new instance of the <see cref="PostedUserDefinedToolVersion" /> class.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="fallbackContent"></param>
        public PostedUserDefinedToolVersion(
            string parameters,
            string? versionDescription,
            string? description,
            string? fallbackContent)
        {
            this.VersionDescription = versionDescription;
            this.Description = description;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.FallbackContent = fallbackContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUserDefinedToolVersion" /> class.
        /// </summary>
        public PostedUserDefinedToolVersion()
        {
        }
    }
}