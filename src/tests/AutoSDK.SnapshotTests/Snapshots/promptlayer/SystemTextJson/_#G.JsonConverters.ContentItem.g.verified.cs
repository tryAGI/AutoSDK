//HintName: G.JsonConverters.ContentItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ContentItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ContentItem>
    {
        /// <inheritdoc />
        public override global::G.ContentItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompletionPromptContentItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompletionPromptContentItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompletionPromptContentItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextContent? text = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ThinkingContent? thinking = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ThinkingContent)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CodeContent? code = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CodeContent)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageContent? imageUrl = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageContent)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MediaContent? media = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.Media)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MediaContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MediaContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MediaContent)}");
                media = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MediaVariable? mediaVariable = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.MediaVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MediaVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MediaVariable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MediaVariable)}");
                mediaVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OutputMediaContent? outputMedia = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.OutputMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMediaContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMediaContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OutputMediaContent)}");
                outputMedia = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ServerToolUseContent? serverToolUse = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ServerToolUseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ServerToolUseContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ServerToolUseContent)}");
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WebSearchToolResultContent? webSearchToolResult = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.WebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolResultContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WebSearchToolResultContent)}");
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CodeExecutionResultContent? codeExecutionResult = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.CodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeExecutionResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeExecutionResultContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CodeExecutionResultContent)}");
                codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.McpListToolsContent? mcpListTools = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.McpListTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpListToolsContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpListToolsContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.McpListToolsContent)}");
                mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.McpCallContent? mcpCall = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.McpCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpCallContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.McpCallContent)}");
                mcpCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.McpApprovalRequestContent? mcpApprovalRequest = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.McpApprovalRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpApprovalRequestContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpApprovalRequestContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.McpApprovalRequestContent)}");
                mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.McpApprovalResponseContent? mcpApprovalResponse = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.McpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpApprovalResponseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpApprovalResponseContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.McpApprovalResponseContent)}");
                mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BashCodeExecutionToolResultContent? bashCodeExecutionToolResult = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.BashCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BashCodeExecutionToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BashCodeExecutionToolResultContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BashCodeExecutionToolResultContent)}");
                bashCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TextEditorCodeExecutionToolResultContent? textEditorCodeExecutionToolResult = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.TextEditorCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEditorCodeExecutionToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEditorCodeExecutionToolResultContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextEditorCodeExecutionToolResultContent)}");
                textEditorCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ShellCallContent? shellCall = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ShellCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShellCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShellCallContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ShellCallContent)}");
                shellCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ShellCallOutputContent? shellCallOutput = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShellCallOutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShellCallOutputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ShellCallOutputContent)}");
                shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ApplyPatchCallContent? applyPatchCall = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ApplyPatchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplyPatchCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplyPatchCallContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApplyPatchCallContent)}");
                applyPatchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ApplyPatchCallOutputContent? applyPatchCallOutput = default;
            if (discriminator?.Type == global::G.CompletionPromptContentItemDiscriminatorType.ApplyPatchCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplyPatchCallOutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplyPatchCallOutputContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ApplyPatchCallOutputContent)}");
                applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ContentItem(
                discriminator?.Type,
                text,

                thinking,

                code,

                imageUrl,

                media,

                mediaVariable,

                outputMedia,

                serverToolUse,

                webSearchToolResult,

                codeExecutionResult,

                mcpListTools,

                mcpCall,

                mcpApprovalRequest,

                mcpApprovalResponse,

                bashCodeExecutionToolResult,

                textEditorCodeExecutionToolResult,

                shellCall,

                shellCallOutput,

                applyPatchCall,

                applyPatchCallOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ContentItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ThinkingContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ThinkingContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ThinkingContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl!, typeInfo);
            }
            else if (value.IsMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MediaContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MediaContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MediaContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Media!, typeInfo);
            }
            else if (value.IsMediaVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MediaVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MediaVariable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MediaVariable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MediaVariable!, typeInfo);
            }
            else if (value.IsOutputMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputMediaContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputMediaContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputMediaContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMedia!, typeInfo);
            }
            else if (value.IsServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ServerToolUseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ServerToolUseContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ServerToolUseContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse!, typeInfo);
            }
            else if (value.IsWebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebSearchToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebSearchToolResultContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebSearchToolResultContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult!, typeInfo);
            }
            else if (value.IsCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeExecutionResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeExecutionResultContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeExecutionResultContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionResult!, typeInfo);
            }
            else if (value.IsMcpListTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpListToolsContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpListToolsContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpListToolsContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools!, typeInfo);
            }
            else if (value.IsMcpCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpCallContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpCallContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall!, typeInfo);
            }
            else if (value.IsMcpApprovalRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpApprovalRequestContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpApprovalRequestContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpApprovalRequestContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest!, typeInfo);
            }
            else if (value.IsMcpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.McpApprovalResponseContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.McpApprovalResponseContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.McpApprovalResponseContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse!, typeInfo);
            }
            else if (value.IsBashCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BashCodeExecutionToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BashCodeExecutionToolResultContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BashCodeExecutionToolResultContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResult!, typeInfo);
            }
            else if (value.IsTextEditorCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEditorCodeExecutionToolResultContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEditorCodeExecutionToolResultContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEditorCodeExecutionToolResultContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResult!, typeInfo);
            }
            else if (value.IsShellCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShellCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShellCallContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShellCallContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCall!, typeInfo);
            }
            else if (value.IsShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShellCallOutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShellCallOutputContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShellCallOutputContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallOutput!, typeInfo);
            }
            else if (value.IsApplyPatchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplyPatchCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplyPatchCallContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplyPatchCallContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCall!, typeInfo);
            }
            else if (value.IsApplyPatchCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ApplyPatchCallOutputContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ApplyPatchCallOutputContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ApplyPatchCallOutputContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallOutput!, typeInfo);
            }
        }
    }
}