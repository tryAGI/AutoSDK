//HintName: G.Models.ChatFullResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Full response to a chat question when the result is not streamed.
    /// </summary>
    public sealed partial class ChatFullResponse
    {
        /// <summary>
        /// If the chat response was stored, the ID of the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// If the chat response was stored, the ID of the turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// The message from the chat model for the chat message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_language")]
        public global::G.Language? ResponseLanguage { get; set; }

        /// <summary>
        /// The ranked search results that the chat model used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_results")]
        public global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// The probability that the summary is factually consistent with the results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("factual_consistency_score")]
        public float? FactualConsistencyScore { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_text` templates. Only available<br/>
        /// to Scale customers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

        /// <summary>
        /// If you are on the Scale plan, you can view the actual query made to backend that was rephrased <br/>
        /// by the LLM from the input query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rephrased_query")]
        public string? RephrasedQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFullResponse" /> class.
        /// </summary>
        /// <param name="chatId">
        /// If the chat response was stored, the ID of the chat.
        /// </param>
        /// <param name="turnId">
        /// If the chat response was stored, the ID of the turn.
        /// </param>
        /// <param name="answer">
        /// The message from the chat model for the chat message.
        /// </param>
        /// <param name="responseLanguage">
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="searchResults">
        /// The ranked search results that the chat model used.
        /// </param>
        /// <param name="factualConsistencyScore">
        /// The probability that the summary is factually consistent with the results.
        /// </param>
        /// <param name="renderedPrompt">
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_text` templates. Only available<br/>
        /// to Scale customers.
        /// </param>
        /// <param name="rephrasedQuery">
        /// If you are on the Scale plan, you can view the actual query made to backend that was rephrased <br/>
        /// by the LLM from the input query.
        /// </param>
        public ChatFullResponse(
            string? chatId,
            string? turnId,
            string? answer,
            global::G.Language? responseLanguage,
            global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? searchResults,
            float? factualConsistencyScore,
            string? renderedPrompt,
            string? rephrasedQuery)
        {
            this.ChatId = chatId;
            this.TurnId = turnId;
            this.Answer = answer;
            this.ResponseLanguage = responseLanguage;
            this.SearchResults = searchResults;
            this.FactualConsistencyScore = factualConsistencyScore;
            this.RenderedPrompt = renderedPrompt;
            this.RephrasedQuery = rephrasedQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFullResponse" /> class.
        /// </summary>
        public ChatFullResponse()
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
        public static global::G.ChatFullResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ChatFullResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ChatFullResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ChatFullResponse?>(serializer.Deserialize<global::G.ChatFullResponse>(jsonReader));
        }

    }
}