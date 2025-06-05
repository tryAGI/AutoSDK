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
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// source code project link (empty to delete)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// paper/research link (empty to delete)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("paper_url")]
        public string? PaperUrl { get; set; }

        /// <summary>
        /// usage license link (empty to delete)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license_url")]
        public string? LicenseUrl { get; set; }

        /// <summary>
        /// markdown flavored model readme
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// dataurl or regular url to cover image (empty to delete)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cover_img_url")]
        public string? CoverImgUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reported_type")]
        public global::G.HFTasksE? ReportedType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="reportedType"></param>
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