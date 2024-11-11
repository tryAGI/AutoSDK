//HintName: G.Models.ExtensionTransactionProductData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains details about the digital product.
    /// </summary>
    public sealed partial class ExtensionTransactionProductData
    {
        /// <summary>
        /// An ID that identifies the digital product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sku { get; set; }

        /// <summary>
        /// Set to `twitch.ext.` \+ `&lt;the extension's ID&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Contains details about the digital product’s cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionTransactionProductDataCost Cost { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the product is in development. Is **true** if the digital product is in development and cannot be exchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inDevelopment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InDevelopment { get; set; }

        /// <summary>
        /// The name of the digital product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// This field is always empty since you may purchase only unexpired products.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expiration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the data was broadcast to all instances of the extension. Is **true** if the data was broadcast to all instances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Broadcast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionTransactionProductData" /> class.
        /// </summary>
        /// <param name="sku">
        /// An ID that identifies the digital product.
        /// </param>
        /// <param name="domain">
        /// Set to `twitch.ext.` \+ `&lt;the extension's ID&gt;`.
        /// </param>
        /// <param name="cost">
        /// Contains details about the digital product’s cost.
        /// </param>
        /// <param name="inDevelopment">
        /// A Boolean value that determines whether the product is in development. Is **true** if the digital product is in development and cannot be exchanged.
        /// </param>
        /// <param name="displayName">
        /// The name of the digital product.
        /// </param>
        /// <param name="expiration">
        /// This field is always empty since you may purchase only unexpired products.
        /// </param>
        /// <param name="broadcast">
        /// A Boolean value that determines whether the data was broadcast to all instances of the extension. Is **true** if the data was broadcast to all instances.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ExtensionTransactionProductData(
            string sku,
            string domain,
            global::G.ExtensionTransactionProductDataCost cost,
            bool inDevelopment,
            string displayName,
            string expiration,
            bool broadcast)
        {
            this.Sku = sku ?? throw new global::System.ArgumentNullException(nameof(sku));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Cost = cost ?? throw new global::System.ArgumentNullException(nameof(cost));
            this.InDevelopment = inDevelopment;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Expiration = expiration ?? throw new global::System.ArgumentNullException(nameof(expiration));
            this.Broadcast = broadcast;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionTransactionProductData" /> class.
        /// </summary>
        public ExtensionTransactionProductData()
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
        public static global::G.ExtensionTransactionProductData? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ExtensionTransactionProductData),
                jsonSerializerContext) as global::G.ExtensionTransactionProductData;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ExtensionTransactionProductData? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExtensionTransactionProductData>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ExtensionTransactionProductData?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ExtensionTransactionProductData),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ExtensionTransactionProductData;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ExtensionTransactionProductData?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ExtensionTransactionProductData?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}