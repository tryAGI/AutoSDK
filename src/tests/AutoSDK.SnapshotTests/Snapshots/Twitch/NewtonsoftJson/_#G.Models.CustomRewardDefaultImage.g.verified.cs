//HintName: G.Models.CustomRewardDefaultImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of default images for the reward.
    /// </summary>
    public sealed partial class CustomRewardDefaultImage
    {
        /// <summary>
        /// The URL to a small version of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_1x", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url1x { get; set; } = default!;

        /// <summary>
        /// The URL to a medium version of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_2x", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url2x { get; set; } = default!;

        /// <summary>
        /// The URL to a large version of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_4x", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url4x { get; set; } = default!;

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
        public static global::G.CustomRewardDefaultImage? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CustomRewardDefaultImage>(
                json,
                jsonSerializerOptions);
        }

    }
}