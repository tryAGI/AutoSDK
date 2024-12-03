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
        [global::Newtonsoft.Json.JsonProperty("branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string Branch { get; set; } = default!;

        /// <summary>
        /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`. Default: `/`<br/>
        /// Default Value: /
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public global::G.ReposCreatePagesSiteRequestSourcePath? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreatePagesSiteRequestSource" /> class.
        /// </summary>
        /// <param name="branch">
        /// The repository branch used to publish your site's source files.
        /// </param>
        /// <param name="path">
        /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`. Default: `/`<br/>
        /// Default Value: /
        /// </param>
        public ReposCreatePagesSiteRequestSource(
            string branch,
            global::G.ReposCreatePagesSiteRequestSourcePath? path)
        {
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreatePagesSiteRequestSource" /> class.
        /// </summary>
        public ReposCreatePagesSiteRequestSource()
        {
        }
    }
}