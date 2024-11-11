//HintName: G.Models.UserResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionResponseModel Subscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_new_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsNewUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xi_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XiApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_delayed_payment_methods")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseDelayedPaymentMethods { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_onboarding_completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOnboardingCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_onboarding_checklist_completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOnboardingChecklistCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_api_key_hashed")]
        public bool? IsApiKeyHashed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xi_api_key_preview")]
        public string? XiApiKeyPreview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseModel" /> class.
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="isNewUser"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="canUseDelayedPaymentMethods"></param>
        /// <param name="isOnboardingCompleted"></param>
        /// <param name="isOnboardingChecklistCompleted"></param>
        /// <param name="firstName"></param>
        /// <param name="isApiKeyHashed">
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKeyPreview"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UserResponseModel(
            global::G.SubscriptionResponseModel subscription,
            bool isNewUser,
            string xiApiKey,
            bool canUseDelayedPaymentMethods,
            bool isOnboardingCompleted,
            bool isOnboardingChecklistCompleted,
            string? firstName,
            bool? isApiKeyHashed,
            string? xiApiKeyPreview)
        {
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.IsNewUser = isNewUser;
            this.XiApiKey = xiApiKey ?? throw new global::System.ArgumentNullException(nameof(xiApiKey));
            this.CanUseDelayedPaymentMethods = canUseDelayedPaymentMethods;
            this.IsOnboardingCompleted = isOnboardingCompleted;
            this.IsOnboardingChecklistCompleted = isOnboardingChecklistCompleted;
            this.FirstName = firstName;
            this.IsApiKeyHashed = isApiKeyHashed;
            this.XiApiKeyPreview = xiApiKeyPreview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseModel" /> class.
        /// </summary>
        public UserResponseModel()
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
        public static global::G.UserResponseModel? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.UserResponseModel),
                jsonSerializerContext) as global::G.UserResponseModel;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.UserResponseModel? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserResponseModel>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.UserResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.UserResponseModel),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.UserResponseModel;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.UserResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.UserResponseModel?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}