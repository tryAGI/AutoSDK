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
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// If the chat response was stored, the ID of the turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// The message from the chat model for the chat message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LanguageJsonConverter))]
        public global::G.Language? ResponseLanguage { get; set; }

        /// <summary>
        /// The ranked search results that the chat model used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        public global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// The probability that the summary is factually consistent with the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factual_consistency_score")]
        public float? FactualConsistencyScore { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_text` templates. Only available<br/>
        /// to Scale customers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

        /// <summary>
        /// If you are on the Scale plan, you can view the actual query made to backend that was rephrased <br/>
        /// by the LLM from the input query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rephrased_query")]
        public string? RephrasedQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.ChatFullResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ChatFullResponse),
                jsonSerializerContext) as global::G.ChatFullResponse;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatFullResponse>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ChatFullResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ChatFullResponse),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ChatFullResponse;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ChatFullResponse?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}