//HintName: G.Models.GlobalEmote.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalEmote
    {
        /// <summary>
        /// An ID that identifies this emote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the emote. This is the name that viewers type in the chat window to get the emote to appear.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.  <br/>
        ///   <br/>
        /// **NOTE:** You should use the templated URL in the `template` field to fetch the image instead of using these URLs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GlobalEmoteImages Images { get; set; } = default!;

        /// <summary>
        /// The formats that the emote is available in. For example, if the emote is available only as a static PNG, the array contains only `static`. But if the emote is available as a static PNG and an animated GIF, the array contains `static` and `animated`. The possible formats are:  <br/>
        ///   <br/>
        /// * animated — An animated GIF is available for this emote.<br/>
        /// * static — A static PNG file is available for this emote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GlobalEmoteFormatItem> Format { get; set; } = default!;

        /// <summary>
        /// The sizes that the emote is available in. For example, if the emote is available in small and medium sizes, the array contains 1.0 and 2.0\. Possible sizes are:  <br/>
        ///   <br/>
        /// * 1.0 — A small version (28px x 28px) is available.<br/>
        /// * 2.0 — A medium version (56px x 56px) is available.<br/>
        /// * 3.0 — A large version (112px x 112px) is available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GlobalEmoteScaleItem> Scale { get; set; } = default!;

        /// <summary>
        /// The background themes that the emote is available in. Possible themes are:  <br/>
        ///   <br/>
        /// * dark<br/>
        /// * light
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("theme_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GlobalEmoteThemeModeItem> ThemeMode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalEmote" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this emote.
        /// </param>
        /// <param name="name">
        /// The name of the emote. This is the name that viewers type in the chat window to get the emote to appear.
        /// </param>
        /// <param name="images">
        /// The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.  <br/>
        ///   <br/>
        /// **NOTE:** You should use the templated URL in the `template` field to fetch the image instead of using these URLs.
        /// </param>
        /// <param name="format">
        /// The formats that the emote is available in. For example, if the emote is available only as a static PNG, the array contains only `static`. But if the emote is available as a static PNG and an animated GIF, the array contains `static` and `animated`. The possible formats are:  <br/>
        ///   <br/>
        /// * animated — An animated GIF is available for this emote.<br/>
        /// * static — A static PNG file is available for this emote.
        /// </param>
        /// <param name="scale">
        /// The sizes that the emote is available in. For example, if the emote is available in small and medium sizes, the array contains 1.0 and 2.0\. Possible sizes are:  <br/>
        ///   <br/>
        /// * 1.0 — A small version (28px x 28px) is available.<br/>
        /// * 2.0 — A medium version (56px x 56px) is available.<br/>
        /// * 3.0 — A large version (112px x 112px) is available.
        /// </param>
        /// <param name="themeMode">
        /// The background themes that the emote is available in. Possible themes are:  <br/>
        ///   <br/>
        /// * dark<br/>
        /// * light
        /// </param>
        public GlobalEmote(
            string id,
            string name,
            global::G.GlobalEmoteImages images,
            global::System.Collections.Generic.IList<global::G.GlobalEmoteFormatItem> format,
            global::System.Collections.Generic.IList<global::G.GlobalEmoteScaleItem> scale,
            global::System.Collections.Generic.IList<global::G.GlobalEmoteThemeModeItem> themeMode)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.Scale = scale ?? throw new global::System.ArgumentNullException(nameof(scale));
            this.ThemeMode = themeMode ?? throw new global::System.ArgumentNullException(nameof(themeMode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalEmote" /> class.
        /// </summary>
        public GlobalEmote()
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
        public static global::G.GlobalEmote? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GlobalEmote>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.GlobalEmote?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.GlobalEmote?>(serializer.Deserialize<global::G.GlobalEmote>(jsonReader));
        }

    }
}