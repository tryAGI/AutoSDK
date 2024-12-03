//HintName: G.Models.GetShieldModeStatusResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetShieldModeStatusResponseDataItem
    {
        /// <summary>
        /// A Boolean value that determines whether Shield Mode is active. Is **true** if the broadcaster activated Shield Mode; otherwise, **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsActive { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the moderator that last activated Shield Mode. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorId { get; set; } = default!;

        /// <summary>
        /// The moderator’s login name. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorLogin { get; set; } = default!;

        /// <summary>
        /// The moderator’s display name. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorName { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp (in RFC3339 format) of when Shield Mode was last activated. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_activated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastActivatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetShieldModeStatusResponseDataItem" /> class.
        /// </summary>
        /// <param name="isActive">
        /// A Boolean value that determines whether Shield Mode is active. Is **true** if the broadcaster activated Shield Mode; otherwise, **false**.
        /// </param>
        /// <param name="moderatorId">
        /// An ID that identifies the moderator that last activated Shield Mode. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </param>
        /// <param name="moderatorLogin">
        /// The moderator’s login name. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </param>
        /// <param name="moderatorName">
        /// The moderator’s display name. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </param>
        /// <param name="lastActivatedAt">
        /// The UTC timestamp (in RFC3339 format) of when Shield Mode was last activated. Is an empty string if Shield Mode hasn’t been previously activated.
        /// </param>
        public GetShieldModeStatusResponseDataItem(
            bool isActive,
            string moderatorId,
            string moderatorLogin,
            string moderatorName,
            global::System.DateTime lastActivatedAt)
        {
            this.IsActive = isActive;
            this.ModeratorId = moderatorId ?? throw new global::System.ArgumentNullException(nameof(moderatorId));
            this.ModeratorLogin = moderatorLogin ?? throw new global::System.ArgumentNullException(nameof(moderatorLogin));
            this.ModeratorName = moderatorName ?? throw new global::System.ArgumentNullException(nameof(moderatorName));
            this.LastActivatedAt = lastActivatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetShieldModeStatusResponseDataItem" /> class.
        /// </summary>
        public GetShieldModeStatusResponseDataItem()
        {
        }
    }
}