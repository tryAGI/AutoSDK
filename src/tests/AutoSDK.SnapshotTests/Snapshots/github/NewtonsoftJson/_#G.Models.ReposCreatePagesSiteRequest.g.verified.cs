//HintName: G.Models.ReposCreatePagesSiteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source branch and directory used to publish your Pages site.
    /// </summary>
    public sealed partial class ReposCreatePagesSiteRequest
    {
        /// <summary>
        /// The process in which the Page will be built. Possible values are `"legacy"` and `"workflow"`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("build_type")]
        public global::G.ReposCreatePagesSiteRequestBuildType? BuildType { get; set; }

        /// <summary>
        /// The source branch and directory used to publish your Pages site.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.ReposCreatePagesSiteRequestSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreatePagesSiteRequest" /> class.
        /// </summary>
        /// <param name="buildType">
        /// The process in which the Page will be built. Possible values are `"legacy"` and `"workflow"`.
        /// </param>
        /// <param name="source">
        /// The source branch and directory used to publish your Pages site.
        /// </param>
        public ReposCreatePagesSiteRequest(
            global::G.ReposCreatePagesSiteRequestBuildType? buildType,
            global::G.ReposCreatePagesSiteRequestSource? source)
        {
            this.BuildType = buildType;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreatePagesSiteRequest" /> class.
        /// </summary>
        public ReposCreatePagesSiteRequest()
        {
        }
    }
}