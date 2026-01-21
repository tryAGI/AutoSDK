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
        [global::System.Text.Json.Serialization.JsonPropertyName("health_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HealthPercentage { get; set; }

        /// <summary>
        /// Example: My first repository on GitHub!
        /// </summary>
        /// <example>My first repository on GitHub!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Documentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CommunityProfileFiles Files { get; set; }

        /// <summary>
        /// Example: 2017-02-28T19:09:29Z
        /// </summary>
        /// <example>2017-02-28T19:09:29Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_reports_enabled")]
        public bool? ContentReportsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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