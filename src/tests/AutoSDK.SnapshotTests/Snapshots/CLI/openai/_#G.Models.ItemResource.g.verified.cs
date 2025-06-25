//HintName: G.Models.ItemResource.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Content item used to generate a response.
    /// </summary>
    public readonly partial struct ItemResource : global::System.IEquatable<ItemResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputMessageResource? InputMessage { get; init; }
#else
        public global::G.InputMessageResource? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.InputMessageResource value) => new ItemResource((global::G.InputMessageResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageResource?(ItemResource @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.InputMessageResource? value)
        {
            InputMessage = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.OutputMessage value) => new ItemResource((global::G.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessage?(ItemResource @this) => @this.OutputMessage;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.OutputMessage? value)
        {
            OutputMessage = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.FileSearchToolCall value) => new ItemResource((global::G.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchToolCall?(ItemResource @this) => @this.FileSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.FileSearchToolCall? value)
        {
            FileSearchToolCall = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.ComputerToolCall value) => new ItemResource((global::G.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCall?(ItemResource @this) => @this.ComputerToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.ComputerToolCall? value)
        {
            ComputerToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerToolCallOutputResource? ComputerToolCallOutput { get; init; }
#else
        public global::G.ComputerToolCallOutputResource? ComputerToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallOutput))]
#endif
        public bool IsComputerToolCallOutput => ComputerToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.ComputerToolCallOutputResource value) => new ItemResource((global::G.ComputerToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCallOutputResource?(ItemResource @this) => @this.ComputerToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.ComputerToolCallOutputResource? value)
        {
            ComputerToolCallOutput = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.WebSearchToolCall value) => new ItemResource((global::G.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchToolCall?(ItemResource @this) => @this.WebSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.WebSearchToolCall? value)
        {
            WebSearchToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionToolCallResource? FunctionToolCall { get; init; }
#else
        public global::G.FunctionToolCallResource? FunctionToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCall))]
#endif
        public bool IsFunctionToolCall => FunctionToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.FunctionToolCallResource value) => new ItemResource((global::G.FunctionToolCallResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCallResource?(ItemResource @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.FunctionToolCallResource? value)
        {
            FunctionToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionToolCallOutputResource? FunctionToolCallOutput { get; init; }
#else
        public global::G.FunctionToolCallOutputResource? FunctionToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallOutput))]
#endif
        public bool IsFunctionToolCallOutput => FunctionToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.FunctionToolCallOutputResource value) => new ItemResource((global::G.FunctionToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCallOutputResource?(ItemResource @this) => @this.FunctionToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.FunctionToolCallOutputResource? value)
        {
            FunctionToolCallOutput = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.ImageGenToolCall value) => new ItemResource((global::G.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageGenToolCall?(ItemResource @this) => @this.ImageGenToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.ImageGenToolCall? value)
        {
            ImageGenToolCall = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.CodeInterpreterToolCall value) => new ItemResource((global::G.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterToolCall?(ItemResource @this) => @this.CodeInterpreterToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.CodeInterpreterToolCall? value)
        {
            CodeInterpreterToolCall = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.LocalShellToolCall value) => new ItemResource((global::G.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalShellToolCall?(ItemResource @this) => @this.LocalShellToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.LocalShellToolCall? value)
        {
            LocalShellToolCall = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.LocalShellToolCallOutput value) => new ItemResource((global::G.LocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalShellToolCallOutput?(ItemResource @this) => @this.LocalShellToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.LocalShellToolCallOutput? value)
        {
            LocalShellToolCallOutput = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.MCPListTools value) => new ItemResource((global::G.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPListTools?(ItemResource @this) => @this.MCPListTools;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.MCPListTools? value)
        {
            MCPListTools = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.MCPApprovalRequest value) => new ItemResource((global::G.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPApprovalRequest?(ItemResource @this) => @this.MCPApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.MCPApprovalRequest? value)
        {
            MCPApprovalRequest = value;
        }

        /// <summary>
        /// A response to an MCP approval request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPApprovalResponseResource? MCPApprovalResponse { get; init; }
#else
        public global::G.MCPApprovalResponseResource? MCPApprovalResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPApprovalResponse))]
#endif
        public bool IsMCPApprovalResponse => MCPApprovalResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.MCPApprovalResponseResource value) => new ItemResource((global::G.MCPApprovalResponseResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPApprovalResponseResource?(ItemResource @this) => @this.MCPApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.MCPApprovalResponseResource? value)
        {
            MCPApprovalResponse = value;
        }

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
        public static implicit operator ItemResource(global::G.MCPToolCall value) => new ItemResource((global::G.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPToolCall?(ItemResource @this) => @this.MCPToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.MCPToolCall? value)
        {
            MCPToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(
            global::G.InputMessageResource? inputMessage,
            global::G.OutputMessage? outputMessage,
            global::G.FileSearchToolCall? fileSearchToolCall,
            global::G.ComputerToolCall? computerToolCall,
            global::G.ComputerToolCallOutputResource? computerToolCallOutput,
            global::G.WebSearchToolCall? webSearchToolCall,
            global::G.FunctionToolCallResource? functionToolCall,
            global::G.FunctionToolCallOutputResource? functionToolCallOutput,
            global::G.ImageGenToolCall? imageGenToolCall,
            global::G.CodeInterpreterToolCall? codeInterpreterToolCall,
            global::G.LocalShellToolCall? localShellToolCall,
            global::G.LocalShellToolCallOutput? localShellToolCallOutput,
            global::G.MCPListTools? mCPListTools,
            global::G.MCPApprovalRequest? mCPApprovalRequest,
            global::G.MCPApprovalResponseResource? mCPApprovalResponse,
            global::G.MCPToolCall? mCPToolCall
            )
        {
            InputMessage = inputMessage;
            OutputMessage = outputMessage;
            FileSearchToolCall = fileSearchToolCall;
            ComputerToolCall = computerToolCall;
            ComputerToolCallOutput = computerToolCallOutput;
            WebSearchToolCall = webSearchToolCall;
            FunctionToolCall = functionToolCall;
            FunctionToolCallOutput = functionToolCallOutput;
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
            FunctionToolCallOutput as object ??
            FunctionToolCall as object ??
            WebSearchToolCall as object ??
            ComputerToolCallOutput as object ??
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
            ComputerToolCallOutput?.ToString() ??
            WebSearchToolCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            FunctionToolCallOutput?.ToString() ??
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
            return IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && IsMCPApprovalRequest && !IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && IsMCPApprovalResponse && !IsMCPToolCall || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsImageGenToolCall && !IsCodeInterpreterToolCall && !IsLocalShellToolCall && !IsLocalShellToolCallOutput && !IsMCPListTools && !IsMCPApprovalRequest && !IsMCPApprovalResponse && IsMCPToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessageResource?, TResult>? inputMessage = null,
            global::System.Func<global::G.OutputMessage?, TResult>? outputMessage = null,
            global::System.Func<global::G.FileSearchToolCall?, TResult>? fileSearchToolCall = null,
            global::System.Func<global::G.ComputerToolCall?, TResult>? computerToolCall = null,
            global::System.Func<global::G.ComputerToolCallOutputResource?, TResult>? computerToolCallOutput = null,
            global::System.Func<global::G.WebSearchToolCall?, TResult>? webSearchToolCall = null,
            global::System.Func<global::G.FunctionToolCallResource?, TResult>? functionToolCall = null,
            global::System.Func<global::G.FunctionToolCallOutputResource?, TResult>? functionToolCallOutput = null,
            global::System.Func<global::G.ImageGenToolCall?, TResult>? imageGenToolCall = null,
            global::System.Func<global::G.CodeInterpreterToolCall?, TResult>? codeInterpreterToolCall = null,
            global::System.Func<global::G.LocalShellToolCall?, TResult>? localShellToolCall = null,
            global::System.Func<global::G.LocalShellToolCallOutput?, TResult>? localShellToolCallOutput = null,
            global::System.Func<global::G.MCPListTools?, TResult>? mCPListTools = null,
            global::System.Func<global::G.MCPApprovalRequest?, TResult>? mCPApprovalRequest = null,
            global::System.Func<global::G.MCPApprovalResponseResource?, TResult>? mCPApprovalResponse = null,
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
            else if (IsComputerToolCallOutput && computerToolCallOutput != null)
            {
                return computerToolCallOutput(ComputerToolCallOutput!);
            }
            else if (IsWebSearchToolCall && webSearchToolCall != null)
            {
                return webSearchToolCall(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutput && functionToolCallOutput != null)
            {
                return functionToolCallOutput(FunctionToolCallOutput!);
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
            global::System.Action<global::G.InputMessageResource?>? inputMessage = null,
            global::System.Action<global::G.OutputMessage?>? outputMessage = null,
            global::System.Action<global::G.FileSearchToolCall?>? fileSearchToolCall = null,
            global::System.Action<global::G.ComputerToolCall?>? computerToolCall = null,
            global::System.Action<global::G.ComputerToolCallOutputResource?>? computerToolCallOutput = null,
            global::System.Action<global::G.WebSearchToolCall?>? webSearchToolCall = null,
            global::System.Action<global::G.FunctionToolCallResource?>? functionToolCall = null,
            global::System.Action<global::G.FunctionToolCallOutputResource?>? functionToolCallOutput = null,
            global::System.Action<global::G.ImageGenToolCall?>? imageGenToolCall = null,
            global::System.Action<global::G.CodeInterpreterToolCall?>? codeInterpreterToolCall = null,
            global::System.Action<global::G.LocalShellToolCall?>? localShellToolCall = null,
            global::System.Action<global::G.LocalShellToolCallOutput?>? localShellToolCallOutput = null,
            global::System.Action<global::G.MCPListTools?>? mCPListTools = null,
            global::System.Action<global::G.MCPApprovalRequest?>? mCPApprovalRequest = null,
            global::System.Action<global::G.MCPApprovalResponseResource?>? mCPApprovalResponse = null,
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
            else if (IsComputerToolCallOutput)
            {
                computerToolCallOutput?.Invoke(ComputerToolCallOutput!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutput)
            {
                functionToolCallOutput?.Invoke(FunctionToolCallOutput!);
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
                typeof(global::G.InputMessageResource),
                OutputMessage,
                typeof(global::G.OutputMessage),
                FileSearchToolCall,
                typeof(global::G.FileSearchToolCall),
                ComputerToolCall,
                typeof(global::G.ComputerToolCall),
                ComputerToolCallOutput,
                typeof(global::G.ComputerToolCallOutputResource),
                WebSearchToolCall,
                typeof(global::G.WebSearchToolCall),
                FunctionToolCall,
                typeof(global::G.FunctionToolCallResource),
                FunctionToolCallOutput,
                typeof(global::G.FunctionToolCallOutputResource),
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
                typeof(global::G.MCPApprovalResponseResource),
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
        public bool Equals(ItemResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageResource?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCallOutputResource?>.Default.Equals(ComputerToolCallOutput, other.ComputerToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCallResource?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCallOutputResource?>.Default.Equals(FunctionToolCallOutput, other.FunctionToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageGenToolCall?>.Default.Equals(ImageGenToolCall, other.ImageGenToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterToolCall, other.CodeInterpreterToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalShellToolCall?>.Default.Equals(LocalShellToolCall, other.LocalShellToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalShellToolCallOutput?>.Default.Equals(LocalShellToolCallOutput, other.LocalShellToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPListTools?>.Default.Equals(MCPListTools, other.MCPListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPApprovalRequest?>.Default.Equals(MCPApprovalRequest, other.MCPApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPApprovalResponseResource?>.Default.Equals(MCPApprovalResponse, other.MCPApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPToolCall?>.Default.Equals(MCPToolCall, other.MCPToolCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ItemResource obj1, ItemResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ItemResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ItemResource obj1, ItemResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ItemResource o && Equals(o);
        }
    }
}
