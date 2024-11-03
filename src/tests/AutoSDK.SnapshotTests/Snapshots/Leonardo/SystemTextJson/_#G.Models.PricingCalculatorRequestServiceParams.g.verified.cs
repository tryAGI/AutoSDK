//HintName: G.Models.PricingCalculatorRequestServiceParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for the service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParams
    {
        /// <summary>
        /// Parameters for IMAGE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("IMAGE_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION? IMAGEGENERATION { get; set; }

        /// <summary>
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FANTASY_AVATAR_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? FANTASYAVATARGENERATION { get; set; }

        /// <summary>
        /// Parameters for MOTION_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MOTION_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsMOTIONGENERATION? MOTIONGENERATION { get; set; }

        /// <summary>
        /// Parameters for LCM_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LCM_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsLCMGENERATION? LCMGENERATION { get; set; }

        /// <summary>
        /// Parameters for MODEL_TRAINING service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MODEL_TRAINING")]
        public global::G.PricingCalculatorRequestServiceParamsMODELTRAINING? MODELTRAINING { get; set; }

        /// <summary>
        /// Parameters for TEXTURE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TEXTURE_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? TEXTUREGENERATION { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNIVERSAL_UPSCALER")]
        public global::G.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? UNIVERSALUPSCALER { get; set; }

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
        public static global::G.PricingCalculatorRequestServiceParams? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.PricingCalculatorRequestServiceParams),
                jsonSerializerContext) as global::G.PricingCalculatorRequestServiceParams;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PricingCalculatorRequestServiceParams? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.PricingCalculatorRequestServiceParams>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.PricingCalculatorRequestServiceParams?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.PricingCalculatorRequestServiceParams),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.PricingCalculatorRequestServiceParams;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PricingCalculatorRequestServiceParams?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.PricingCalculatorRequestServiceParams?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}