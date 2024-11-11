//HintName: G.Models.RechargeSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current recharge settings for the API subscription.
    /// </summary>
    public sealed partial class RechargeSettings
    {
        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_up_balance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Price TopUpBalance { get; set; } = default!;

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimum_balance_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Price MinimumBalanceThreshold { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RechargeSettings" /> class.
        /// </summary>
        /// <param name="topUpBalance">
        /// Represents a price.
        /// </param>
        /// <param name="minimumBalanceThreshold">
        /// Represents a price.
        /// </param>
        public RechargeSettings(
            global::G.Price topUpBalance,
            global::G.Price minimumBalanceThreshold)
        {
            this.TopUpBalance = topUpBalance ?? throw new global::System.ArgumentNullException(nameof(topUpBalance));
            this.MinimumBalanceThreshold = minimumBalanceThreshold ?? throw new global::System.ArgumentNullException(nameof(minimumBalanceThreshold));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RechargeSettings" /> class.
        /// </summary>
        public RechargeSettings()
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
        public static global::G.RechargeSettings? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RechargeSettings>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RechargeSettings?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RechargeSettings?>(serializer.Deserialize<global::G.RechargeSettings>(jsonReader));
        }

    }
}