//HintName: G.Models.StreamTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamTag
    {
        /// <summary>
        /// An ID that identifies this tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagId { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the tag is an automatic tag. An automatic tag is one that Twitch adds to the stream. Broadcasters may not add automatic tags to their channel. The value is **true** if the tag is an automatic tag; otherwise, **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_auto")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAuto { get; set; }

        /// <summary>
        /// A dictionary that contains the localized names of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localization_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> LocalizationNames { get; set; }

        /// <summary>
        /// A dictionary that contains the localized descriptions of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localization_descriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> LocalizationDescriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamTag" /> class.
        /// </summary>
        /// <param name="tagId">
        /// An ID that identifies this tag.
        /// </param>
        /// <param name="isAuto">
        /// A Boolean value that determines whether the tag is an automatic tag. An automatic tag is one that Twitch adds to the stream. Broadcasters may not add automatic tags to their channel. The value is **true** if the tag is an automatic tag; otherwise, **false**.
        /// </param>
        /// <param name="localizationNames">
        /// A dictionary that contains the localized names of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized name.
        /// </param>
        /// <param name="localizationDescriptions">
        /// A dictionary that contains the localized descriptions of the tag. The key is in the form, &lt;locale&gt;-&lt;coutry/region&gt;. For example, en-us. The value is the localized description.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StreamTag(
            string tagId,
            bool isAuto,
            global::System.Collections.Generic.Dictionary<string, string> localizationNames,
            global::System.Collections.Generic.Dictionary<string, string> localizationDescriptions)
        {
            this.TagId = tagId ?? throw new global::System.ArgumentNullException(nameof(tagId));
            this.IsAuto = isAuto;
            this.LocalizationNames = localizationNames ?? throw new global::System.ArgumentNullException(nameof(localizationNames));
            this.LocalizationDescriptions = localizationDescriptions ?? throw new global::System.ArgumentNullException(nameof(localizationDescriptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamTag" /> class.
        /// </summary>
        public StreamTag()
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
        public static global::G.StreamTag? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.StreamTag),
                jsonSerializerContext) as global::G.StreamTag;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.StreamTag? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.StreamTag>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.StreamTag?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.StreamTag),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.StreamTag;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.StreamTag?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.StreamTag?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}