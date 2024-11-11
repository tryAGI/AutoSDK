//HintName: G.Models.DataSetObjectIds.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataSetObjectIds
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedTagIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedTagIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedDescriptorIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedDescriptorIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedResourceIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedExcerptIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedExcerptIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedUserIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedUserIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludedExcerptIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExcludedExcerptIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetObjectIds" /> class.
        /// </summary>
        /// <param name="includedTagIds"></param>
        /// <param name="includedDescriptorIds"></param>
        /// <param name="includedResourceIds"></param>
        /// <param name="includedExcerptIds"></param>
        /// <param name="includedUserIds"></param>
        /// <param name="excludedExcerptIds"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DataSetObjectIds(
            global::System.Collections.Generic.IList<global::System.Guid>? includedTagIds,
            global::System.Collections.Generic.IList<global::System.Guid>? includedDescriptorIds,
            global::System.Collections.Generic.IList<global::System.Guid>? includedResourceIds,
            global::System.Collections.Generic.IList<global::System.Guid>? includedExcerptIds,
            global::System.Collections.Generic.IList<global::System.Guid>? includedUserIds,
            global::System.Collections.Generic.IList<global::System.Guid>? excludedExcerptIds)
        {
            this.IncludedTagIds = includedTagIds;
            this.IncludedDescriptorIds = includedDescriptorIds;
            this.IncludedResourceIds = includedResourceIds;
            this.IncludedExcerptIds = includedExcerptIds;
            this.IncludedUserIds = includedUserIds;
            this.ExcludedExcerptIds = excludedExcerptIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetObjectIds" /> class.
        /// </summary>
        public DataSetObjectIds()
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
        public static global::G.DataSetObjectIds? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.DataSetObjectIds),
                jsonSerializerContext) as global::G.DataSetObjectIds;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DataSetObjectIds? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataSetObjectIds>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.DataSetObjectIds?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.DataSetObjectIds),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.DataSetObjectIds;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.DataSetObjectIds?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.DataSetObjectIds?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}