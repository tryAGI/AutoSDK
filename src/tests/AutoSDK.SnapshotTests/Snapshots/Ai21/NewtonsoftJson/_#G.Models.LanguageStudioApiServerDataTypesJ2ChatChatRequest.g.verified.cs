//HintName: G.Models.LanguageStudioApiServerDataTypesJ2ChatChatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class LanguageStudioApiServerDataTypesJ2ChatChatRequest
    {
        /// <summary>
        /// messages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatMessage> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system", Required = global::Newtonsoft.Json.Required.Always)]
        public string System { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequencyPenalty")]
        public global::G.Penalty? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presencePenalty")]
        public global::G.Penalty? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("countPenalty")]
        public global::G.Penalty? CountPenalty { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Default Value: 0.7
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Default Value: 300
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minTokens")]
        public int? MinTokens { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public double? TopP { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topKReturn")]
        public int? TopKReturn { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stopSequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageStudioApiServerDataTypesJ2ChatChatRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="system"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="countPenalty"></param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0.7
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 300
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="stopSequences">
        /// Default Value: []
        /// </param>
        public LanguageStudioApiServerDataTypesJ2ChatChatRequest(
            global::System.Collections.Generic.IList<global::G.ChatMessage> messages,
            string system,
            global::G.Penalty? frequencyPenalty,
            global::G.Penalty? presencePenalty,
            global::G.Penalty? countPenalty,
            int? numResults,
            double? temperature,
            int? maxTokens,
            int? minTokens,
            double? topP,
            int? topKReturn,
            global::System.Collections.Generic.IList<string>? stopSequences)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.System = system ?? throw new global::System.ArgumentNullException(nameof(system));
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.CountPenalty = countPenalty;
            this.NumResults = numResults;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.MinTokens = minTokens;
            this.TopP = topP;
            this.TopKReturn = topKReturn;
            this.StopSequences = stopSequences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageStudioApiServerDataTypesJ2ChatChatRequest" /> class.
        /// </summary>
        public LanguageStudioApiServerDataTypesJ2ChatChatRequest()
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
        public static global::G.LanguageStudioApiServerDataTypesJ2ChatChatRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LanguageStudioApiServerDataTypesJ2ChatChatRequest>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.LanguageStudioApiServerDataTypesJ2ChatChatRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.LanguageStudioApiServerDataTypesJ2ChatChatRequest?>(serializer.Deserialize<global::G.LanguageStudioApiServerDataTypesJ2ChatChatRequest>(jsonReader));
        }

    }
}