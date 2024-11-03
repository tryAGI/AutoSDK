//HintName: G.Models.CopilotUsageMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of Copilot usage.
    /// </summary>
    public sealed partial class CopilotUsageMetrics
    {
        /// <summary>
        /// The date for which the usage metrics are reported, in `YYYY-MM-DD` format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// The total number of Copilot code completion suggestions shown to users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_suggestions_count")]
        public int? TotalSuggestionsCount { get; set; }

        /// <summary>
        /// The total number of Copilot code completion suggestions accepted by users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_acceptances_count")]
        public int? TotalAcceptancesCount { get; set; }

        /// <summary>
        /// The total number of lines of code completions suggested by Copilot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_lines_suggested")]
        public int? TotalLinesSuggested { get; set; }

        /// <summary>
        /// The total number of lines of code completions accepted by users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_lines_accepted")]
        public int? TotalLinesAccepted { get; set; }

        /// <summary>
        /// The total number of users who were shown Copilot code completion suggestions during the day specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_active_users")]
        public int? TotalActiveUsers { get; set; }

        /// <summary>
        /// The total instances of users who accepted code suggested by Copilot Chat in the IDE (panel and inline).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_chat_acceptances")]
        public int? TotalChatAcceptances { get; set; }

        /// <summary>
        /// The total number of chat turns (prompt and response pairs) sent between users and Copilot Chat in the IDE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_chat_turns")]
        public int? TotalChatTurns { get; set; }

        /// <summary>
        /// The total number of users who interacted with Copilot Chat in the IDE during the day specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_active_chat_users")]
        public int? TotalActiveChatUsers { get; set; }

        /// <summary>
        /// Breakdown of Copilot code completions usage by language and editor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CopilotUsageMetricsBreakdownItem>? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.CopilotUsageMetrics? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CopilotUsageMetrics),
                jsonSerializerContext) as global::G.CopilotUsageMetrics;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CopilotUsageMetrics? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CopilotUsageMetrics>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CopilotUsageMetrics?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CopilotUsageMetrics),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CopilotUsageMetrics;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CopilotUsageMetrics?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CopilotUsageMetrics?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}