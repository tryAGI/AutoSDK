//HintName: G.Models.BaseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The base model used for fine-tuning.
    /// </summary>
    public sealed partial class BaseModel
    {
        /// <summary>
        /// The name of the base model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// read-only. The version of the base model.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The possible types of fine-tuned models.<br/>
        ///  - BASE_TYPE_UNSPECIFIED: Unspecified model.<br/>
        ///  - BASE_TYPE_GENERATIVE: Deprecated: Generative model.<br/>
        ///  - BASE_TYPE_CLASSIFICATION: Classification model.<br/>
        ///  - BASE_TYPE_RERANK: Rerank model.<br/>
        ///  - BASE_TYPE_CHAT: Chat model.<br/>
        /// Default Value: BASE_TYPE_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseType BaseType { get; set; }

        /// <summary>
        /// The possible strategy used to serve a fine-tuned models.<br/>
        ///  - STRATEGY_UNSPECIFIED: Unspecified strategy.<br/>
        ///  - STRATEGY_VANILLA: Deprecated: Serve the fine-tuned model on a dedicated GPU.<br/>
        ///  - STRATEGY_TFEW: Serve the fine-tuned model on a shared GPU.<br/>
        /// Default Value: STRATEGY_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StrategyJsonConverter))]
        public global::G.Strategy? Strategy { get; set; } = global::G.Strategy.UNSPECIFIED;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
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

        public static global::G.BaseModel? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BaseModel),
                jsonSerializerContext) as global::G.BaseModel;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BaseModel? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseModel>(
                json,
                jsonSerializerOptions);
        }

    }
}