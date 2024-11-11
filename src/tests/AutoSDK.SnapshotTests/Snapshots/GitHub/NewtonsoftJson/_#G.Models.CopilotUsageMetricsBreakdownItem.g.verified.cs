//HintName: G.Models.CopilotUsageMetricsBreakdownItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of Copilot usage by editor for this language
    /// </summary>
    public sealed partial class CopilotUsageMetricsBreakdownItem
    {
        /// <summary>
        /// The language in which Copilot suggestions were shown to users in the specified editor.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The editor in which Copilot suggestions were shown to users for the specified language.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("editor")]
        public string? Editor { get; set; }

        /// <summary>
        /// The number of Copilot suggestions shown to users in the editor specified during the day specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggestions_count")]
        public int? SuggestionsCount { get; set; }

        /// <summary>
        /// The number of Copilot suggestions accepted by users in the editor specified during the day specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("acceptances_count")]
        public int? AcceptancesCount { get; set; }

        /// <summary>
        /// The number of lines of code suggested by Copilot in the editor specified during the day specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lines_suggested")]
        public int? LinesSuggested { get; set; }

        /// <summary>
        /// The number of lines of code accepted by users in the editor specified during the day specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lines_accepted")]
        public int? LinesAccepted { get; set; }

        /// <summary>
        /// The number of users who were shown Copilot completion suggestions in the editor specified during the day specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_users")]
        public int? ActiveUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetricsBreakdownItem" /> class.
        /// </summary>
        /// <param name="language">
        /// The language in which Copilot suggestions were shown to users in the specified editor.
        /// </param>
        /// <param name="editor">
        /// The editor in which Copilot suggestions were shown to users for the specified language.
        /// </param>
        /// <param name="suggestionsCount">
        /// The number of Copilot suggestions shown to users in the editor specified during the day specified.
        /// </param>
        /// <param name="acceptancesCount">
        /// The number of Copilot suggestions accepted by users in the editor specified during the day specified.
        /// </param>
        /// <param name="linesSuggested">
        /// The number of lines of code suggested by Copilot in the editor specified during the day specified.
        /// </param>
        /// <param name="linesAccepted">
        /// The number of lines of code accepted by users in the editor specified during the day specified.
        /// </param>
        /// <param name="activeUsers">
        /// The number of users who were shown Copilot completion suggestions in the editor specified during the day specified.
        /// </param>
        public CopilotUsageMetricsBreakdownItem(
            string? language,
            string? editor,
            int? suggestionsCount,
            int? acceptancesCount,
            int? linesSuggested,
            int? linesAccepted,
            int? activeUsers)
        {
            this.Language = language;
            this.Editor = editor;
            this.SuggestionsCount = suggestionsCount;
            this.AcceptancesCount = acceptancesCount;
            this.LinesSuggested = linesSuggested;
            this.LinesAccepted = linesAccepted;
            this.ActiveUsers = activeUsers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetricsBreakdownItem" /> class.
        /// </summary>
        public CopilotUsageMetricsBreakdownItem()
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
        public static global::G.CopilotUsageMetricsBreakdownItem? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CopilotUsageMetricsBreakdownItem>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CopilotUsageMetricsBreakdownItem?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CopilotUsageMetricsBreakdownItem?>(serializer.Deserialize<global::G.CopilotUsageMetricsBreakdownItem>(jsonReader));
        }

    }
}