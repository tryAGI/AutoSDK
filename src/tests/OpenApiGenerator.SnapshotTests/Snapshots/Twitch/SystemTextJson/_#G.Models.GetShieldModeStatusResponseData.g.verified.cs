//HintName: G.Models.GetShieldModeStatusResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetShieldModeStatusResponseData
    {
        /// <summary>
        /// A Boolean value that determines whether Shield Mode is active. Is **true** if the broadcaster activated Shield Mode; otherwise, **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// An ID that identifies the moderator that last activated Shield Mode. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorId { get; set; }

        /// <summary>
        /// The moderator’s login name. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorLogin { get; set; }

        /// <summary>
        /// The moderator’s display name. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorName { get; set; }

        /// <summary>
        /// The UTC timestamp (in RFC3339 format) of when Shield Mode was last activated. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_activated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastActivatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}