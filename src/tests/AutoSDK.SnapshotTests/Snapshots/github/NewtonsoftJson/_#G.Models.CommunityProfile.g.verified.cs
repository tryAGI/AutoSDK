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
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::Newtonsoft.Json.JsonProperty("documentation", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Documentation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CommunityProfileFiles Files { get; set; } = default!;

        /// <summary>
        /// Example: 2017-02-28T19:09:29Z
        /// </summary>
        /// <example>2017-02-28T19:09:29Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? UpdatedAt { get; set; } = default!;

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
            string? description,
            string? documentation,
            global::G.CommunityProfileFiles files,
            global::System.DateTime? updatedAt,
            bool? contentReportsEnabled)
        {
            this.HealthPercentage = healthPercentage;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Documentation = documentation ?? throw new global::System.ArgumentNullException(nameof(documentation));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
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