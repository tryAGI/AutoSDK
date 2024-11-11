//HintName: G.Models.ActionsGenerateRunnerJitconfigForRepoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGenerateRunnerJitconfigForRepoResponse
    {
        /// <summary>
        /// A self hosted runner
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Runner Runner { get; set; } = default!;

        /// <summary>
        /// The base64 encoded runner configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoded_jit_config", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncodedJitConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGenerateRunnerJitconfigForRepoResponse" /> class.
        /// </summary>
        /// <param name="runner">
        /// A self hosted runner
        /// </param>
        /// <param name="encodedJitConfig">
        /// The base64 encoded runner configuration.
        /// </param>
        public ActionsGenerateRunnerJitconfigForRepoResponse(
            global::G.Runner runner,
            string encodedJitConfig)
        {
            this.Runner = runner ?? throw new global::System.ArgumentNullException(nameof(runner));
            this.EncodedJitConfig = encodedJitConfig ?? throw new global::System.ArgumentNullException(nameof(encodedJitConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGenerateRunnerJitconfigForRepoResponse" /> class.
        /// </summary>
        public ActionsGenerateRunnerJitconfigForRepoResponse()
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
        public static global::G.ActionsGenerateRunnerJitconfigForRepoResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ActionsGenerateRunnerJitconfigForRepoResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ActionsGenerateRunnerJitconfigForRepoResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ActionsGenerateRunnerJitconfigForRepoResponse?>(serializer.Deserialize<global::G.ActionsGenerateRunnerJitconfigForRepoResponse>(jsonReader));
        }

    }
}