//HintName: G.Models.CustomReward.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomReward
    {
        /// <summary>
        /// The ID that uniquely identifies the broadcaster.
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
        /// The ID that uniquely identifies this custom reward.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The title of the reward.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The prompt shown to the viewer when they redeem the reward if user input is required. See the `is_user_input_required` field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// The cost of the reward in Channel Points.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public long Cost { get; set; } = default!;

        /// <summary>
        /// A set of custom images for the reward. This field is **null** if the broadcaster didn’t upload images.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomRewardImage Image { get; set; } = default!;

        /// <summary>
        /// A set of default images for the reward.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomRewardDefaultImage DefaultImage { get; set; } = default!;

        /// <summary>
        /// The background color to use for the reward. The color is in Hex format (for example, #00E5CB).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_color", Required = global::Newtonsoft.Json.Required.Always)]
        public string BackgroundColor { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the reward is enabled. Is **true** if enabled; otherwise, **false**. Disabled rewards aren’t shown to the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsEnabled { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the user must enter information when they redeem the reward. Is **true** if the user is prompted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_user_input_required", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsUserInputRequired { get; set; } = default!;

        /// <summary>
        /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per live stream.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_per_stream_setting", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomRewardMaxPerStreamSetting MaxPerStreamSetting { get; set; } = default!;

        /// <summary>
        /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per user per live stream.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_per_user_per_stream_setting", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomRewardMaxPerUserPerStreamSetting MaxPerUserPerStreamSetting { get; set; } = default!;

        /// <summary>
        /// The settings used to determine whether to apply a cooldown period between redemptions and the length of the cooldown.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("global_cooldown_setting", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomRewardGlobalCooldownSetting GlobalCooldownSetting { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the reward is currently paused. Is **true** if the reward is paused. Viewers can’t redeem paused rewards.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_paused", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPaused { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the reward is currently in stock. Is **true** if the reward is in stock. Viewers can’t redeem out of stock rewards.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_in_stock", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsInStock { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("should_redemptions_skip_request_queue", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ShouldRedemptionsSkipRequestQueue { get; set; } = default!;

        /// <summary>
        /// The number of redemptions redeemed during the current live stream. The number counts against the `max_per_stream_setting` limit. This field is **null** if the broadcaster’s stream isn’t live or _max\_per\_stream\_setting_ isn’t enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redemptions_redeemed_current_stream", Required = global::Newtonsoft.Json.Required.Always)]
        public int? RedemptionsRedeemedCurrentStream { get; set; } = default!;

        /// <summary>
        /// The timestamp of when the cooldown period expires. Is **null** if the reward isn’t in a cooldown state. See the `global_cooldown_setting` field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cooldown_expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CooldownExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomReward" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID that uniquely identifies the broadcaster.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="id">
        /// The ID that uniquely identifies this custom reward.
        /// </param>
        /// <param name="title">
        /// The title of the reward.
        /// </param>
        /// <param name="prompt">
        /// The prompt shown to the viewer when they redeem the reward if user input is required. See the `is_user_input_required` field.
        /// </param>
        /// <param name="cost">
        /// The cost of the reward in Channel Points.
        /// </param>
        /// <param name="image">
        /// A set of custom images for the reward. This field is **null** if the broadcaster didn’t upload images.
        /// </param>
        /// <param name="defaultImage">
        /// A set of default images for the reward.
        /// </param>
        /// <param name="backgroundColor">
        /// The background color to use for the reward. The color is in Hex format (for example, #00E5CB).
        /// </param>
        /// <param name="isEnabled">
        /// A Boolean value that determines whether the reward is enabled. Is **true** if enabled; otherwise, **false**. Disabled rewards aren’t shown to the user.
        /// </param>
        /// <param name="isUserInputRequired">
        /// A Boolean value that determines whether the user must enter information when they redeem the reward. Is **true** if the user is prompted.
        /// </param>
        /// <param name="maxPerStreamSetting">
        /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per live stream.
        /// </param>
        /// <param name="maxPerUserPerStreamSetting">
        /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per user per live stream.
        /// </param>
        /// <param name="globalCooldownSetting">
        /// The settings used to determine whether to apply a cooldown period between redemptions and the length of the cooldown.
        /// </param>
        /// <param name="isPaused">
        /// A Boolean value that determines whether the reward is currently paused. Is **true** if the reward is paused. Viewers can’t redeem paused rewards.
        /// </param>
        /// <param name="isInStock">
        /// A Boolean value that determines whether the reward is currently in stock. Is **true** if the reward is in stock. Viewers can’t redeem out of stock rewards.
        /// </param>
        /// <param name="shouldRedemptionsSkipRequestQueue">
        /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process.
        /// </param>
        /// <param name="redemptionsRedeemedCurrentStream">
        /// The number of redemptions redeemed during the current live stream. The number counts against the `max_per_stream_setting` limit. This field is **null** if the broadcaster’s stream isn’t live or _max\_per\_stream\_setting_ isn’t enabled.
        /// </param>
        /// <param name="cooldownExpiresAt">
        /// The timestamp of when the cooldown period expires. Is **null** if the reward isn’t in a cooldown state. See the `global_cooldown_setting` field.
        /// </param>
        public CustomReward(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string id,
            string title,
            string prompt,
            long cost,
            global::G.CustomRewardImage image,
            global::G.CustomRewardDefaultImage defaultImage,
            string backgroundColor,
            bool isEnabled,
            bool isUserInputRequired,
            global::G.CustomRewardMaxPerStreamSetting maxPerStreamSetting,
            global::G.CustomRewardMaxPerUserPerStreamSetting maxPerUserPerStreamSetting,
            global::G.CustomRewardGlobalCooldownSetting globalCooldownSetting,
            bool isPaused,
            bool isInStock,
            bool shouldRedemptionsSkipRequestQueue,
            int? redemptionsRedeemedCurrentStream,
            global::System.DateTime? cooldownExpiresAt)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Cost = cost;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.DefaultImage = defaultImage ?? throw new global::System.ArgumentNullException(nameof(defaultImage));
            this.BackgroundColor = backgroundColor ?? throw new global::System.ArgumentNullException(nameof(backgroundColor));
            this.IsEnabled = isEnabled;
            this.IsUserInputRequired = isUserInputRequired;
            this.MaxPerStreamSetting = maxPerStreamSetting ?? throw new global::System.ArgumentNullException(nameof(maxPerStreamSetting));
            this.MaxPerUserPerStreamSetting = maxPerUserPerStreamSetting ?? throw new global::System.ArgumentNullException(nameof(maxPerUserPerStreamSetting));
            this.GlobalCooldownSetting = globalCooldownSetting ?? throw new global::System.ArgumentNullException(nameof(globalCooldownSetting));
            this.IsPaused = isPaused;
            this.IsInStock = isInStock;
            this.ShouldRedemptionsSkipRequestQueue = shouldRedemptionsSkipRequestQueue;
            this.RedemptionsRedeemedCurrentStream = redemptionsRedeemedCurrentStream;
            this.CooldownExpiresAt = cooldownExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomReward" /> class.
        /// </summary>
        public CustomReward()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CustomReward? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CustomReward>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CustomReward?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CustomReward?>(serializer.Deserialize<global::G.CustomReward>(jsonReader));
        }

    }
}