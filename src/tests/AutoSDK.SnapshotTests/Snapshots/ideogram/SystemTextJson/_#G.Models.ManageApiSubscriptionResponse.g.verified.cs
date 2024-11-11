//HintName: G.Models.ManageApiSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManageApiSubscriptionResponse
    {
        /// <summary>
        /// Whether or not the latest required terms have been accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_accepted_terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAcceptedTerms { get; set; }

        /// <summary>
        /// Whether or not Stripe is setup for API usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_stripe_setup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasStripeSetup { get; set; }

        /// <summary>
        /// The URL to display the customer usage dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_dashboard_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MetronomeDashboardUrl { get; set; }

        /// <summary>
        /// The URL to display the customer usage dashboard, in dark mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_dashboard_dark_mode_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MetronomeDashboardDarkModeUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_links")]
        public global::G.MetronomeLinks? MetronomeLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recharge_settings")]
        public global::G.RechargeSettingsResponse? RechargeSettings { get; set; }

        /// <summary>
        /// The URL for the user to manage the existing Stripe subscription plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_billing_url")]
        public string? StripeBillingUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="hasAcceptedTerms">
        /// Whether or not the latest required terms have been accepted.
        /// </param>
        /// <param name="hasStripeSetup">
        /// Whether or not Stripe is setup for API usage.
        /// </param>
        /// <param name="metronomeLinks"></param>
        /// <param name="rechargeSettings"></param>
        /// <param name="stripeBillingUrl">
        /// The URL for the user to manage the existing Stripe subscription plan.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ManageApiSubscriptionResponse(
            bool hasAcceptedTerms,
            bool hasStripeSetup,
            global::G.MetronomeLinks? metronomeLinks,
            global::G.RechargeSettingsResponse? rechargeSettings,
            string? stripeBillingUrl)
        {
            this.HasAcceptedTerms = hasAcceptedTerms;
            this.HasStripeSetup = hasStripeSetup;
            this.MetronomeLinks = metronomeLinks;
            this.RechargeSettings = rechargeSettings;
            this.StripeBillingUrl = stripeBillingUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiSubscriptionResponse" /> class.
        /// </summary>
        public ManageApiSubscriptionResponse()
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
        public static global::G.ManageApiSubscriptionResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ManageApiSubscriptionResponse),
                jsonSerializerContext) as global::G.ManageApiSubscriptionResponse;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ManageApiSubscriptionResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ManageApiSubscriptionResponse>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ManageApiSubscriptionResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ManageApiSubscriptionResponse),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ManageApiSubscriptionResponse;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ManageApiSubscriptionResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ManageApiSubscriptionResponse?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}