//HintName: G.Models.UserSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserSubscription
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
        /// The ID of the user that gifted the subscription. The object includes this field only if `is_gift` is **true**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gifter_id")]
        public string? GifterId { get; set; }

        /// <summary>
        /// The gifter’s login name. The object includes this field only if `is_gift` is **true**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gifter_login")]
        public string? GifterLogin { get; set; }

        /// <summary>
        /// The gifter’s display name. The object includes this field only if `is_gift` is **true**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gifter_name")]
        public string? GifterName { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the subscription is a gift subscription. Is **true** if the subscription was gifted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_gift")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsGift { get; set; }

        /// <summary>
        /// The type of subscription. Possible values are:  <br/>
        ///   <br/>
        /// * 1000 — Tier 1<br/>
        /// * 2000 — Tier 2<br/>
        /// * 3000 — Tier 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UserSubscriptionTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UserSubscriptionTier Tier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
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
        /// <param name="gifterId">
        /// The ID of the user that gifted the subscription. The object includes this field only if `is_gift` is **true**.
        /// </param>
        /// <param name="gifterLogin">
        /// The gifter’s login name. The object includes this field only if `is_gift` is **true**.
        /// </param>
        /// <param name="gifterName">
        /// The gifter’s display name. The object includes this field only if `is_gift` is **true**.
        /// </param>
        /// <param name="isGift">
        /// A Boolean value that determines whether the subscription is a gift subscription. Is **true** if the subscription was gifted.
        /// </param>
        /// <param name="tier">
        /// The type of subscription. Possible values are:  <br/>
        ///   <br/>
        /// * 1000 — Tier 1<br/>
        /// * 2000 — Tier 2<br/>
        /// * 3000 — Tier 3
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UserSubscription(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            bool isGift,
            global::G.UserSubscriptionTier tier,
            string? gifterId,
            string? gifterLogin,
            string? gifterName)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.IsGift = isGift;
            this.Tier = tier;
            this.GifterId = gifterId;
            this.GifterLogin = gifterLogin;
            this.GifterName = gifterName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        public UserSubscription()
        {
        }


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
        public static global::G.UserSubscription? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.UserSubscription),
                jsonSerializerContext) as global::G.UserSubscription;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.UserSubscription? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserSubscription>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.UserSubscription?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.UserSubscription),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.UserSubscription;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.UserSubscription?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.UserSubscription?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}