//HintName: G.Models.UpscaleInitialImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A request to upscale a provided image with the help of an optional prompt.
    /// </summary>
    public sealed partial class UpscaleInitialImageRequest
    {
        /// <summary>
        /// An optional prompt to guide the upscale<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resemblance")]
        public int? Resemblance { get; set; } = 50;

        /// <summary>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public int? Detail { get; set; } = 50;

        /// <summary>
        /// Determine if MagicPrompt should be used in generating the request or not<br/>
        /// Default Value: AUTO<br/>
        /// Example: ON
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("magic_prompt_option")]
        public global::G.MagicPromptOption? MagicPromptOption { get; set; } = global::G.MagicPromptOption.AUTO;

        /// <summary>
        /// Example: 12345
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

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
        public static global::G.UpscaleInitialImageRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpscaleInitialImageRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}