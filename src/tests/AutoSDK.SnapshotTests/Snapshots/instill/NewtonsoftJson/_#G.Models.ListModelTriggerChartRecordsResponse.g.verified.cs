//HintName: G.Models.ListModelTriggerChartRecordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListModelTriggerChartRecordsResponse contains a list of model trigger<br/>
    /// chart records.
    /// </summary>
    public sealed partial class ListModelTriggerChartRecordsResponse
    {
        /// <summary>
        /// Model trigger counts. Until we allow filtering or grouping by fields<br/>
        /// like model ID, this list will contain only one element with the<br/>
        /// timeline of trigger counts for a given requester, regardless the model<br/>
        /// ID, trigger mode, final status or other fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelTriggerChartRecords")]
        public global::System.Collections.Generic.IList<global::G.ModelTriggerChartRecord>? ModelTriggerChartRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelTriggerChartRecordsResponse" /> class.
        /// </summary>
        /// <param name="modelTriggerChartRecords">
        /// Model trigger counts. Until we allow filtering or grouping by fields<br/>
        /// like model ID, this list will contain only one element with the<br/>
        /// timeline of trigger counts for a given requester, regardless the model<br/>
        /// ID, trigger mode, final status or other fields.
        /// </param>
        public ListModelTriggerChartRecordsResponse(
            global::System.Collections.Generic.IList<global::G.ModelTriggerChartRecord>? modelTriggerChartRecords)
        {
            this.ModelTriggerChartRecords = modelTriggerChartRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelTriggerChartRecordsResponse" /> class.
        /// </summary>
        public ListModelTriggerChartRecordsResponse()
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
        public static global::G.ListModelTriggerChartRecordsResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListModelTriggerChartRecordsResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ListModelTriggerChartRecordsResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ListModelTriggerChartRecordsResponse?>(serializer.Deserialize<global::G.ListModelTriggerChartRecordsResponse>(jsonReader));
        }

    }
}