//HintName: G.Models.ClassificationMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional information to a specific classification
    /// </summary>
    public sealed partial class ClassificationMeta
    {
        /// <summary>
        /// time when this classification was started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started")]
        public global::System.DateTime? Started { get; set; }

        /// <summary>
        /// time when this classification finished
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public global::System.DateTime? Completed { get; set; }

        /// <summary>
        /// number of objects which were taken into consideration for classification<br/>
        /// Example: 147
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// number of objects successfully classified<br/>
        /// Example: 140
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("countSucceeded")]
        public int? CountSucceeded { get; set; }

        /// <summary>
        /// number of objects which could not be classified - see error message for details<br/>
        /// Example: 7
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("countFailed")]
        public int? CountFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.ClassificationMeta? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ClassificationMeta>(
                json,
                jsonSerializerOptions);
        }

    }
}