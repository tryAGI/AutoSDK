//HintName: G.Models.CharityCampaign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharityCampaign
    {
        /// <summary>
        /// An ID that identifies the charity campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An ID that identifies the broadcaster that’s running the campaign.
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
        /// The charity’s name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charity_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CharityName { get; set; }

        /// <summary>
        /// A description of the charity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charity_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CharityDescription { get; set; }

        /// <summary>
        /// A URL to an image of the charity’s logo. The image’s type is PNG and its size is 100px X 100px.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charity_logo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CharityLogo { get; set; }

        /// <summary>
        /// A URL to the charity’s website.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charity_website")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CharityWebsite { get; set; }

        /// <summary>
        /// The current amount of donations that the campaign has received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CharityCampaignCurrentAmount CurrentAmount { get; set; }

        /// <summary>
        /// The campaign’s fundraising goal. This field is **null** if the broadcaster has not defined a fundraising goal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CharityCampaignTargetAmount TargetAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharityCampaign" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies the charity campaign.
        /// </param>
        /// <param name="broadcasterId">
        /// An ID that identifies the broadcaster that’s running the campaign.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="charityName">
        /// The charity’s name.
        /// </param>
        /// <param name="charityDescription">
        /// A description of the charity.
        /// </param>
        /// <param name="charityLogo">
        /// A URL to an image of the charity’s logo. The image’s type is PNG and its size is 100px X 100px.
        /// </param>
        /// <param name="charityWebsite">
        /// A URL to the charity’s website.
        /// </param>
        /// <param name="currentAmount">
        /// The current amount of donations that the campaign has received.
        /// </param>
        /// <param name="targetAmount">
        /// The campaign’s fundraising goal. This field is **null** if the broadcaster has not defined a fundraising goal.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CharityCampaign(
            string id,
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string charityName,
            string charityDescription,
            string charityLogo,
            string charityWebsite,
            global::G.CharityCampaignCurrentAmount currentAmount,
            global::G.CharityCampaignTargetAmount targetAmount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.CharityName = charityName ?? throw new global::System.ArgumentNullException(nameof(charityName));
            this.CharityDescription = charityDescription ?? throw new global::System.ArgumentNullException(nameof(charityDescription));
            this.CharityLogo = charityLogo ?? throw new global::System.ArgumentNullException(nameof(charityLogo));
            this.CharityWebsite = charityWebsite ?? throw new global::System.ArgumentNullException(nameof(charityWebsite));
            this.CurrentAmount = currentAmount ?? throw new global::System.ArgumentNullException(nameof(currentAmount));
            this.TargetAmount = targetAmount ?? throw new global::System.ArgumentNullException(nameof(targetAmount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharityCampaign" /> class.
        /// </summary>
        public CharityCampaign()
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
        public static global::G.CharityCampaign? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CharityCampaign),
                jsonSerializerContext) as global::G.CharityCampaign;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CharityCampaign? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CharityCampaign>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CharityCampaign?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CharityCampaign),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CharityCampaign;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CharityCampaign?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CharityCampaign?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}