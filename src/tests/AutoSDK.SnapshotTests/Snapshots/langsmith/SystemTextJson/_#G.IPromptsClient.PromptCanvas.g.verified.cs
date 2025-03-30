//HintName: G.IPromptsClient.PromptCanvas.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Prompt Canvas
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PromptCanvasAsync(
            global::G.PlaygroundPromptCanvasPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Prompt Canvas
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="highlighted"></param>
        /// <param name="artifact"></param>
        /// <param name="artifactLength"></param>
        /// <param name="readingLevel"></param>
        /// <param name="customAction"></param>
        /// <param name="templateFormat"></param>
        /// <param name="secrets"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PromptCanvasAsync(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AIMessage, global::G.HumanMessage, global::G.ChatMessage, global::G.SystemMessage, global::G.FunctionMessage, global::G.ToolMessage, global::G.AIMessageChunk, global::G.HumanMessageChunk, global::G.ChatMessageChunk, global::G.SystemMessageChunk, global::G.FunctionMessageChunk, global::G.ToolMessageChunk>> messages,
            global::G.PlaygroundPromptCanvasPayloadTemplateFormat templateFormat,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::G.Highlight? highlighted = default,
            global::G.Artifact? artifact = default,
            global::G.PlaygroundPromptCanvasPayloadArtifactLength? artifactLength = default,
            global::G.PlaygroundPromptCanvasPayloadReadingLevel? readingLevel = default,
            string? customAction = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}