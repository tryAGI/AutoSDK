//HintName: G.Models.App.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// App represents a app.
    /// </summary>
    public sealed partial class App
    {
        /// <summary>
        /// The app id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppId { get; set; }

        /// <summary>
        /// The app description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The creation time of the app.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// The last update time of the app.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The owner/namespace of the app.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerUid")]
        public string? OwnerUid { get; set; }

        /// <summary>
        /// The app tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The AI assistant app metadata.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAssistantApp")]
        public global::G.AIAssistantAppMetadata? AiAssistantApp { get; set; }

        /// <summary>
        /// The app type.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppTypeJsonConverter))]
        public global::G.AppType? AppType { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appUid")]
        public string? AppUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorUid")]
        public string? CreatorUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        /// <param name="appId">
        /// The app id.
        /// </param>
        /// <param name="description">
        /// The app description.
        /// </param>
        /// <param name="createTime">
        /// The creation time of the app.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// The last update time of the app.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="ownerUid">
        /// The owner/namespace of the app.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// The app tags.
        /// </param>
        /// <param name="aiAssistantApp">
        /// The AI assistant app metadata.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="appType">
        /// The app type.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="appUid">
        /// Included only in responses
        /// </param>
        /// <param name="creatorUid">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public App(
            string appId,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? ownerUid,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.AIAssistantAppMetadata? aiAssistantApp,
            global::G.AppType? appType,
            string? appUid,
            string? creatorUid)
        {
            this.AppId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.OwnerUid = ownerUid;
            this.Tags = tags;
            this.AiAssistantApp = aiAssistantApp;
            this.AppType = appType;
            this.AppUid = appUid;
            this.CreatorUid = creatorUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        public App()
        {
        }
    }
}