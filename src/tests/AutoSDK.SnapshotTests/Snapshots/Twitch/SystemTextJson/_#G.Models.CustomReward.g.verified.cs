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
        /// The ID that uniquely identifies this custom reward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The title of the reward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The prompt shown to the viewer when they redeem the reward if user input is required. See the `is_user_input_required` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The cost of the reward in Channel Points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Cost { get; set; }

        /// <summary>
        /// A set of custom images for the reward. This field is **null** if the broadcaster didn’t upload images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomRewardImage Image { get; set; }

        /// <summary>
        /// A set of default images for the reward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomRewardDefaultImage DefaultImage { get; set; }

        /// <summary>
        /// The background color to use for the reward. The color is in Hex format (for example, #00E5CB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackgroundColor { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the reward is enabled. Is **true** if enabled; otherwise, **false**. Disabled rewards aren’t shown to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the user must enter information when they redeem the reward. Is **true** if the user is prompted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_user_input_required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsUserInputRequired { get; set; }

        /// <summary>
        /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per live stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_per_stream_setting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomRewardMaxPerStreamSetting MaxPerStreamSetting { get; set; }

        /// <summary>
        /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per user per live stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_per_user_per_stream_setting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomRewardMaxPerUserPerStreamSetting MaxPerUserPerStreamSetting { get; set; }

        /// <summary>
        /// The settings used to determine whether to apply a cooldown period between redemptions and the length of the cooldown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_cooldown_setting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomRewardGlobalCooldownSetting GlobalCooldownSetting { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the reward is currently paused. Is **true** if the reward is paused. Viewers can’t redeem paused rewards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_paused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPaused { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the reward is currently in stock. Is **true** if the reward is in stock. Viewers can’t redeem out of stock rewards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_in_stock")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInStock { get; set; }

        /// <summary>
        /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_redemptions_skip_request_queue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ShouldRedemptionsSkipRequestQueue { get; set; }

        /// <summary>
        /// The number of redemptions redeemed during the current live stream. The number counts against the `max_per_stream_setting` limit. This field is **null** if the broadcaster’s stream isn’t live or _max\_per\_stream\_setting_ isn’t enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redemptions_redeemed_current_stream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? RedemptionsRedeemedCurrentStream { get; set; }

        /// <summary>
        /// The timestamp of when the cooldown period expires. Is **null** if the reward isn’t in a cooldown state. See the `global_cooldown_setting` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cooldown_expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CooldownExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.CustomReward? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CustomReward),
                jsonSerializerContext) as global::G.CustomReward;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CustomReward>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CustomReward?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CustomReward),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CustomReward;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CustomReward?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CustomReward?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}