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
        [global::System.Text.Json.Serialization.JsonPropertyName("build_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReposCreatePagesSiteRequestBuildTypeJsonConverter))]
        public global::G.ReposCreatePagesSiteRequestBuildType? BuildType { get; set; }

        /// <summary>
        /// The source branch and directory used to publish your Pages site.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::G.ReposCreatePagesSiteRequestSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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