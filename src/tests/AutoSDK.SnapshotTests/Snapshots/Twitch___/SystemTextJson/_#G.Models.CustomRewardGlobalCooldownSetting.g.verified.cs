//HintName: G.Models.CustomRewardGlobalCooldownSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The settings used to determine whether to apply a cooldown period between redemptions and the length of the cooldown.
    /// </summary>
    public sealed partial class CustomRewardGlobalCooldownSetting
    {
        /// <summary>
        /// A Boolean value that determines whether to apply a cooldown period. Is **true** if a cooldown period is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// The cooldown period, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_cooldown_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long GlobalCooldownSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardGlobalCooldownSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// A Boolean value that determines whether to apply a cooldown period. Is **true** if a cooldown period is enabled.
        /// </param>
        /// <param name="globalCooldownSeconds">
        /// The cooldown period, in seconds.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomRewardGlobalCooldownSetting(
            bool isEnabled,
            long globalCooldownSeconds)
        {
            this.IsEnabled = isEnabled;
            this.GlobalCooldownSeconds = globalCooldownSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardGlobalCooldownSetting" /> class.
        /// </summary>
        public CustomRewardGlobalCooldownSetting()
        {
        }
    }
}