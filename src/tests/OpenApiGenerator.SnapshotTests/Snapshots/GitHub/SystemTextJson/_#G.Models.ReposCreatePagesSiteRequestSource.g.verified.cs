//HintName: G.Models.ReposCreatePagesSiteRequestSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source branch and directory used to publish your Pages site.
    /// </summary>
    public sealed partial class ReposCreatePagesSiteRequestSource
    {
        /// <summary>
        /// The repository branch used to publish your site's source files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Branch { get; set; }

        /// <summary>
        /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`. Default: `/`<br/>
        /// Default Value: /
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposCreatePagesSiteRequestSourcePathJsonConverter))]
        public global::G.ReposCreatePagesSiteRequestSourcePath? Path { get; set; } = global::G.ReposCreatePagesSiteRequestSourcePath.x;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}