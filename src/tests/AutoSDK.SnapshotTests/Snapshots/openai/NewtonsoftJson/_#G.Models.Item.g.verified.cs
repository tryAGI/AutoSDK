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
        public global::G.InputMessage? InputMessage { get; init; }
#else
        public global::G.InputMessage? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        /// An output message from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessage? OutputMessage { get; init; }
#else
        public global::G.OutputMessage? OutputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessage))]
#endif
        public bool IsOutputMessage => OutputMessage != null;

        /// <summary>
        /// The results of a file search tool call. See the <br/>
        /// [file search guide](/docs/guides/tools-file-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FileSearchToolCall? FileSearchToolCall { get; init; }
#else
        public global::G.FileSearchToolCall? FileSearchToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchToolCall))]
#endif
        public bool IsFileSearchToolCall => FileSearchToolCall != null;

        /// <summary>
        /// A tool call to a computer use tool. See the <br/>
        /// [computer use guide](/docs/guides/tools-computer-use) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerToolCall? ComputerToolCall { get; init; }
#else
        public global::G.ComputerToolCall? ComputerToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCall))]
#endif
        public bool IsComputerToolCall => ComputerToolCall != null;

        /// <summary>
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerCallOutputItemParam? ComputerCallOutputParam { get; init; }
#else
        public global::G.ComputerCallOutputItemParam? ComputerCallOutputParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCallOutputParam))]
#endif
        public bool IsComputerCallOutputParam => ComputerCallOutputParam != null;

        /// <summary>
        /// The results of a web search tool call. See the <br/>
        /// [web search guide](/docs/guides/tools-web-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSearchToolCall? WebSearchToolCall { get; init; }
#else
        public global::G.WebSearchToolCall? WebSearchToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchToolCall))]
#endif
        public bool IsWebSearchToolCall => WebSearchToolCall != null;

        /// <summary>
        /// A tool call to run a function. See the <br/>
        /// [function calling guide](/docs/guides/function-calling) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionToolCall? FunctionToolCall { get; init; }
#else
        public global::G.FunctionToolCall? FunctionToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCall))]
#endif
        public bool IsFunctionToolCall => FunctionToolCall != null;

        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionCallOutputItemParam? FunctionCallOutputParam { get; init; }
#else
        public global::G.FunctionCallOutputItemParam? FunctionCallOutputParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputParam))]
#endif
        public bool IsFunctionCallOutputParam => FunctionCallOutputParam != null;

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
        public global::G.ImageGenToolCall? ImageGenToolCall { get; init; }
#else
        public global::G.ImageGenToolCall? ImageGenToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenToolCall))]
#endif
        public bool IsImageGenToolCall => ImageGenToolCall != null;

        /// <summary>
        /// A tool call to run code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterToolCall? CodeInterpreterToolCall { get; init; }
#else
        public global::G.CodeInterpreterToolCall? CodeInterpreterToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterToolCall))]
#endif
        public bool IsCodeInterpreterToolCall => CodeInterpreterToolCall != null;

        /// <summary>
        /// A tool call to run a command on the local shell.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalShellToolCall? LocalShellToolCall { get; init; }
#else
        public global::G.LocalShellToolCall? LocalShellToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellToolCall))]
#endif
        public bool IsLocalShellToolCall => LocalShellToolCall != null;

        /// <summary>
        /// The output of a local shell tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalShellToolCallOutput? LocalShellToolCallOutput { get; init; }
#else
        public global::G.LocalShellToolCallOutput? LocalShellToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellToolCallOutput))]
#endif
        public bool IsLocalShellToolCallOutput => LocalShellToolCallOutput != null;

        /// <summary>
        /// A list of tools available on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPListTools? MCPListTools { get; init; }
#else
        public global::G.MCPListTools? MCPListTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPListTools))]
#endif
        public bool IsMCPListTools => MCPListTools != null;

        /// <summary>
        /// A request for human approval of a tool invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPApprovalRequest? MCPApprovalRequest { get; init; }
#else
        public global::G.MCPApprovalRequest? MCPApprovalRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPApprovalRequest))]
#endif
        public bool IsMCPApprovalRequest => MCPApprovalRequest != null;

        /// <summary>
        /// A response to an MCP approval request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPApprovalResponse? MCPApprovalResponse { get; init; }
#else
        public global::G.MCPApprovalResponse? MCPApprovalResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPApprovalResponse))]
#endif
        public bool IsMCPApprovalResponse => MCPApprovalResponse != null;

        /// <summary>
        /// An invocation of a tool on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPToolCall? MCPToolCall { get; init; }
#else
        public global::G.MCPToolCall? MCPToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPToolCall))]
#endif
        public bool IsMCPToolCall => MCPToolCall != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.InputMessage value) => new Item((global::G.InputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessage?(Item @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.InputMessage? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.OutputMessage value) => new Item((global::G.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessage?(Item @this) => @this.OutputMessage;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.OutputMessage? value)
        {
            OutputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.FileSearchToolCall value) => new Item((global::G.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchToolCall?(Item @this) => @this.FileSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.FileSearchToolCall? value)
        {
            FileSearchToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.ComputerToolCall value) => new Item((global::G.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCall?(Item @this) => @this.ComputerToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.ComputerToolCall? value)
        {
            ComputerToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.ComputerCallOutputItemParam value) => new Item((global::G.ComputerCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerCallOutputItemParam?(Item @this) => @this.ComputerCallOutputParam;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.ComputerCallOutputItemParam? value)
        {
            ComputerCallOutputParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.WebSearchToolCall value) => new Item((global::G.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchToolCall?(Item @this) => @this.WebSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.WebSearchToolCall? value)
        {
            WebSearchToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.FunctionToolCall value) => new Item((global::G.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCall?(Item @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.FunctionToolCall? value)
        {
            FunctionToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.FunctionCallOutputItemParam value) => new Item((global::G.FunctionCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionCallOutputItemParam?(Item @this) => @this.FunctionCallOutputParam;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.FunctionCallOutputItemParam? value)
        {
            FunctionCallOutputParam = value;
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
        public static implicit operator global::G.ImageGenToolCall?(Item @this) => @this.ImageGenToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.ImageGenToolCall? value)
        {
            ImageGenToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.CodeInterpreterToolCall value) => new Item((global::G.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterToolCall?(Item @this) => @this.CodeInterpreterToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.CodeInterpreterToolCall? value)
        {
            CodeInterpreterToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.LocalShellToolCall value) => new Item((global::G.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalShellToolCall?(Item @this) => @this.LocalShellToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.LocalShellToolCall? value)
        {
            LocalShellToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.LocalShellToolCallOutput value) => new Item((global::G.LocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalShellToolCallOutput?(Item @this) => @this.LocalShellToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.LocalShellToolCallOutput? value)
        {
            LocalShellToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.MCPListTools value) => new Item((global::G.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPListTools?(Item @this) => @this.MCPListTools;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.MCPListTools? value)
        {
            MCPListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.MCPApprovalRequest value) => new Item((global::G.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPApprovalRequest?(Item @this) => @this.MCPApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.MCPApprovalRequest? value)
        {
            MCPApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.MCPApprovalResponse value) => new Item((global::G.MCPApprovalResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPApprovalResponse?(Item @this) => @this.MCPApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.MCPApprovalResponse? value)
        {
            MCPApprovalResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::G.MCPToolCall value) => new Item((global::G.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPToolCall?(Item @this) => @this.MCPToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.MCPToolCall? value)
        {
            MCPToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Item(
            global::G.InputMessage? inputMessage,
            global::G.OutputMessage? outputMessage,
            global::G.FileSearchToolCall? fileSearchToolCall,
            global::G.ComputerToolCall? computerToolCall,
            global::G.ComputerCallOutputItemParam? computerCallOutputParam,
            global::G.WebSearchToolCall? webSearchToolCall,
            global::G.FunctionToolCall? functionToolCall,
            global::G.FunctionCallOutputItemParam? functionCallOutputParam,
            global::G.ReasoningItem? reasoning,
            global::G.ImageGenToolCall? imageGenToolCall,
            global::G.CodeInterpreterToolCall? codeInterpreterToolCall,
            global::G.LocalShellToolCall? localShellToolCall,
            global::G.LocalShellToolCallOutput? localShellToolCallOutput,
            global::G.MCPListTools? mCPListTools,
            global::G.MCPApprovalRequest? mCPApprovalRequest,
            global::G.MCPApprovalResponse? mCPApprovalResponse,
            global::G.MCPToolCall? mCPToolCall
            )
        {
            InputMessage = inputMessage;
            OutputMessage = outputMessage;
            FileSearchToolCall = fileSearchToolCall;
            ComputerToolCall = computerToolCall;
            ComputerCallOutputParam = computerCallOutputParam;
            WebSearchToolCall = webSearchToolCall;
            FunctionToolCall = functionToolCall;
            FunctionCallOutputParam = functionCallOutputParam;
            Reasoning = reasoning;
            ImageGenToolCall = imageGenToolCall;
            CodeInterpreterToolCall = codeInterpreterToolCall;
            LocalShellToolCall = localShellToolCall;
            LocalShellToolCallOutput = localShellToolCallOutput;
            MCPListTools = mCPListTools;
            MCPApprovalRequest = mCPApprovalRequest;
            MCPApprovalResponse = mCPApprovalResponse;
            MCPToolCall = mCPToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MCPToolCall as object ??
            MCPApprovalResponse as object ??
            MCPApprovalRequest as object ??
            MCPListTools as object ??
            LocalShellToolCallOutput as object ??
            LocalShellToolCall as object ??
            CodeInterpreterToolCall as object ??
            ImageGenToolCall as object ??
            Reasoning as object ??
            FunctionCallOutputParam as object ??
            FunctionToolCall as object ??
            WebSearchToolCall as object ??
            ComputerCallOutputParam as object ??
            ComputerToolCall as object ??
            FileSearchToolCall as object ??
            OutputMessage as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            OutputMessage?.ToString() ??
            FileSearchToolCall?.ToString() ??
            ComputerToolCall?.ToString() ??
            ComputerCallOutputParam?.ToString() ??
            WebSearchToolCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            FunctionCallOutputParam?.ToString() ??
            Reasoning?.ToString() ??
            ImageGenToolCall?.ToString() ??
            CodeInterpreterToolCall?.ToString() ??
            LocalShellToolCall?.ToString() ??
            LocalShellToolCallOutput?.ToString() ??
            MCPListTools?.ToString() ??
            MCPApprovalRequest?.ToString() ??
            MCPApprovalResponse?.ToString() ??
            MCPToolCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerCallOutputParam && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionCallOutputParam && !IsReasoning && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && IsMCPToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessage?, TResult>? inputMessage = null,
            global::System.Func<global::G.OutputMessage?, TResult>? outputMessage = null,
            global::System.Func<global::G.FileSearchToolCall?, TResult>? fileSearchToolCall = null,
            global::System.Func<global::G.ComputerToolCall?, TResult>? computerToolCall = null,
            global::System.Func<global::G.ComputerCallOutputItemParam?, TResult>? computerCallOutputParam = null,
            global::System.Func<global::G.WebSearchToolCall?, TResult>? webSearchToolCall = null,
            global::System.Func<global::G.FunctionToolCall?, TResult>? functionToolCall = null,
            global::System.Func<global::G.FunctionCallOutputItemParam?, TResult>? functionCallOutputParam = null,
            global::System.Func<global::G.ReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::G.ImageGenToolCall?, TResult>? imageGenToolCall = null,
            global::System.Func<global::G.CodeInterpreterToolCall?, TResult>? codeInterpreterToolCall = null,
            global::System.Func<global::G.LocalShellToolCall?, TResult>? localShellToolCall = null,
            global::System.Func<global::G.LocalShellToolCallOutput?, TResult>? localShellToolCallOutput = null,
            global::System.Func<global::G.MCPListTools?, TResult>? mCPListTools = null,
            global::System.Func<global::G.MCPApprovalRequest?, TResult>? mCPApprovalRequest = null,
            global::System.Func<global::G.MCPApprovalResponse?, TResult>? mCPApprovalResponse = null,
            global::System.Func<global::G.MCPToolCall?, TResult>? mCPToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage && inputMessage != null)
            {
                return inputMessage(InputMessage!);
            }
            else if (IsOutputMessage && outputMessage != null)
            {
                return outputMessage(OutputMessage!);
            }
            else if (IsFileSearchToolCall && fileSearchToolCall != null)
            {
                return fileSearchToolCall(FileSearchToolCall!);
            }
            else if (IsComputerToolCall && computerToolCall != null)
            {
                return computerToolCall(ComputerToolCall!);
            }
            else if (IsComputerCallOutputParam && computerCallOutputParam != null)
            {
                return computerCallOutputParam(ComputerCallOutputParam!);
            }
            else if (IsWebSearchToolCall && webSearchToolCall != null)
            {
                return webSearchToolCall(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsFunctionCallOutputParam && functionCallOutputParam != null)
            {
                return functionCallOutputParam(FunctionCallOutputParam!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsImageGenToolCall && imageGenToolCall != null)
            {
                return imageGenToolCall(ImageGenToolCall!);
            }
            else if (IsCodeInterpreterToolCall && codeInterpreterToolCall != null)
            {
                return codeInterpreterToolCall(CodeInterpreterToolCall!);
            }
            else if (IsLocalShellToolCall && localShellToolCall != null)
            {
                return localShellToolCall(LocalShellToolCall!);
            }
            else if (IsLocalShellToolCallOutput && localShellToolCallOutput != null)
            {
                return localShellToolCallOutput(LocalShellToolCallOutput!);
            }
            else if (IsMCPListTools && mCPListTools != null)
            {
                return mCPListTools(MCPListTools!);
            }
            else if (IsMCPApprovalRequest && mCPApprovalRequest != null)
            {
                return mCPApprovalRequest(MCPApprovalRequest!);
            }
            else if (IsMCPApprovalResponse && mCPApprovalResponse != null)
            {
                return mCPApprovalResponse(MCPApprovalResponse!);
            }
            else if (IsMCPToolCall && mCPToolCall != null)
            {
                return mCPToolCall(MCPToolCall!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputMessage?>? inputMessage = null,
            global::System.Action<global::G.OutputMessage?>? outputMessage = null,
            global::System.Action<global::G.FileSearchToolCall?>? fileSearchToolCall = null,
            global::System.Action<global::G.ComputerToolCall?>? computerToolCall = null,
            global::System.Action<global::G.ComputerCallOutputItemParam?>? computerCallOutputParam = null,
            global::System.Action<global::G.WebSearchToolCall?>? webSearchToolCall = null,
            global::System.Action<global::G.FunctionToolCall?>? functionToolCall = null,
            global::System.Action<global::G.FunctionCallOutputItemParam?>? functionCallOutputParam = null,
            global::System.Action<global::G.ReasoningItem?>? reasoning = null,
            global::System.Action<global::G.ImageGenToolCall?>? imageGenToolCall = null,
            global::System.Action<global::G.CodeInterpreterToolCall?>? codeInterpreterToolCall = null,
            global::System.Action<global::G.LocalShellToolCall?>? localShellToolCall = null,
            global::System.Action<global::G.LocalShellToolCallOutput?>? localShellToolCallOutput = null,
            global::System.Action<global::G.MCPListTools?>? mCPListTools = null,
            global::System.Action<global::G.MCPApprovalRequest?>? mCPApprovalRequest = null,
            global::System.Action<global::G.MCPApprovalResponse?>? mCPApprovalResponse = null,
            global::System.Action<global::G.MCPToolCall?>? mCPToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsOutputMessage)
            {
                outputMessage?.Invoke(OutputMessage!);
            }
            else if (IsFileSearchToolCall)
            {
                fileSearchToolCall?.Invoke(FileSearchToolCall!);
            }
            else if (IsComputerToolCall)
            {
                computerToolCall?.Invoke(ComputerToolCall!);
            }
            else if (IsComputerCallOutputParam)
            {
                computerCallOutputParam?.Invoke(ComputerCallOutputParam!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsFunctionCallOutputParam)
            {
                functionCallOutputParam?.Invoke(FunctionCallOutputParam!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsImageGenToolCall)
            {
                imageGenToolCall?.Invoke(ImageGenToolCall!);
            }
            else if (IsCodeInterpreterToolCall)
            {
                codeInterpreterToolCall?.Invoke(CodeInterpreterToolCall!);
            }
            else if (IsLocalShellToolCall)
            {
                localShellToolCall?.Invoke(LocalShellToolCall!);
            }
            else if (IsLocalShellToolCallOutput)
            {
                localShellToolCallOutput?.Invoke(LocalShellToolCallOutput!);
            }
            else if (IsMCPListTools)
            {
                mCPListTools?.Invoke(MCPListTools!);
            }
            else if (IsMCPApprovalRequest)
            {
                mCPApprovalRequest?.Invoke(MCPApprovalRequest!);
            }
            else if (IsMCPApprovalResponse)
            {
                mCPApprovalResponse?.Invoke(MCPApprovalResponse!);
            }
            else if (IsMCPToolCall)
            {
                mCPToolCall?.Invoke(MCPToolCall!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessage,
                typeof(global::G.InputMessage),
                OutputMessage,
                typeof(global::G.OutputMessage),
                FileSearchToolCall,
                typeof(global::G.FileSearchToolCall),
                ComputerToolCall,
                typeof(global::G.ComputerToolCall),
                ComputerCallOutputParam,
                typeof(global::G.ComputerCallOutputItemParam),
                WebSearchToolCall,
                typeof(global::G.WebSearchToolCall),
                FunctionToolCall,
                typeof(global::G.FunctionToolCall),
                FunctionCallOutputParam,
                typeof(global::G.FunctionCallOutputItemParam),
                Reasoning,
                typeof(global::G.ReasoningItem),
                ImageGenToolCall,
                typeof(global::G.ImageGenToolCall),
                CodeInterpreterToolCall,
                typeof(global::G.CodeInterpreterToolCall),
                LocalShellToolCall,
                typeof(global::G.LocalShellToolCall),
                LocalShellToolCallOutput,
                typeof(global::G.LocalShellToolCallOutput),
                MCPListTools,
                typeof(global::G.MCPListTools),
                MCPApprovalRequest,
                typeof(global::G.MCPApprovalRequest),
                MCPApprovalResponse,
                typeof(global::G.MCPApprovalResponse),
                MCPToolCall,
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
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessage?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerCallOutputItemParam?>.Default.Equals(ComputerCallOutputParam, other.ComputerCallOutputParam) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionCallOutputItemParam?>.Default.Equals(FunctionCallOutputParam, other.FunctionCallOutputParam) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageGenToolCall?>.Default.Equals(ImageGenToolCall, other.ImageGenToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterToolCall, other.CodeInterpreterToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalShellToolCall?>.Default.Equals(LocalShellToolCall, other.LocalShellToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalShellToolCallOutput?>.Default.Equals(LocalShellToolCallOutput, other.LocalShellToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPListTools?>.Default.Equals(MCPListTools, other.MCPListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPApprovalRequest?>.Default.Equals(MCPApprovalRequest, other.MCPApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPApprovalResponse?>.Default.Equals(MCPApprovalResponse, other.MCPApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPToolCall?>.Default.Equals(MCPToolCall, other.MCPToolCall) 
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
