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
        /// <br/>Example: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HealthPercentage { get; set; }

        /// <summary>
        /// <br/>Example: My first repository on GitHub!
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// <br/>Example: example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Documentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CommunityProfileFiles Files { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_reports_enabled")]
        public bool ContentReportsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}