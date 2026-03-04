//HintName: G.Models.Item.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Content item used to generate a response.
    /// </summary>
    public readonly partial struct Item : global::System.IEquatable<Item>
    {
        /// <summary>
        /// A message input to the model with a role indicating instruction following<br/>
        /// hierarchy. Instructions given with the `developer` or `system` role take<br/>
        /// precedence over instructions given with the `user` role.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputMessage? Message1 { get; init; }
#else
        public global::G.InputMessage? Message1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message1))]
#endif
        public bool IsMessage1 => Message1 != null;

        /// <summary>
        /// An output message from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessage? Message2 { get; init; }
#else
        public global::G.OutputMessage? Message2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message2))]
#endif
        public bool IsMessage2 => Message2 != null;

        /// <summary>
        /// The results of a file search tool call. See the <br/>
        /// [file search guide](/docs/guides/tools-file-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FileSearchToolCall? FileSearchCall { get; init; }
#else
        public global::G.FileSearchToolCall? FileSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCall))]
#endif
        public bool IsFileSearchCall => FileSearchCall != null;

        /// <summary>
        /// A tool call to a computer use tool. See the <br/>
        /// [computer use guide](/docs/guides/tools-computer-use) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerToolCall? ComputerCall { get; init; }
#else
        public global::G.ComputerToolCall? ComputerCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCall))]
#endif
        public bool IsComputerCall => ComputerCall != null;

        /// <summary>
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerCallOutputItemParam? ComputerCallOutput { get; init; }
#else
        public global::G.ComputerCallOutputItemParam? ComputerCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCallOutput))]
#endif
        public bool IsComputerCallOutput => ComputerCallOutput != null;

        /// <summary>
        /// The results of a web search tool call. See the <br/>
        /// [web search guide](/docs/guides/tools-web-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSearchToolCall? WebSearchCall { get; init; }
#else
        public global::G.WebSearchToolCall? WebSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCall))]
#endif
        public bool IsWebSearchCall => WebSearchCall != null;

        /// <summary>
        /// A tool call to run a function. See the <br/>
        /// [function calling guide](/docs/guides/function-calling) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionToolCall? FunctionCall { get; init; }
#else
        public global::G.FunctionToolCall? FunctionCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionCallOutputItemParam? FunctionCallOutput { get; init; }
#else
        public global::G.FunctionCallOutputItemParam? FunctionCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutput))]
#endif
        public bool IsFunctionCallOutput => FunctionCallOutput != null;

        /// <summary>
        /// A description of the chain of thought used by a reasoning model while generating<br/>
        /// a response. Be sure to include these items in your `input` to the Responses API<br/>
        /// for subsequent turns of a conversation if you are manually <br/>
        /// [managing context](/docs/guides/conversation-state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReasoningItem? Reasoning { get; init; }
#else
        public global::G.ReasoningItem? Reasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        /// An image generation request made by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageGenToolCall? ImageGenerationCall { get; init; }
#else
        public global::G.ImageGenToolCall? ImageGenerationCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationCall))]
#endif
        public bool IsImageGenerationCall => ImageGenerationCall != null;

        /// <summary>
        /// A tool call to run code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterToolCall? CodeInterpreterCall { get; init; }
#else
        public global::G.CodeInterpreterToolCall? CodeInterpreterCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCall))]
#endif
        public bool IsCodeInterpreterCall => CodeInterpreterCall != null;

        /// <summary>
        /// A tool call to run a command on the local shell.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalShellToolCall? LocalShellCall { get; init; }
#else
        public global::G.LocalShellToolCall? LocalShellCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellCall))]
#endif
        public bool IsLocalShellCall => LocalShellCall != null;

        /// <summary>
        /// The output of a local shell tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalShellToolCallOutput? LocalShellCallOutput { get; init; }
#else
        public global::G.LocalShellToolCallOutput? LocalShellCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellCallOutput))]
#endif
        public bool IsLocalShellCallOutput => LocalShellCallOutput != null;

        /// <summary>
        /// A list of tools available on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPListTools? McpListTools { get; init; }
#else
        public global::G.MCPListTools? McpListTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListTools))]
#endif
        public bool IsMcpListTools => McpListTools != null;

        /// <summary>
        /// A request for human approval of a tool invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPApprovalRequest? McpApprovalRequest { get; init; }
#else
        public global::G.MCPApprovalRequest? McpApprovalRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalRequest))]
#endif
        public bool IsMcpApprovalRequest => McpApprovalRequest != null;

        /// <summary>
        /// A response to an MCP approval request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPApprovalResponse? McpApprovalResponse { get; init; }
#else
        public global::G.MCPApprovalResponse? McpApprovalResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalResponse))]
#endif
        public bool IsMcpApprovalResponse => McpApprovalResponse != null;

        /// <summary>
        /// An invocation of a tool on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPToolCall? McpCall { get; init; }
#else
        public global::G.MCPToolCall? McpCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpCall))]
#endif
        public bool IsMcpCall => McpCall != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.InputMessage value) => new Item((global::G.InputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessage?(Item @this) => @this.Message1;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.InputMessage? value)
        {
            Message1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.OutputMessage value) => new Item((global::G.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessage?(Item @this) => @this.Message2;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.OutputMessage? value)
        {
            Message2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.FileSearchToolCall value) => new Item((global::G.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchToolCall?(Item @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.FileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.ComputerToolCall value) => new Item((global::G.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCall?(Item @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.ComputerToolCall? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.ComputerCallOutputItemParam value) => new Item((global::G.ComputerCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerCallOutputItemParam?(Item @this) => @this.ComputerCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.ComputerCallOutputItemParam? value)
        {
            ComputerCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.WebSearchToolCall value) => new Item((global::G.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchToolCall?(Item @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.WebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.FunctionToolCall value) => new Item((global::G.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCall?(Item @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.FunctionToolCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.FunctionCallOutputItemParam value) => new Item((global::G.FunctionCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionCallOutputItemParam?(Item @this) => @this.FunctionCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.FunctionCallOutputItemParam? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.ReasoningItem value) => new Item((global::G.ReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReasoningItem?(Item @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.ReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.ImageGenToolCall value) => new Item((global::G.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageGenToolCall?(Item @this) => @this.ImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.ImageGenToolCall? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.CodeInterpreterToolCall value) => new Item((global::G.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterToolCall?(Item @this) => @this.CodeInterpreterCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.CodeInterpreterToolCall? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.LocalShellToolCall value) => new Item((global::G.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalShellToolCall?(Item @this) => @this.LocalShellCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.LocalShellToolCall? value)
        {
            LocalShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.LocalShellToolCallOutput value) => new Item((global::G.LocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalShellToolCallOutput?(Item @this) => @this.LocalShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.LocalShellToolCallOutput? value)
        {
            LocalShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.MCPListTools value) => new Item((global::G.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPListTools?(Item @this) => @this.McpListTools;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.MCPListTools? value)
        {
            McpListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.MCPApprovalRequest value) => new Item((global::G.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPApprovalRequest?(Item @this) => @this.McpApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.MCPApprovalRequest? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.MCPApprovalResponse value) => new Item((global::G.MCPApprovalResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPApprovalResponse?(Item @this) => @this.McpApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.MCPApprovalResponse? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.MCPToolCall value) => new Item((global::G.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPToolCall?(Item @this) => @this.McpCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.MCPToolCall? value)
        {
            McpCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Item(
            global::G.InputMessage? message1,
            global::G.OutputMessage? message2,
            global::G.FileSearchToolCall? fileSearchCall,
            global::G.ComputerToolCall? computerCall,
            global::G.ComputerCallOutputItemParam? computerCallOutput,
            global::G.WebSearchToolCall? webSearchCall,
            global::G.FunctionToolCall? functionCall,
            global::G.FunctionCallOutputItemParam? functionCallOutput,
            global::G.ReasoningItem? reasoning,
            global::G.ImageGenToolCall? imageGenerationCall,
            global::G.CodeInterpreterToolCall? codeInterpreterCall,
            global::G.LocalShellToolCall? localShellCall,
            global::G.LocalShellToolCallOutput? localShellCallOutput,
            global::G.MCPListTools? mcpListTools,
            global::G.MCPApprovalRequest? mcpApprovalRequest,
            global::G.MCPApprovalResponse? mcpApprovalResponse,
            global::G.MCPToolCall? mcpCall
            )
        {
            Message1 = message1;
            Message2 = message2;
            FileSearchCall = fileSearchCall;
            ComputerCall = computerCall;
            ComputerCallOutput = computerCallOutput;
            WebSearchCall = webSearchCall;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            Reasoning = reasoning;
            ImageGenerationCall = imageGenerationCall;
            CodeInterpreterCall = codeInterpreterCall;
            LocalShellCall = localShellCall;
            LocalShellCallOutput = localShellCallOutput;
            McpListTools = mcpListTools;
            McpApprovalRequest = mcpApprovalRequest;
            McpApprovalResponse = mcpApprovalResponse;
            McpCall = mcpCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            McpCall as object ??
            McpApprovalResponse as object ??
            McpApprovalRequest as object ??
            McpListTools as object ??
            LocalShellCallOutput as object ??
            LocalShellCall as object ??
            CodeInterpreterCall as object ??
            ImageGenerationCall as object ??
            Reasoning as object ??
            FunctionCallOutput as object ??
            FunctionCall as object ??
            WebSearchCall as object ??
            ComputerCallOutput as object ??
            ComputerCall as object ??
            FileSearchCall as object ??
            Message2 as object ??
            Message1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message1?.ToString() ??
            Message2?.ToString() ??
            FileSearchCall?.ToString() ??
            ComputerCall?.ToString() ??
            ComputerCallOutput?.ToString() ??
            WebSearchCall?.ToString() ??
            FunctionCall?.ToString() ??
            FunctionCallOutput?.ToString() ??
            Reasoning?.ToString() ??
            ImageGenerationCall?.ToString() ??
            CodeInterpreterCall?.ToString() ??
            LocalShellCall?.ToString() ??
            LocalShellCallOutput?.ToString() ??
            McpListTools?.ToString() ??
            McpApprovalRequest?.ToString() ??
            McpApprovalResponse?.ToString() ??
            McpCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && IsMcpApprovalResponse && !IsMcpCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && IsMcpCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessage?, TResult>? message1 = null,
            global::System.Func<global::G.OutputMessage?, TResult>? message2 = null,
            global::System.Func<global::G.FileSearchToolCall?, TResult>? fileSearchCall = null,
            global::System.Func<global::G.ComputerToolCall?, TResult>? computerCall = null,
            global::System.Func<global::G.ComputerCallOutputItemParam?, TResult>? computerCallOutput = null,
            global::System.Func<global::G.WebSearchToolCall?, TResult>? webSearchCall = null,
            global::System.Func<global::G.FunctionToolCall?, TResult>? functionCall = null,
            global::System.Func<global::G.FunctionCallOutputItemParam?, TResult>? functionCallOutput = null,
            global::System.Func<global::G.ReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::G.ImageGenToolCall?, TResult>? imageGenerationCall = null,
            global::System.Func<global::G.CodeInterpreterToolCall?, TResult>? codeInterpreterCall = null,
            global::System.Func<global::G.LocalShellToolCall?, TResult>? localShellCall = null,
            global::System.Func<global::G.LocalShellToolCallOutput?, TResult>? localShellCallOutput = null,
            global::System.Func<global::G.MCPListTools?, TResult>? mcpListTools = null,
            global::System.Func<global::G.MCPApprovalRequest?, TResult>? mcpApprovalRequest = null,
            global::System.Func<global::G.MCPApprovalResponse?, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::G.MCPToolCall?, TResult>? mcpCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage1 && message1 != null)
            {
                return message1(Message1!);
            }
            else if (IsMessage2 && message2 != null)
            {
                return message2(Message2!);
            }
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
            }
            else if (IsComputerCallOutput && computerCallOutput != null)
            {
                return computerCallOutput(ComputerCallOutput!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }
            else if (IsFunctionCallOutput && functionCallOutput != null)
            {
                return functionCallOutput(FunctionCallOutput!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsImageGenerationCall && imageGenerationCall != null)
            {
                return imageGenerationCall(ImageGenerationCall!);
            }
            else if (IsCodeInterpreterCall && codeInterpreterCall != null)
            {
                return codeInterpreterCall(CodeInterpreterCall!);
            }
            else if (IsLocalShellCall && localShellCall != null)
            {
                return localShellCall(LocalShellCall!);
            }
            else if (IsLocalShellCallOutput && localShellCallOutput != null)
            {
                return localShellCallOutput(LocalShellCallOutput!);
            }
            else if (IsMcpListTools && mcpListTools != null)
            {
                return mcpListTools(McpListTools!);
            }
            else if (IsMcpApprovalRequest && mcpApprovalRequest != null)
            {
                return mcpApprovalRequest(McpApprovalRequest!);
            }
            else if (IsMcpApprovalResponse && mcpApprovalResponse != null)
            {
                return mcpApprovalResponse(McpApprovalResponse!);
            }
            else if (IsMcpCall && mcpCall != null)
            {
                return mcpCall(McpCall!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputMessage?>? message1 = null,
            global::System.Action<global::G.OutputMessage?>? message2 = null,
            global::System.Action<global::G.FileSearchToolCall?>? fileSearchCall = null,
            global::System.Action<global::G.ComputerToolCall?>? computerCall = null,
            global::System.Action<global::G.ComputerCallOutputItemParam?>? computerCallOutput = null,
            global::System.Action<global::G.WebSearchToolCall?>? webSearchCall = null,
            global::System.Action<global::G.FunctionToolCall?>? functionCall = null,
            global::System.Action<global::G.FunctionCallOutputItemParam?>? functionCallOutput = null,
            global::System.Action<global::G.ReasoningItem?>? reasoning = null,
            global::System.Action<global::G.ImageGenToolCall?>? imageGenerationCall = null,
            global::System.Action<global::G.CodeInterpreterToolCall?>? codeInterpreterCall = null,
            global::System.Action<global::G.LocalShellToolCall?>? localShellCall = null,
            global::System.Action<global::G.LocalShellToolCallOutput?>? localShellCallOutput = null,
            global::System.Action<global::G.MCPListTools?>? mcpListTools = null,
            global::System.Action<global::G.MCPApprovalRequest?>? mcpApprovalRequest = null,
            global::System.Action<global::G.MCPApprovalResponse?>? mcpApprovalResponse = null,
            global::System.Action<global::G.MCPToolCall?>? mcpCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage1)
            {
                message1?.Invoke(Message1!);
            }
            else if (IsMessage2)
            {
                message2?.Invoke(Message2!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerCallOutput)
            {
                computerCallOutput?.Invoke(ComputerCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsImageGenerationCall)
            {
                imageGenerationCall?.Invoke(ImageGenerationCall!);
            }
            else if (IsCodeInterpreterCall)
            {
                codeInterpreterCall?.Invoke(CodeInterpreterCall!);
            }
            else if (IsLocalShellCall)
            {
                localShellCall?.Invoke(LocalShellCall!);
            }
            else if (IsLocalShellCallOutput)
            {
                localShellCallOutput?.Invoke(LocalShellCallOutput!);
            }
            else if (IsMcpListTools)
            {
                mcpListTools?.Invoke(McpListTools!);
            }
            else if (IsMcpApprovalRequest)
            {
                mcpApprovalRequest?.Invoke(McpApprovalRequest!);
            }
            else if (IsMcpApprovalResponse)
            {
                mcpApprovalResponse?.Invoke(McpApprovalResponse!);
            }
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message1,
                typeof(global::G.InputMessage),
                Message2,
                typeof(global::G.OutputMessage),
                FileSearchCall,
                typeof(global::G.FileSearchToolCall),
                ComputerCall,
                typeof(global::G.ComputerToolCall),
                ComputerCallOutput,
                typeof(global::G.ComputerCallOutputItemParam),
                WebSearchCall,
                typeof(global::G.WebSearchToolCall),
                FunctionCall,
                typeof(global::G.FunctionToolCall),
                FunctionCallOutput,
                typeof(global::G.FunctionCallOutputItemParam),
                Reasoning,
                typeof(global::G.ReasoningItem),
                ImageGenerationCall,
                typeof(global::G.ImageGenToolCall),
                CodeInterpreterCall,
                typeof(global::G.CodeInterpreterToolCall),
                LocalShellCall,
                typeof(global::G.LocalShellToolCall),
                LocalShellCallOutput,
                typeof(global::G.LocalShellToolCallOutput),
                McpListTools,
                typeof(global::G.MCPListTools),
                McpApprovalRequest,
                typeof(global::G.MCPApprovalRequest),
                McpApprovalResponse,
                typeof(global::G.MCPApprovalResponse),
                McpCall,
                typeof(global::G.MCPToolCall),
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
        public bool Equals(Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessage?>.Default.Equals(Message1, other.Message1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessage?>.Default.Equals(Message2, other.Message2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerCallOutputItemParam?>.Default.Equals(ComputerCallOutput, other.ComputerCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionCallOutputItemParam?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageGenToolCall?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalShellToolCall?>.Default.Equals(LocalShellCall, other.LocalShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalShellToolCallOutput?>.Default.Equals(LocalShellCallOutput, other.LocalShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPListTools?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPApprovalRequest?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPApprovalResponse?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPToolCall?>.Default.Equals(McpCall, other.McpCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Item obj1, Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Item obj1, Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Item o && Equals(o);
        }
    }
}
