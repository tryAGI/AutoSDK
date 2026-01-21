//HintName: G.Models.PlaygroundPromptCanvasPayload.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundPromptCanvasPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.AIMessage, global::G.HumanMessage, global::G.ChatMessage, global::G.SystemMessage, global::G.FunctionMessage, global::G.ToolMessage, global::G.AIMessageChunk, global::G.HumanMessageChunk, global::G.ChatMessageChunk, global::G.SystemMessageChunk, global::G.FunctionMessageChunk, global::G.ToolMessageChunk>> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlighted")]
        public global::G.Highlight? Highlighted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact")]
        public global::G.Artifact? Artifact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_length")]
        public global::G.PlaygroundPromptCanvasPayloadArtifactLength2? ArtifactLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reading_level")]
        public global::G.PlaygroundPromptCanvasPayloadReadingLevel2? ReadingLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_action")]
        public string? CustomAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PlaygroundPromptCanvasPayloadTemplateFormat TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundPromptCanvasPayload" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="highlighted"></param>
        /// <param name="artifact"></param>
        /// <param name="artifactLength"></param>
        /// <param name="readingLevel"></param>
        /// <param name="customAction"></param>
        /// <param name="templateFormat"></param>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundPromptCanvasPayload(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AIMessage, global::G.HumanMessage, global::G.ChatMessage, global::G.SystemMessage, global::G.FunctionMessage, global::G.ToolMessage, global::G.AIMessageChunk, global::G.HumanMessageChunk, global::G.ChatMessageChunk, global::G.SystemMessageChunk, global::G.FunctionMessageChunk, global::G.ToolMessageChunk>> messages,
            global::G.PlaygroundPromptCanvasPayloadTemplateFormat templateFormat,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::G.Highlight? highlighted,
            global::G.Artifact? artifact,
            global::G.PlaygroundPromptCanvasPayloadArtifactLength2? artifactLength,
            global::G.PlaygroundPromptCanvasPayloadReadingLevel2? readingLevel,
            string? customAction)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.TemplateFormat = templateFormat;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.Highlighted = highlighted;
            this.Artifact = artifact;
            this.ArtifactLength = artifactLength;
            this.ReadingLevel = readingLevel;
            this.CustomAction = customAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundPromptCanvasPayload" /> class.
        /// </summary>
        public PlaygroundPromptCanvasPayload()
        {
        }
    }
}