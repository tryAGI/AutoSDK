//HintName: G.Models.CommunityProfileFiles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommunityProfileFiles
    {
        /// <summary>
        /// Code of Conduct Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_of_conduct")]
        public global::G.NullableCodeOfConductSimple? CodeOfConduct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_of_conduct_file")]
        public global::G.NullableCommunityHealthFile? CodeOfConductFile { get; set; }

        /// <summary>
        /// License Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public global::G.NullableLicenseSimple? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributing")]
        public global::G.NullableCommunityHealthFile? Contributing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public global::G.NullableCommunityHealthFile? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_template")]
        public global::G.NullableCommunityHealthFile? IssueTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_template")]
        public global::G.NullableCommunityHealthFile? PullRequestTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityProfileFiles" /> class.
        /// </summary>
        /// <param name="codeOfConduct">
        /// Code of Conduct Simple
        /// </param>
        /// <param name="codeOfConductFile"></param>
        /// <param name="license">
        /// License Simple
        /// </param>
        /// <param name="contributing"></param>
        /// <param name="readme"></param>
        /// <param name="issueTemplate"></param>
        /// <param name="pullRequestTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommunityProfileFiles(
            global::G.NullableCodeOfConductSimple? codeOfConduct,
            global::G.NullableCommunityHealthFile? codeOfConductFile,
            global::G.NullableLicenseSimple? license,
            global::G.NullableCommunityHealthFile? contributing,
            global::G.NullableCommunityHealthFile? readme,
            global::G.NullableCommunityHealthFile? issueTemplate,
            global::G.NullableCommunityHealthFile? pullRequestTemplate)
        {
            this.CodeOfConduct = codeOfConduct;
            this.CodeOfConductFile = codeOfConductFile;
            this.License = license;
            this.Contributing = contributing;
            this.Readme = readme;
            this.IssueTemplate = issueTemplate;
            this.PullRequestTemplate = pullRequestTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityProfileFiles" /> class.
        /// </summary>
        public CommunityProfileFiles()
        {
        }
    }
}