//HintName: G.Models.CommunityProfile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Community Profile
    /// </summary>
    public sealed partial class CommunityProfile
    {
        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("health_percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public int HealthPercentage { get; set; } = default!;

        /// <summary>
        /// Example: My first repository on GitHub!
        /// </summary>
        /// <example>My first repository on GitHub!</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::Newtonsoft.Json.JsonProperty("documentation")]
        public string? Documentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CommunityProfileFiles Files { get; set; } = default!;

        /// <summary>
        /// Example: 2017-02-28T19:09:29Z
        /// </summary>
        /// <example>2017-02-28T19:09:29Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("content_reports_enabled")]
        public bool? ContentReportsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityProfile" /> class.
        /// </summary>
        /// <param name="healthPercentage">
        /// Example: 100
        /// </param>
        /// <param name="description">
        /// Example: My first repository on GitHub!
        /// </param>
        /// <param name="documentation">
        /// Example: example.com
        /// </param>
        /// <param name="files"></param>
        /// <param name="updatedAt">
        /// Example: 2017-02-28T19:09:29Z
        /// </param>
        /// <param name="contentReportsEnabled">
        /// Example: true
        /// </param>
        public CommunityProfile(
            int healthPercentage,
            global::G.CommunityProfileFiles files,
            string? description,
            string? documentation,
            global::System.DateTime? updatedAt,
            bool? contentReportsEnabled)
        {
            this.HealthPercentage = healthPercentage;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Description = description;
            this.Documentation = documentation;
            this.UpdatedAt = updatedAt;
            this.ContentReportsEnabled = contentReportsEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityProfile" /> class.
        /// </summary>
        public CommunityProfile()
        {
        }
    }
}