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
        [global::Newtonsoft.Json.JsonProperty("branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string Branch { get; set; } = default!;

        /// <summary>
        /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnumPath Path { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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