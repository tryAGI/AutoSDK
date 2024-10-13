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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
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
#if NET6_0_OR_GREATER
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

    }
}