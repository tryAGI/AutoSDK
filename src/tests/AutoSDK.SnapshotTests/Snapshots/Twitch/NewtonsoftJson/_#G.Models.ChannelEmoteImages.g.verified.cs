//HintName: G.Models.ChannelEmoteImages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.  <br/>
    ///   <br/>
    /// **NOTE:** You should use the templated URL in the `template` field to fetch the image instead of using these URLs.
    /// </summary>
    public sealed partial class ChannelEmoteImages
    {
        /// <summary>
        /// A URL to the small version (28px x 28px) of the emote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_1x", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url1x { get; set; } = default!;

        /// <summary>
        /// A URL to the medium version (56px x 56px) of the emote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_2x", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url2x { get; set; } = default!;

        /// <summary>
        /// A URL to the large version (112px x 112px) of the emote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_4x", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url4x { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEmoteImages" /> class.
        /// </summary>
        /// <param name="url1x">
        /// A URL to the small version (28px x 28px) of the emote.
        /// </param>
        /// <param name="url2x">
        /// A URL to the medium version (56px x 56px) of the emote.
        /// </param>
        /// <param name="url4x">
        /// A URL to the large version (112px x 112px) of the emote.
        /// </param>
        public ChannelEmoteImages(
            string url1x,
            string url2x,
            string url4x)
        {
            this.Url1x = url1x ?? throw new global::System.ArgumentNullException(nameof(url1x));
            this.Url2x = url2x ?? throw new global::System.ArgumentNullException(nameof(url2x));
            this.Url4x = url4x ?? throw new global::System.ArgumentNullException(nameof(url4x));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEmoteImages" /> class.
        /// </summary>
        public ChannelEmoteImages()
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
        public static global::G.ChannelEmoteImages? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ChannelEmoteImages>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ChannelEmoteImages?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ChannelEmoteImages?>(serializer.Deserialize<global::G.ChannelEmoteImages>(jsonReader));
        }

    }
}