//HintName: G.Models.ChannelTeam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelTeam
    {
        /// <summary>
        /// An ID that identifies the broadcaster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelTeam" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// An ID that identifies the broadcaster.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="backgroundImageUrl">
        /// A URL to the team’s background image.
        /// </param>
        /// <param name="banner">
        /// A URL to the team’s banner.
        /// </param>
        /// <param name="createdAt">
        /// The UTC date and time (in RFC3339 format) of when the team was created.
        /// </param>
        /// <param name="updatedAt">
        /// The UTC date and time (in RFC3339 format) of the last time the team was updated.
        /// </param>
        /// <param name="info">
        /// The team’s description. The description may contain formatting such as Markdown, HTML, newline (\\n) characters, etc.
        /// </param>
        /// <param name="thumbnailUrl">
        /// A URL to a thumbnail image of the team’s logo.
        /// </param>
        /// <param name="teamName">
        /// The team’s name.
        /// </param>
        /// <param name="teamDisplayName">
        /// The team’s display name.
        /// </param>
        /// <param name="id">
        /// An ID that identifies the team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelTeam(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string backgroundImageUrl,
            string banner,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string info,
            string thumbnailUrl,
            string teamName,
            string teamDisplayName,
            string id)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.BackgroundImageUrl = backgroundImageUrl ?? throw new global::System.ArgumentNullException(nameof(backgroundImageUrl));
            this.Banner = banner ?? throw new global::System.ArgumentNullException(nameof(banner));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Info = info ?? throw new global::System.ArgumentNullException(nameof(info));
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.TeamDisplayName = teamDisplayName ?? throw new global::System.ArgumentNullException(nameof(teamDisplayName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelTeam" /> class.
        /// </summary>
        public ChannelTeam()
        {
        }
    }
}