//HintName: G.Models.ModelMetaIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelMetaIn
    {
        /// <summary>
        /// short model description in plain text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// source code project link (empty to delete)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// paper/research link (empty to delete)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paper_url")]
        public string? PaperUrl { get; set; }

        /// <summary>
        /// usage license link (empty to delete)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_url")]
        public string? LicenseUrl { get; set; }

        /// <summary>
        /// markdown flavored model readme
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// dataurl or regular url to cover image (empty to delete)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_img_url")]
        public string? CoverImgUrl { get; set; }

        /// <summary>
        /// model type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reported_type")]
        public global::G.HFTasksE? ReportedType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMetaIn" /> class.
        /// </summary>
        /// <param name="description">
        /// short model description in plain text
        /// </param>
        /// <param name="githubUrl">
        /// source code project link (empty to delete)
        /// </param>
        /// <param name="paperUrl">
        /// paper/research link (empty to delete)
        /// </param>
        /// <param name="licenseUrl">
        /// usage license link (empty to delete)
        /// </param>
        /// <param name="readme">
        /// markdown flavored model readme
        /// </param>
        /// <param name="coverImgUrl">
        /// dataurl or regular url to cover image (empty to delete)
        /// </param>
        /// <param name="reportedType">
        /// model type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelMetaIn(
            string? description,
            string? githubUrl,
            string? paperUrl,
            string? licenseUrl,
            string? readme,
            string? coverImgUrl,
            global::G.HFTasksE? reportedType)
        {
            this.Description = description;
            this.GithubUrl = githubUrl;
            this.PaperUrl = paperUrl;
            this.LicenseUrl = licenseUrl;
            this.Readme = readme;
            this.CoverImgUrl = coverImgUrl;
            this.ReportedType = reportedType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMetaIn" /> class.
        /// </summary>
        public ModelMetaIn()
        {
        }
    }
}