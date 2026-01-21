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
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.AIMessage, global::G.HumanMessage, global::G.ChatMessage, global::G.SystemMessage, global::G.FunctionMessage, global::G.ToolMessage, global::G.AIMessageChunk, global::G.HumanMessageChunk, global::G.ChatMessageChunk, global::G.SystemMessageChunk, global::G.FunctionMessageChunk, global::G.ToolMessageChunk>> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("highlighted")]
        public global::G.Highlight? Highlighted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact")]
        public global::G.Artifact? Artifact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact_length")]
        public global::G.PlaygroundPromptCanvasPayloadArtifactLength2? ArtifactLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reading_level")]
        public global::G.PlaygroundPromptCanvasPayloadReadingLevel2? ReadingLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_action")]
        public string? CustomAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PlaygroundPromptCanvasPayloadTemplateFormat TemplateFormat { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secrets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Secrets { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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