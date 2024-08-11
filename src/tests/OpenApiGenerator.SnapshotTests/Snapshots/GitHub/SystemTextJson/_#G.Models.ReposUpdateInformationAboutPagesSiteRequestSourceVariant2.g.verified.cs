//HintName: G.Models.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update the source for the repository. Must include the branch name and path.
    /// </summary>
    public sealed partial class ReposUpdateInformationAboutPagesSiteRequestSourceVariant2
    {
        /// <summary>
        /// The repository branch used to publish your site's source files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Branch { get; set; }

        /// <summary>
        /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2PathJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}