//HintName: G.Models.Prompt2025VersionPromptBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025VersionPromptBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessage>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyTool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Prompt2025VersionPromptBodyToolChoice>))]
        public global::G.AnyOf<string, global::G.Prompt2025VersionPromptBodyToolChoice>? ToolChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBody" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="maxTokens"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prompt2025VersionPromptBody(
            string? model,
            global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessage>? messages,
            double? temperature,
            double? topP,
            double? maxTokens,
            global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyTool>? tools,
            global::G.AnyOf<string, global::G.Prompt2025VersionPromptBodyToolChoice>? toolChoice)
        {
            this.Model = model;
            this.Messages = messages;
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxTokens = maxTokens;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBody" /> class.
        /// </summary>
        public Prompt2025VersionPromptBody()
        {
        }
    }
}