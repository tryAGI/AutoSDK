﻿//HintName: G.Models.UpdateCustomRewardBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomRewardBody
    {
        /// <summary>
        /// The reward’s title. The title may contain a maximum of 45 characters and it must be unique amongst all of the broadcaster’s custom rewards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The prompt shown to the viewer when they redeem the reward. Specify a prompt if `is_user_input_required` is **true**. The prompt is limited to a maximum of 200 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The cost of the reward, in channel points. The minimum is 1 point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public long? Cost { get; set; }

        /// <summary>
        /// The background color to use for the reward. Specify the color using Hex format (for example, \\#00E5CB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether the reward is enabled. Set to **true** to enable the reward. Viewers see only enabled rewards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// A Boolean value that determines whether users must enter information to redeem the reward. Set to **true** if user input is required. See the `prompt` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_user_input_required")]
        public bool? IsUserInputRequired { get; set; }

        /// <summary>
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per live stream (see the `max_per_stream` field). Set to **true** to limit redemptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_max_per_stream_enabled")]
        public bool? IsMaxPerStreamEnabled { get; set; }

        /// <summary>
        /// The maximum number of redemptions allowed per live stream. Applied only if `is_max_per_stream_enabled` is **true**. The minimum value is 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_per_stream")]
        public long? MaxPerStream { get; set; }

        /// <summary>
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per user per stream (see `max_per_user_per_stream`). The minimum value is 1\. Set to **true** to limit redemptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_max_per_user_per_stream_enabled")]
        public bool? IsMaxPerUserPerStreamEnabled { get; set; }

        /// <summary>
        /// The maximum number of redemptions allowed per user per stream. Applied only if `is_max_per_user_per_stream_enabled` is **true**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_per_user_per_stream")]
        public long? MaxPerUserPerStream { get; set; }

        /// <summary>
        /// A Boolean value that determines whether to apply a cooldown period between redemptions. Set to **true** to apply a cooldown period. For the duration of the cooldown period, see `global_cooldown_seconds`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_global_cooldown_enabled")]
        public bool? IsGlobalCooldownEnabled { get; set; }

        /// <summary>
        /// The cooldown period, in seconds. Applied only if `is_global_cooldown_enabled` is **true**. The minimum value is 1; however, for it to be shown in the Twitch UX, the minimum value is 60.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_cooldown_seconds")]
        public long? GlobalCooldownSeconds { get; set; }

        /// <summary>
        /// A Boolean value that determines whether to pause the reward. Set to **true** to pause the reward. Viewers can’t redeem paused rewards..
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_paused")]
        public bool? IsPaused { get; set; }

        /// <summary>
        /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_redemptions_skip_request_queue")]
        public bool? ShouldRedemptionsSkipRequestQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomRewardBody" /> class.
        /// </summary>
        /// <param name="title">
        /// The reward’s title. The title may contain a maximum of 45 characters and it must be unique amongst all of the broadcaster’s custom rewards.
        /// </param>
        /// <param name="prompt">
        /// The prompt shown to the viewer when they redeem the reward. Specify a prompt if `is_user_input_required` is **true**. The prompt is limited to a maximum of 200 characters.
        /// </param>
        /// <param name="cost">
        /// The cost of the reward, in channel points. The minimum is 1 point.
        /// </param>
        /// <param name="backgroundColor">
        /// The background color to use for the reward. Specify the color using Hex format (for example, \\#00E5CB).
        /// </param>
        /// <param name="isEnabled">
        /// A Boolean value that indicates whether the reward is enabled. Set to **true** to enable the reward. Viewers see only enabled rewards.
        /// </param>
        /// <param name="isUserInputRequired">
        /// A Boolean value that determines whether users must enter information to redeem the reward. Set to **true** if user input is required. See the `prompt` field.
        /// </param>
        /// <param name="isMaxPerStreamEnabled">
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per live stream (see the `max_per_stream` field). Set to **true** to limit redemptions.
        /// </param>
        /// <param name="maxPerStream">
        /// The maximum number of redemptions allowed per live stream. Applied only if `is_max_per_stream_enabled` is **true**. The minimum value is 1.
        /// </param>
        /// <param name="isMaxPerUserPerStreamEnabled">
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per user per stream (see `max_per_user_per_stream`). The minimum value is 1\. Set to **true** to limit redemptions.
        /// </param>
        /// <param name="maxPerUserPerStream">
        /// The maximum number of redemptions allowed per user per stream. Applied only if `is_max_per_user_per_stream_enabled` is **true**.
        /// </param>
        /// <param name="isGlobalCooldownEnabled">
        /// A Boolean value that determines whether to apply a cooldown period between redemptions. Set to **true** to apply a cooldown period. For the duration of the cooldown period, see `global_cooldown_seconds`.
        /// </param>
        /// <param name="globalCooldownSeconds">
        /// The cooldown period, in seconds. Applied only if `is_global_cooldown_enabled` is **true**. The minimum value is 1; however, for it to be shown in the Twitch UX, the minimum value is 60.
        /// </param>
        /// <param name="isPaused">
        /// A Boolean value that determines whether to pause the reward. Set to **true** to pause the reward. Viewers can’t redeem paused rewards..
        /// </param>
        /// <param name="shouldRedemptionsSkipRequestQueue">
        /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomRewardBody(
            string? title,
            string? prompt,
            long? cost,
            string? backgroundColor,
            bool? isEnabled,
            bool? isUserInputRequired,
            bool? isMaxPerStreamEnabled,
            long? maxPerStream,
            bool? isMaxPerUserPerStreamEnabled,
            long? maxPerUserPerStream,
            bool? isGlobalCooldownEnabled,
            long? globalCooldownSeconds,
            bool? isPaused,
            bool? shouldRedemptionsSkipRequestQueue)
        {
            this.Title = title;
            this.Prompt = prompt;
            this.Cost = cost;
            this.BackgroundColor = backgroundColor;
            this.IsEnabled = isEnabled;
            this.IsUserInputRequired = isUserInputRequired;
            this.IsMaxPerStreamEnabled = isMaxPerStreamEnabled;
            this.MaxPerStream = maxPerStream;
            this.IsMaxPerUserPerStreamEnabled = isMaxPerUserPerStreamEnabled;
            this.MaxPerUserPerStream = maxPerUserPerStream;
            this.IsGlobalCooldownEnabled = isGlobalCooldownEnabled;
            this.GlobalCooldownSeconds = globalCooldownSeconds;
            this.IsPaused = isPaused;
            this.ShouldRedemptionsSkipRequestQueue = shouldRedemptionsSkipRequestQueue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomRewardBody" /> class.
        /// </summary>
        public UpdateCustomRewardBody()
        {
        }
    }
}