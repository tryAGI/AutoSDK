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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_content")]
        public string? FallbackContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUserDefinedTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="fallbackContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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