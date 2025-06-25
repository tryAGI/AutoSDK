//HintName: G.Models.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update the source for the repository. Must include the branch name and path.
    /// </summary>
    public sealed partial class ReposUpdateInformationAboutPagesSiteRequestSourceEnum2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReposUpdateInformationAboutPagesSiteRequestSourceEnumPathJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInformationAboutPagesSiteRequestSourceEnum2" /> class.
        /// </summary>
        /// <param name="branch">
        /// The repository branch used to publish your site's source files.
        /// </param>
        /// <param name="path">
        /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposUpdateInformationAboutPagesSiteRequestSourceEnum2(
            string branch,
            global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath path)
        {
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInformationAboutPagesSiteRequestSourceEnum2" /> class.
        /// </summary>
        public ReposUpdateInformationAboutPagesSiteRequestSourceEnum2()
        {
        }
    }
}