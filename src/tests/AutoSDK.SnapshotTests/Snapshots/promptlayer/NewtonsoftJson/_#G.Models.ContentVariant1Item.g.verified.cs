//HintName: G.Models.ContentVariant1Item.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant1Item : global::System.IEquatable<ContentVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssistantMessageContentVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextContent? Text { get; init; }
#else
        public global::G.TextContent? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ThinkingContent? Thinking { get; init; }
#else
        public global::G.ThinkingContent? Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        /// Code content block (e.g. from code execution tools).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeContent? Code { get; init; }
#else
        public global::G.CodeContent? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageContent? ImageUrl { get; init; }
#else
        public global::G.ImageContent? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MediaContent? Media { get; init; }
#else
        public global::G.MediaContent? Media { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Media))]
#endif
        public bool IsMedia => Media != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MediaVariable? MediaVariable { get; init; }
#else
        public global::G.MediaVariable? MediaVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MediaVariable))]
#endif
        public bool IsMediaVariable => MediaVariable != null;

        /// <summary>
        /// LLM-generated media output (e.g. from image generation tools).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMediaContent? OutputMedia { get; init; }
#else
        public global::G.OutputMediaContent? OutputMedia { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMedia))]
#endif
        public bool IsOutputMedia => OutputMedia != null;

        /// <summary>
        /// Server-side tool use block (e.g. web search, code execution).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ServerToolUseContent? ServerToolUse { get; init; }
#else
        public global::G.ServerToolUseContent? ServerToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServerToolUse))]
#endif
        public bool IsServerToolUse => ServerToolUse != null;

        /// <summary>
        /// Results from a web search tool invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSearchToolResultContent? WebSearchToolResult { get; init; }
#else
        public global::G.WebSearchToolResultContent? WebSearchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchToolResult))]
#endif
        public bool IsWebSearchToolResult => WebSearchToolResult != null;

        /// <summary>
        /// Result from a code execution tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeExecutionResultContent? CodeExecutionResult { get; init; }
#else
        public global::G.CodeExecutionResultContent? CodeExecutionResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionResult))]
#endif
        public bool IsCodeExecutionResult => CodeExecutionResult != null;

        /// <summary>
        /// MCP list tools response block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpListToolsContent? McpListTools { get; init; }
#else
        public global::G.McpListToolsContent? McpListTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListTools))]
#endif
        public bool IsMcpListTools => McpListTools != null;

        /// <summary>
        /// MCP tool call block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpCallContent? McpCall { get; init; }
#else
        public global::G.McpCallContent? McpCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpCall))]
#endif
        public bool IsMcpCall => McpCall != null;

        /// <summary>
        /// MCP tool approval request block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpApprovalRequestContent? McpApprovalRequest { get; init; }
#else
        public global::G.McpApprovalRequestContent? McpApprovalRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalRequest))]
#endif
        public bool IsMcpApprovalRequest => McpApprovalRequest != null;

        /// <summary>
        /// MCP tool approval response block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.McpApprovalResponseContent? McpApprovalResponse { get; init; }
#else
        public global::G.McpApprovalResponseContent? McpApprovalResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalResponse))]
#endif
        public bool IsMcpApprovalResponse => McpApprovalResponse != null;

        /// <summary>
        /// Result from bash code execution tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BashCodeExecutionToolResultContent? BashCodeExecutionToolResult { get; init; }
#else
        public global::G.BashCodeExecutionToolResultContent? BashCodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashCodeExecutionToolResult))]
#endif
        public bool IsBashCodeExecutionToolResult => BashCodeExecutionToolResult != null;

        /// <summary>
        /// Result from text editor code execution tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextEditorCodeExecutionToolResultContent? TextEditorCodeExecutionToolResult { get; init; }
#else
        public global::G.TextEditorCodeExecutionToolResultContent? TextEditorCodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionToolResult))]
#endif
        public bool IsTextEditorCodeExecutionToolResult => TextEditorCodeExecutionToolResult != null;

        /// <summary>
        /// Shell tool call block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShellCallContent? ShellCall { get; init; }
#else
        public global::G.ShellCallContent? ShellCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCall))]
#endif
        public bool IsShellCall => ShellCall != null;

        /// <summary>
        /// Shell tool output block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShellCallOutputContent? ShellCallOutput { get; init; }
#else
        public global::G.ShellCallOutputContent? ShellCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCallOutput))]
#endif
        public bool IsShellCallOutput => ShellCallOutput != null;

        /// <summary>
        /// Apply patch tool call block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApplyPatchCallContent? ApplyPatchCall { get; init; }
#else
        public global::G.ApplyPatchCallContent? ApplyPatchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCall))]
#endif
        public bool IsApplyPatchCall => ApplyPatchCall != null;

        /// <summary>
        /// Apply patch tool output block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApplyPatchCallOutputContent? ApplyPatchCallOutput { get; init; }
#else
        public global::G.ApplyPatchCallOutputContent? ApplyPatchCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOutput))]
#endif
        public bool IsApplyPatchCallOutput => ApplyPatchCallOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.TextContent value) => new ContentVariant1Item((global::G.TextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextContent?(ContentVariant1Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.ThinkingContent value) => new ContentVariant1Item((global::G.ThinkingContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ThinkingContent?(ContentVariant1Item @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.ThinkingContent? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.CodeContent value) => new ContentVariant1Item((global::G.CodeContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeContent?(ContentVariant1Item @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.CodeContent? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.ImageContent value) => new ContentVariant1Item((global::G.ImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageContent?(ContentVariant1Item @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.ImageContent? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.MediaContent value) => new ContentVariant1Item((global::G.MediaContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MediaContent?(ContentVariant1Item @this) => @this.Media;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.MediaContent? value)
        {
            Media = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.MediaVariable value) => new ContentVariant1Item((global::G.MediaVariable?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MediaVariable?(ContentVariant1Item @this) => @this.MediaVariable;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.MediaVariable? value)
        {
            MediaVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.OutputMediaContent value) => new ContentVariant1Item((global::G.OutputMediaContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMediaContent?(ContentVariant1Item @this) => @this.OutputMedia;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.OutputMediaContent? value)
        {
            OutputMedia = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.ServerToolUseContent value) => new ContentVariant1Item((global::G.ServerToolUseContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ServerToolUseContent?(ContentVariant1Item @this) => @this.ServerToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.ServerToolUseContent? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.WebSearchToolResultContent value) => new ContentVariant1Item((global::G.WebSearchToolResultContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchToolResultContent?(ContentVariant1Item @this) => @this.WebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.WebSearchToolResultContent? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.CodeExecutionResultContent value) => new ContentVariant1Item((global::G.CodeExecutionResultContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeExecutionResultContent?(ContentVariant1Item @this) => @this.CodeExecutionResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.CodeExecutionResultContent? value)
        {
            CodeExecutionResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.McpListToolsContent value) => new ContentVariant1Item((global::G.McpListToolsContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpListToolsContent?(ContentVariant1Item @this) => @this.McpListTools;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.McpListToolsContent? value)
        {
            McpListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.McpCallContent value) => new ContentVariant1Item((global::G.McpCallContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpCallContent?(ContentVariant1Item @this) => @this.McpCall;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.McpCallContent? value)
        {
            McpCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.McpApprovalRequestContent value) => new ContentVariant1Item((global::G.McpApprovalRequestContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpApprovalRequestContent?(ContentVariant1Item @this) => @this.McpApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.McpApprovalRequestContent? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.McpApprovalResponseContent value) => new ContentVariant1Item((global::G.McpApprovalResponseContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpApprovalResponseContent?(ContentVariant1Item @this) => @this.McpApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.McpApprovalResponseContent? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.BashCodeExecutionToolResultContent value) => new ContentVariant1Item((global::G.BashCodeExecutionToolResultContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BashCodeExecutionToolResultContent?(ContentVariant1Item @this) => @this.BashCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.BashCodeExecutionToolResultContent? value)
        {
            BashCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.TextEditorCodeExecutionToolResultContent value) => new ContentVariant1Item((global::G.TextEditorCodeExecutionToolResultContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextEditorCodeExecutionToolResultContent?(ContentVariant1Item @this) => @this.TextEditorCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.TextEditorCodeExecutionToolResultContent? value)
        {
            TextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.ShellCallContent value) => new ContentVariant1Item((global::G.ShellCallContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShellCallContent?(ContentVariant1Item @this) => @this.ShellCall;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.ShellCallContent? value)
        {
            ShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.ShellCallOutputContent value) => new ContentVariant1Item((global::G.ShellCallOutputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShellCallOutputContent?(ContentVariant1Item @this) => @this.ShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.ShellCallOutputContent? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.ApplyPatchCallContent value) => new ContentVariant1Item((global::G.ApplyPatchCallContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApplyPatchCallContent?(ContentVariant1Item @this) => @this.ApplyPatchCall;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.ApplyPatchCallContent? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::G.ApplyPatchCallOutputContent value) => new ContentVariant1Item((global::G.ApplyPatchCallOutputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApplyPatchCallOutputContent?(ContentVariant1Item @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::G.ApplyPatchCallOutputContent? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(
            global::G.AssistantMessageContentVariant1ItemDiscriminatorType? type,
            global::G.TextContent? text,
            global::G.ThinkingContent? thinking,
            global::G.CodeContent? code,
            global::G.ImageContent? imageUrl,
            global::G.MediaContent? media,
            global::G.MediaVariable? mediaVariable,
            global::G.OutputMediaContent? outputMedia,
            global::G.ServerToolUseContent? serverToolUse,
            global::G.WebSearchToolResultContent? webSearchToolResult,
            global::G.CodeExecutionResultContent? codeExecutionResult,
            global::G.McpListToolsContent? mcpListTools,
            global::G.McpCallContent? mcpCall,
            global::G.McpApprovalRequestContent? mcpApprovalRequest,
            global::G.McpApprovalResponseContent? mcpApprovalResponse,
            global::G.BashCodeExecutionToolResultContent? bashCodeExecutionToolResult,
            global::G.TextEditorCodeExecutionToolResultContent? textEditorCodeExecutionToolResult,
            global::G.ShellCallContent? shellCall,
            global::G.ShellCallOutputContent? shellCallOutput,
            global::G.ApplyPatchCallContent? applyPatchCall,
            global::G.ApplyPatchCallOutputContent? applyPatchCallOutput
            )
        {
            Type = type;

            Text = text;
            Thinking = thinking;
            Code = code;
            ImageUrl = imageUrl;
            Media = media;
            MediaVariable = mediaVariable;
            OutputMedia = outputMedia;
            ServerToolUse = serverToolUse;
            WebSearchToolResult = webSearchToolResult;
            CodeExecutionResult = codeExecutionResult;
            McpListTools = mcpListTools;
            McpCall = mcpCall;
            McpApprovalRequest = mcpApprovalRequest;
            McpApprovalResponse = mcpApprovalResponse;
            BashCodeExecutionToolResult = bashCodeExecutionToolResult;
            TextEditorCodeExecutionToolResult = textEditorCodeExecutionToolResult;
            ShellCall = shellCall;
            ShellCallOutput = shellCallOutput;
            ApplyPatchCall = applyPatchCall;
            ApplyPatchCallOutput = applyPatchCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApplyPatchCallOutput as object ??
            ApplyPatchCall as object ??
            ShellCallOutput as object ??
            ShellCall as object ??
            TextEditorCodeExecutionToolResult as object ??
            BashCodeExecutionToolResult as object ??
            McpApprovalResponse as object ??
            McpApprovalRequest as object ??
            McpCall as object ??
            McpListTools as object ??
            CodeExecutionResult as object ??
            WebSearchToolResult as object ??
            ServerToolUse as object ??
            OutputMedia as object ??
            MediaVariable as object ??
            Media as object ??
            ImageUrl as object ??
            Code as object ??
            Thinking as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Thinking?.ToString() ??
            Code?.ToString() ??
            ImageUrl?.ToString() ??
            Media?.ToString() ??
            MediaVariable?.ToString() ??
            OutputMedia?.ToString() ??
            ServerToolUse?.ToString() ??
            WebSearchToolResult?.ToString() ??
            CodeExecutionResult?.ToString() ??
            McpListTools?.ToString() ??
            McpCall?.ToString() ??
            McpApprovalRequest?.ToString() ??
            McpApprovalResponse?.ToString() ??
            BashCodeExecutionToolResult?.ToString() ??
            TextEditorCodeExecutionToolResult?.ToString() ??
            ShellCall?.ToString() ??
            ShellCallOutput?.ToString() ??
            ApplyPatchCall?.ToString() ??
            ApplyPatchCallOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && IsApplyPatchCall && !IsApplyPatchCallOutput || !IsText && !IsThinking && !IsCode && !IsImageUrl && !IsMedia && !IsMediaVariable && !IsOutputMedia && !IsServerToolUse && !IsWebSearchToolResult && !IsCodeExecutionResult && !IsMcpListTools && !IsMcpCall && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && IsApplyPatchCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextContent?, TResult>? text = null,
            global::System.Func<global::G.ThinkingContent?, TResult>? thinking = null,
            global::System.Func<global::G.CodeContent?, TResult>? code = null,
            global::System.Func<global::G.ImageContent?, TResult>? imageUrl = null,
            global::System.Func<global::G.MediaContent?, TResult>? media = null,
            global::System.Func<global::G.MediaVariable?, TResult>? mediaVariable = null,
            global::System.Func<global::G.OutputMediaContent?, TResult>? outputMedia = null,
            global::System.Func<global::G.ServerToolUseContent?, TResult>? serverToolUse = null,
            global::System.Func<global::G.WebSearchToolResultContent?, TResult>? webSearchToolResult = null,
            global::System.Func<global::G.CodeExecutionResultContent?, TResult>? codeExecutionResult = null,
            global::System.Func<global::G.McpListToolsContent?, TResult>? mcpListTools = null,
            global::System.Func<global::G.McpCallContent?, TResult>? mcpCall = null,
            global::System.Func<global::G.McpApprovalRequestContent?, TResult>? mcpApprovalRequest = null,
            global::System.Func<global::G.McpApprovalResponseContent?, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::G.BashCodeExecutionToolResultContent?, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::G.TextEditorCodeExecutionToolResultContent?, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::G.ShellCallContent?, TResult>? shellCall = null,
            global::System.Func<global::G.ShellCallOutputContent?, TResult>? shellCallOutput = null,
            global::System.Func<global::G.ApplyPatchCallContent?, TResult>? applyPatchCall = null,
            global::System.Func<global::G.ApplyPatchCallOutputContent?, TResult>? applyPatchCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsMedia && media != null)
            {
                return media(Media!);
            }
            else if (IsMediaVariable && mediaVariable != null)
            {
                return mediaVariable(MediaVariable!);
            }
            else if (IsOutputMedia && outputMedia != null)
            {
                return outputMedia(OutputMedia!);
            }
            else if (IsServerToolUse && serverToolUse != null)
            {
                return serverToolUse(ServerToolUse!);
            }
            else if (IsWebSearchToolResult && webSearchToolResult != null)
            {
                return webSearchToolResult(WebSearchToolResult!);
            }
            else if (IsCodeExecutionResult && codeExecutionResult != null)
            {
                return codeExecutionResult(CodeExecutionResult!);
            }
            else if (IsMcpListTools && mcpListTools != null)
            {
                return mcpListTools(McpListTools!);
            }
            else if (IsMcpCall && mcpCall != null)
            {
                return mcpCall(McpCall!);
            }
            else if (IsMcpApprovalRequest && mcpApprovalRequest != null)
            {
                return mcpApprovalRequest(McpApprovalRequest!);
            }
            else if (IsMcpApprovalResponse && mcpApprovalResponse != null)
            {
                return mcpApprovalResponse(McpApprovalResponse!);
            }
            else if (IsBashCodeExecutionToolResult && bashCodeExecutionToolResult != null)
            {
                return bashCodeExecutionToolResult(BashCodeExecutionToolResult!);
            }
            else if (IsTextEditorCodeExecutionToolResult && textEditorCodeExecutionToolResult != null)
            {
                return textEditorCodeExecutionToolResult(TextEditorCodeExecutionToolResult!);
            }
            else if (IsShellCall && shellCall != null)
            {
                return shellCall(ShellCall!);
            }
            else if (IsShellCallOutput && shellCallOutput != null)
            {
                return shellCallOutput(ShellCallOutput!);
            }
            else if (IsApplyPatchCall && applyPatchCall != null)
            {
                return applyPatchCall(ApplyPatchCall!);
            }
            else if (IsApplyPatchCallOutput && applyPatchCallOutput != null)
            {
                return applyPatchCallOutput(ApplyPatchCallOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextContent?>? text = null,
            global::System.Action<global::G.ThinkingContent?>? thinking = null,
            global::System.Action<global::G.CodeContent?>? code = null,
            global::System.Action<global::G.ImageContent?>? imageUrl = null,
            global::System.Action<global::G.MediaContent?>? media = null,
            global::System.Action<global::G.MediaVariable?>? mediaVariable = null,
            global::System.Action<global::G.OutputMediaContent?>? outputMedia = null,
            global::System.Action<global::G.ServerToolUseContent?>? serverToolUse = null,
            global::System.Action<global::G.WebSearchToolResultContent?>? webSearchToolResult = null,
            global::System.Action<global::G.CodeExecutionResultContent?>? codeExecutionResult = null,
            global::System.Action<global::G.McpListToolsContent?>? mcpListTools = null,
            global::System.Action<global::G.McpCallContent?>? mcpCall = null,
            global::System.Action<global::G.McpApprovalRequestContent?>? mcpApprovalRequest = null,
            global::System.Action<global::G.McpApprovalResponseContent?>? mcpApprovalResponse = null,
            global::System.Action<global::G.BashCodeExecutionToolResultContent?>? bashCodeExecutionToolResult = null,
            global::System.Action<global::G.TextEditorCodeExecutionToolResultContent?>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::G.ShellCallContent?>? shellCall = null,
            global::System.Action<global::G.ShellCallOutputContent?>? shellCallOutput = null,
            global::System.Action<global::G.ApplyPatchCallContent?>? applyPatchCall = null,
            global::System.Action<global::G.ApplyPatchCallOutputContent?>? applyPatchCallOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsMedia)
            {
                media?.Invoke(Media!);
            }
            else if (IsMediaVariable)
            {
                mediaVariable?.Invoke(MediaVariable!);
            }
            else if (IsOutputMedia)
            {
                outputMedia?.Invoke(OutputMedia!);
            }
            else if (IsServerToolUse)
            {
                serverToolUse?.Invoke(ServerToolUse!);
            }
            else if (IsWebSearchToolResult)
            {
                webSearchToolResult?.Invoke(WebSearchToolResult!);
            }
            else if (IsCodeExecutionResult)
            {
                codeExecutionResult?.Invoke(CodeExecutionResult!);
            }
            else if (IsMcpListTools)
            {
                mcpListTools?.Invoke(McpListTools!);
            }
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
            }
            else if (IsMcpApprovalRequest)
            {
                mcpApprovalRequest?.Invoke(McpApprovalRequest!);
            }
            else if (IsMcpApprovalResponse)
            {
                mcpApprovalResponse?.Invoke(McpApprovalResponse!);
            }
            else if (IsBashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult?.Invoke(BashCodeExecutionToolResult!);
            }
            else if (IsTextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult?.Invoke(TextEditorCodeExecutionToolResult!);
            }
            else if (IsShellCall)
            {
                shellCall?.Invoke(ShellCall!);
            }
            else if (IsShellCallOutput)
            {
                shellCallOutput?.Invoke(ShellCallOutput!);
            }
            else if (IsApplyPatchCall)
            {
                applyPatchCall?.Invoke(ApplyPatchCall!);
            }
            else if (IsApplyPatchCallOutput)
            {
                applyPatchCallOutput?.Invoke(ApplyPatchCallOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.TextContent),
                Thinking,
                typeof(global::G.ThinkingContent),
                Code,
                typeof(global::G.CodeContent),
                ImageUrl,
                typeof(global::G.ImageContent),
                Media,
                typeof(global::G.MediaContent),
                MediaVariable,
                typeof(global::G.MediaVariable),
                OutputMedia,
                typeof(global::G.OutputMediaContent),
                ServerToolUse,
                typeof(global::G.ServerToolUseContent),
                WebSearchToolResult,
                typeof(global::G.WebSearchToolResultContent),
                CodeExecutionResult,
                typeof(global::G.CodeExecutionResultContent),
                McpListTools,
                typeof(global::G.McpListToolsContent),
                McpCall,
                typeof(global::G.McpCallContent),
                McpApprovalRequest,
                typeof(global::G.McpApprovalRequestContent),
                McpApprovalResponse,
                typeof(global::G.McpApprovalResponseContent),
                BashCodeExecutionToolResult,
                typeof(global::G.BashCodeExecutionToolResultContent),
                TextEditorCodeExecutionToolResult,
                typeof(global::G.TextEditorCodeExecutionToolResultContent),
                ShellCall,
                typeof(global::G.ShellCallContent),
                ShellCallOutput,
                typeof(global::G.ShellCallOutputContent),
                ApplyPatchCall,
                typeof(global::G.ApplyPatchCallContent),
                ApplyPatchCallOutput,
                typeof(global::G.ApplyPatchCallOutputContent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContentVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ThinkingContent?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeContent?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageContent?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MediaContent?>.Default.Equals(Media, other.Media) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MediaVariable?>.Default.Equals(MediaVariable, other.MediaVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMediaContent?>.Default.Equals(OutputMedia, other.OutputMedia) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ServerToolUseContent?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolResultContent?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeExecutionResultContent?>.Default.Equals(CodeExecutionResult, other.CodeExecutionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpListToolsContent?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpCallContent?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpApprovalRequestContent?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpApprovalResponseContent?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BashCodeExecutionToolResultContent?>.Default.Equals(BashCodeExecutionToolResult, other.BashCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextEditorCodeExecutionToolResultContent?>.Default.Equals(TextEditorCodeExecutionToolResult, other.TextEditorCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ShellCallContent?>.Default.Equals(ShellCall, other.ShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ShellCallOutputContent?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ApplyPatchCallContent?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ApplyPatchCallOutputContent?>.Default.Equals(ApplyPatchCallOutput, other.ApplyPatchCallOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant1Item obj1, ContentVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant1Item obj1, ContentVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant1Item o && Equals(o);
        }
    }
}
