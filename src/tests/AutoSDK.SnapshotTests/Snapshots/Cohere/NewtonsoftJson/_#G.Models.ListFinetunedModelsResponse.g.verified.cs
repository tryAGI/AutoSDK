//HintName: G.Models.ListFinetunedModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response to a request to list fine-tuned models.
    /// </summary>
    public sealed partial class ListFinetunedModelsResponse
    {
        /// <summary>
        /// List of fine-tuned models matching the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetuned_models")]
        public global::System.Collections.Generic.IList<global::G.FinetunedModel>? FinetunedModels { get; set; }

        /// <summary>
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total count of results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_size")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFinetunedModelsResponse" /> class.
        /// </summary>
        /// <param name="finetunedModels">
        /// List of fine-tuned models matching the request.
        /// </param>
        /// <param name="nextPageToken">
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </param>
        /// <param name="totalSize">
        /// Total count of results.
        /// </param>
        public ListFinetunedModelsResponse(
            global::System.Collections.Generic.IList<global::G.FinetunedModel>? finetunedModels,
            string? nextPageToken,
            int? totalSize)
        {
            this.FinetunedModels = finetunedModels;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFinetunedModelsResponse" /> class.
        /// </summary>
        public ListFinetunedModelsResponse()
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
        public static global::G.ListFinetunedModelsResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListFinetunedModelsResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ListFinetunedModelsResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ListFinetunedModelsResponse?>(serializer.Deserialize<global::G.ListFinetunedModelsResponse>(jsonReader));
        }

    }
}