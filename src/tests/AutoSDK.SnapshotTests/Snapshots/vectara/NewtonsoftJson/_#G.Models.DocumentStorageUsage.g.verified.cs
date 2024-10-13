//HintName: G.Models.DocumentStorageUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much storage the document used. This information is currently not returned when<br/>
    /// retrieving the document, and only returned when indexing a document.
    /// </summary>
    public sealed partial class DocumentStorageUsage
    {
        /// <summary>
        /// Number of bytes used by document counting towards maximum corpus size, and<br/>
        /// towards any billing plans.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes_used")]
        public long? BytesUsed { get; set; }

        /// <summary>
        /// Number of metadata bytes used by a document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_bytes_used")]
        public long? MetadataBytesUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
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

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DocumentStorageUsage? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DocumentStorageUsage>(
                json,
                jsonSerializerOptions);
        }

    }
}