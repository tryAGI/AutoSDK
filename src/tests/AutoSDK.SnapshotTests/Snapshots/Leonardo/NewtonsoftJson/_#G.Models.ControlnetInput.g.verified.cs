//HintName: G.Models.ControlnetInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ControlnetInput
    {
        /// <summary>
        /// The ID of the init image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initImageId")]
        public string? InitImageId { get; set; }

        /// <summary>
        /// Type indicating whether the init image is uploaded or generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initImageType")]
        public global::G.ControlnetInputInitImageType? InitImageType { get; set; }

        /// <summary>
        /// ID of the controlnet. A list of compatible IDs can be found in our guides.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preprocessorId")]
        public double? PreprocessorId { get; set; }

        /// <summary>
        /// Weight for the controlnet
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Strength type for the controlnet. Can only be used for Style, Character and Content Reference controlnets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strengthType")]
        public global::G.ControlnetInputStrengthType? StrengthType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.ControlnetInput? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ControlnetInput>(
                json,
                jsonSerializerOptions);
        }

    }
}