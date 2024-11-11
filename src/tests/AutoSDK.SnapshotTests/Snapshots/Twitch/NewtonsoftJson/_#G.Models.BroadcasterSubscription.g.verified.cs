//HintName: G.Models.BroadcasterSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BroadcasterSubscription
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
        /// The ID of the user that gifted the subscription to the user. Is an empty string if `is_gift` is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gifter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GifterId { get; set; } = default!;

        /// <summary>
        /// The gifter’s login name. Is an empty string if `is_gift` is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gifter_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string GifterLogin { get; set; } = default!;

        /// <summary>
        /// The gifter’s display name. Is an empty string if `is_gift` is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gifter_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string GifterName { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the subscription is a gift subscription. Is **true** if the subscription was gifted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_gift", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsGift { get; set; } = default!;

        /// <summary>
        /// The name of the subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PlanName { get; set; } = default!;

        /// <summary>
        /// The type of subscription. Possible values are:  <br/>
        ///   <br/>
        /// * 1000 — Tier 1<br/>
        /// * 2000 — Tier 2<br/>
        /// * 3000 — Tier 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BroadcasterSubscriptionTier Tier { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the subscribing user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcasterSubscription" /> class.
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
        /// The ID of the user that gifted the subscription to the user. Is an empty string if `is_gift` is **false**.
        /// </param>
        /// <param name="gifterLogin">
        /// The gifter’s login name. Is an empty string if `is_gift` is **false**.
        /// </param>
        /// <param name="gifterName">
        /// The gifter’s display name. Is an empty string if `is_gift` is **false**.
        /// </param>
        /// <param name="isGift">
        /// A Boolean value that determines whether the subscription is a gift subscription. Is **true** if the subscription was gifted.
        /// </param>
        /// <param name="planName">
        /// The name of the subscription.
        /// </param>
        /// <param name="tier">
        /// The type of subscription. Possible values are:  <br/>
        ///   <br/>
        /// * 1000 — Tier 1<br/>
        /// * 2000 — Tier 2<br/>
        /// * 3000 — Tier 3
        /// </param>
        /// <param name="userId">
        /// An ID that identifies the subscribing user.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
        public BroadcasterSubscription(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string gifterId,
            string gifterLogin,
            string gifterName,
            bool isGift,
            string planName,
            global::G.BroadcasterSubscriptionTier tier,
            string userId,
            string userName,
            string userLogin)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.GifterId = gifterId ?? throw new global::System.ArgumentNullException(nameof(gifterId));
            this.GifterLogin = gifterLogin ?? throw new global::System.ArgumentNullException(nameof(gifterLogin));
            this.GifterName = gifterName ?? throw new global::System.ArgumentNullException(nameof(gifterName));
            this.IsGift = isGift;
            this.PlanName = planName ?? throw new global::System.ArgumentNullException(nameof(planName));
            this.Tier = tier;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcasterSubscription" /> class.
        /// </summary>
        public BroadcasterSubscription()
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
        public static global::G.BroadcasterSubscription? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BroadcasterSubscription>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.BroadcasterSubscription?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.BroadcasterSubscription?>(serializer.Deserialize<global::G.BroadcasterSubscription>(jsonReader));
        }

    }
}