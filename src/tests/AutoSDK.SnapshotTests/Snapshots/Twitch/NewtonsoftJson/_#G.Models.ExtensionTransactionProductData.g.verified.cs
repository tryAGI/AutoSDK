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
        [global::Newtonsoft.Json.JsonProperty("sku", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sku { get; set; } = default!;

        /// <summary>
        /// Set to `twitch.ext.` \+ `&lt;the extension's ID&gt;`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain", Required = global::Newtonsoft.Json.Required.Always)]
        public string Domain { get; set; } = default!;

        /// <summary>
        /// Contains details about the digital product’s cost.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionTransactionProductDataCost Cost { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the product is in development. Is **true** if the digital product is in development and cannot be exchanged.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inDevelopment", Required = global::Newtonsoft.Json.Required.Always)]
        public bool InDevelopment { get; set; } = default!;

        /// <summary>
        /// The name of the digital product.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// This field is always empty since you may purchase only unexpired products.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiration", Required = global::Newtonsoft.Json.Required.Always)]
        public string Expiration { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the data was broadcast to all instances of the extension. Is **true** if the data was broadcast to all instances.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcast", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Broadcast { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.ExtensionTransactionProductData? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ExtensionTransactionProductData>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ExtensionTransactionProductData?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ExtensionTransactionProductData?>(serializer.Deserialize<global::G.ExtensionTransactionProductData>(jsonReader));
        }

    }
}