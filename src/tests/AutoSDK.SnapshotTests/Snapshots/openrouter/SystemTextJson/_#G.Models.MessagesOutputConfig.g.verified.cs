//HintName: G.Models.MessagesOutputConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.
    /// </summary>
    public sealed partial class MessagesOutputConfig
    {
        /// <summary>
        /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer. Valid values are `low`, `medium`, `high`, or `max`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.MessagesOutputConfigEffort?, object>))]
        public global::G.OneOf<global::G.MessagesOutputConfigEffort?, object>? Effort { get; set; }

        /// <summary>
        /// A schema to specify Claude's output format in responses. See [structured outputs](https://platform.claude.com/docs/en/build-with-claude/structured-outputs).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.MessagesOutputConfigFormat, object>))]
        public global::G.OneOf<global::G.MessagesOutputConfigFormat, object>? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfig" /> class.
        /// </summary>
        /// <param name="effort">
        /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer. Valid values are `low`, `medium`, `high`, or `max`.
        /// </param>
        /// <param name="format">
        /// A schema to specify Claude's output format in responses. See [structured outputs](https://platform.claude.com/docs/en/build-with-claude/structured-outputs).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesOutputConfig(
            global::G.OneOf<global::G.MessagesOutputConfigEffort?, object>? effort,
            global::G.OneOf<global::G.MessagesOutputConfigFormat, object>? format)
        {
            this.Effort = effort;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfig" /> class.
        /// </summary>
        public MessagesOutputConfig()
        {
        }
    }
}