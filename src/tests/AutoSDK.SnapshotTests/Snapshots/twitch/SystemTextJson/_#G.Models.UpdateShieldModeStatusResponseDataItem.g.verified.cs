﻿//HintName: G.Models.UpdateShieldModeStatusResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateShieldModeStatusResponseDataItem
    {
        /// <summary>
        /// A Boolean value that determines whether Shield Mode is active. Is **true** if Shield Mode is active; otherwise, **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// An ID that identifies the moderator that last activated Shield Mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorId { get; set; }

        /// <summary>
        /// The moderator’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorLogin { get; set; }

        /// <summary>
        /// The moderator’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorName { get; set; }

        /// <summary>
        /// The UTC timestamp (in RFC3339 format) of when Shield Mode was last activated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_activated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastActivatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShieldModeStatusResponseDataItem" /> class.
        /// </summary>
        /// <param name="isActive">
        /// A Boolean value that determines whether Shield Mode is active. Is **true** if Shield Mode is active; otherwise, **false**.
        /// </param>
        /// <param name="moderatorId">
        /// An ID that identifies the moderator that last activated Shield Mode.
        /// </param>
        /// <param name="moderatorLogin">
        /// The moderator’s login name.
        /// </param>
        /// <param name="moderatorName">
        /// The moderator’s display name.
        /// </param>
        /// <param name="lastActivatedAt">
        /// The UTC timestamp (in RFC3339 format) of when Shield Mode was last activated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateShieldModeStatusResponseDataItem(
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
        /// Initializes a new instance of the <see cref="UpdateShieldModeStatusResponseDataItem" /> class.
        /// </summary>
        public UpdateShieldModeStatusResponseDataItem()
        {
        }
    }
}