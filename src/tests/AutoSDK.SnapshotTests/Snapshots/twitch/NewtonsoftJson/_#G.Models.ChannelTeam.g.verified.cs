﻿//HintName: G.Models.ChannelTeam.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// A URL to the team’s background image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BackgroundImageUrl { get; set; } = default!;

        /// <summary>
        /// A URL to the team’s banner.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("banner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Banner { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the team was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of the last time the team was updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The team’s description. The description may contain formatting such as Markdown, HTML, newline (\\n) characters, etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("info", Required = global::Newtonsoft.Json.Required.Always)]
        public string Info { get; set; } = default!;

        /// <summary>
        /// A URL to a thumbnail image of the team’s logo.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// The team’s name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamName { get; set; } = default!;

        /// <summary>
        /// The team’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamDisplayName { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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