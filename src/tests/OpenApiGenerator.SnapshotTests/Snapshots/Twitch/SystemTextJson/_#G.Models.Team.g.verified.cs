//HintName: G.Models.Team.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Team
    {
        /// <summary>
        /// The list of team members.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TeamUser> Users { get; set; }

        /// <summary>
        /// A URL to the team’s background image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackgroundImageUrl { get; set; }

        /// <summary>
        /// A URL to the team’s banner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Banner { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the team was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of the last time the team was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The team’s description. The description may contain formatting such as Markdown, HTML, newline (\\n) characters, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Info { get; set; }

        /// <summary>
        /// A URL to a thumbnail image of the team’s logo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThumbnailUrl { get; set; }

        /// <summary>
        /// The team’s name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// The team’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamDisplayName { get; set; }

        /// <summary>
        /// An ID that identifies the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}