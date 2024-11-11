//HintName: G.Models.ListModelRunsByRequesterResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListModelRunsByRequesterResponse is the request message for ListModelRunsByRequester.
    /// </summary>
    public sealed partial class ListModelRunsByRequesterResponse
    {
        /// <summary>
        /// A list of runs resources.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runs")]
        public global::System.Collections.Generic.IList<global::G.ModelRun>? Runs { get; set; }

        /// <summary>
        /// Total number of runs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The requested page size.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// The requested page offset.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelRunsByRequesterResponse" /> class.
        /// </summary>
        /// <param name="runs">
        /// A list of runs resources.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of runs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pageSize">
        /// The requested page size.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="page">
        /// The requested page offset.<br/>
        /// Included only in responses
        /// </param>
        public ListModelRunsByRequesterResponse(
            global::System.Collections.Generic.IList<global::G.ModelRun>? runs,
            int? totalSize,
            int? pageSize,
            int? page)
        {
            this.Runs = runs;
            this.TotalSize = totalSize;
            this.PageSize = pageSize;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelRunsByRequesterResponse" /> class.
        /// </summary>
        public ListModelRunsByRequesterResponse()
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
        public static global::G.ListModelRunsByRequesterResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListModelRunsByRequesterResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ListModelRunsByRequesterResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ListModelRunsByRequesterResponse?>(serializer.Deserialize<global::G.ListModelRunsByRequesterResponse>(jsonReader));
        }

    }
}