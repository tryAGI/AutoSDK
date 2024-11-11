//HintName: G.Models.UpdateAppBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateAppRequest represents a request to update a app.
    /// </summary>
    public sealed partial class UpdateAppBody
    {
        /// <summary>
        /// The app id needs to follow the kebab case format.<br/>
        /// if the new app id is not provided, the app id will not be updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newAppId")]
        public string? NewAppId { get; set; }

        /// <summary>
        /// The app description.<br/>
        /// If the new description is empty, the description will be set to empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newDescription")]
        public string? NewDescription { get; set; }

        /// <summary>
        /// The app tags.<br/>
        /// If the new tags is empty, the tags will be set to empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newTags")]
        public global::System.Collections.Generic.IList<string>? NewTags { get; set; }

        /// <summary>
        /// last AI assistant app catalog uid<br/>
        /// If the last AI assistant app catalog uid is empty, the last AI assistant app catalog uid will be set to empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAiAssistantAppCatalogUid")]
        public string? LastAiAssistantAppCatalogUid { get; set; }

        /// <summary>
        /// last AI assistant app top k<br/>
        /// If the last AI assistant app top k is empty, the last AI assistant app top k will be set to empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAiAssistantAppTopK")]
        public int? LastAiAssistantAppTopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppBody" /> class.
        /// </summary>
        /// <param name="newAppId">
        /// The app id needs to follow the kebab case format.<br/>
        /// if the new app id is not provided, the app id will not be updated.
        /// </param>
        /// <param name="newDescription">
        /// The app description.<br/>
        /// If the new description is empty, the description will be set to empty.
        /// </param>
        /// <param name="newTags">
        /// The app tags.<br/>
        /// If the new tags is empty, the tags will be set to empty.
        /// </param>
        /// <param name="lastAiAssistantAppCatalogUid">
        /// last AI assistant app catalog uid<br/>
        /// If the last AI assistant app catalog uid is empty, the last AI assistant app catalog uid will be set to empty.
        /// </param>
        /// <param name="lastAiAssistantAppTopK">
        /// last AI assistant app top k<br/>
        /// If the last AI assistant app top k is empty, the last AI assistant app top k will be set to empty.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateAppBody(
            string? newAppId,
            string? newDescription,
            global::System.Collections.Generic.IList<string>? newTags,
            string? lastAiAssistantAppCatalogUid,
            int? lastAiAssistantAppTopK)
        {
            this.NewAppId = newAppId;
            this.NewDescription = newDescription;
            this.NewTags = newTags;
            this.LastAiAssistantAppCatalogUid = lastAiAssistantAppCatalogUid;
            this.LastAiAssistantAppTopK = lastAiAssistantAppTopK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppBody" /> class.
        /// </summary>
        public UpdateAppBody()
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
        public static global::G.UpdateAppBody? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.UpdateAppBody),
                jsonSerializerContext) as global::G.UpdateAppBody;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.UpdateAppBody? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateAppBody>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.UpdateAppBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.UpdateAppBody),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.UpdateAppBody;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.UpdateAppBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.UpdateAppBody?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}