//HintName: G.Models.PricingCalculatorRequestServiceParamsLCMGENERATION.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for LCM_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsLCMGENERATION
    {
        /// <summary>
        /// The output height of the image. Must be 512, 640 or 1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Enable for instant upscale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instantRefine")]
        public bool? InstantRefine { get; set; }

        /// <summary>
        /// Enable for normal alchemy upscale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refine")]
        public bool? Refine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsLCMGENERATION" /> class.
        /// </summary>
        /// <param name="height">
        /// The output height of the image. Must be 512, 640 or 1024.
        /// </param>
        /// <param name="width">
        /// The output width of the image. Must be 512, 640 or 1024.
        /// </param>
        /// <param name="instantRefine">
        /// Enable for instant upscale
        /// </param>
        /// <param name="refine">
        /// Enable for normal alchemy upscale
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PricingCalculatorRequestServiceParamsLCMGENERATION(
            int? height,
            int? width,
            bool? instantRefine,
            bool? refine)
        {
            this.Height = height;
            this.Width = width;
            this.InstantRefine = instantRefine;
            this.Refine = refine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsLCMGENERATION" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsLCMGENERATION()
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
        public static global::G.PricingCalculatorRequestServiceParamsLCMGENERATION? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.PricingCalculatorRequestServiceParamsLCMGENERATION),
                jsonSerializerContext) as global::G.PricingCalculatorRequestServiceParamsLCMGENERATION;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PricingCalculatorRequestServiceParamsLCMGENERATION? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.PricingCalculatorRequestServiceParamsLCMGENERATION>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.PricingCalculatorRequestServiceParamsLCMGENERATION?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.PricingCalculatorRequestServiceParamsLCMGENERATION),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.PricingCalculatorRequestServiceParamsLCMGENERATION;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PricingCalculatorRequestServiceParamsLCMGENERATION?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.PricingCalculatorRequestServiceParamsLCMGENERATION?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}