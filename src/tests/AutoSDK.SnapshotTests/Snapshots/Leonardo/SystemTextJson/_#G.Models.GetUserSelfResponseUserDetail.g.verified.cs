//HintName: G.Models.GetUserSelfResponseUserDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "user_details"
    /// </summary>
    public sealed partial class GetUserSelfResponseUserDetail
    {
        /// <summary>
        /// columns and relationships of "users"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.GetUserSelfResponseUserDetailUser? User { get; set; }

        /// <summary>
        /// User Plan Token Renewal Date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenRenewalDate")]
        public string? TokenRenewalDate { get; set; }

        /// <summary>
        /// Current balance of paid tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paidTokens")]
        public int? PaidTokens { get; set; }

        /// <summary>
        /// Current balance of user plan subscription tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionTokens")]
        public int? SubscriptionTokens { get; set; }

        /// <summary>
        /// Current balance of user plan GPT tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionGptTokens")]
        public int? SubscriptionGptTokens { get; set; }

        /// <summary>
        /// Current balance of model training tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionModelTokens")]
        public int? SubscriptionModelTokens { get; set; }

        /// <summary>
        /// API Concurrency Slots.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiConcurrencySlots")]
        public int? ApiConcurrencySlots { get; set; }

        /// <summary>
        /// Current balance of API paid tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiPaidTokens")]
        public int? ApiPaidTokens { get; set; }

        /// <summary>
        /// Current balance of Enterprise API subscriptions tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiSubscriptionTokens")]
        public int? ApiSubscriptionTokens { get; set; }

        /// <summary>
        /// API Plan Token Renewal Date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiPlanTokenRenewalDate")]
        public string? ApiPlanTokenRenewalDate { get; set; }

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
        public static global::G.GetUserSelfResponseUserDetail? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GetUserSelfResponseUserDetail),
                jsonSerializerContext) as global::G.GetUserSelfResponseUserDetail;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GetUserSelfResponseUserDetail? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetUserSelfResponseUserDetail>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.GetUserSelfResponseUserDetail?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.GetUserSelfResponseUserDetail),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.GetUserSelfResponseUserDetail;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GetUserSelfResponseUserDetail?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.GetUserSelfResponseUserDetail?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}