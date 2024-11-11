//HintName: G.Models.ListCatalogRunsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListCatalogRunsResponse is the response message for ListCatalogRuns.
    /// </summary>
    public sealed partial class ListCatalogRunsResponse
    {
        /// <summary>
        /// The list of runs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalogRuns")]
        public global::System.Collections.Generic.IList<global::G.CatalogRun>? CatalogRuns { get; set; }

        /// <summary>
        /// The total number of runs matching the request.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public string? TotalSize { get; set; }

        /// <summary>
        /// The current page number.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// The number of items per page.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogRunsResponse" /> class.
        /// </summary>
        /// <param name="catalogRuns">
        /// The list of runs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// The total number of runs matching the request.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="page">
        /// The current page number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pageSize">
        /// The number of items per page.<br/>
        /// Included only in responses
        /// </param>
        public ListCatalogRunsResponse(
            global::System.Collections.Generic.IList<global::G.CatalogRun>? catalogRuns,
            string? totalSize,
            int? page,
            int? pageSize)
        {
            this.CatalogRuns = catalogRuns;
            this.TotalSize = totalSize;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogRunsResponse" /> class.
        /// </summary>
        public ListCatalogRunsResponse()
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
        public static global::G.ListCatalogRunsResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListCatalogRunsResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ListCatalogRunsResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ListCatalogRunsResponse?>(serializer.Deserialize<global::G.ListCatalogRunsResponse>(jsonReader));
        }

    }
}