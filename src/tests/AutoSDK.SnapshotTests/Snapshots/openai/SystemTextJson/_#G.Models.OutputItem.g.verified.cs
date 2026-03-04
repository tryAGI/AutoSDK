//HintName: G.Models.OutputItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputItem : global::System.IEquatable<OutputItem>
    {
        /// <summary>
        /// An output message from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessage? Message { get; init; }
#else
        public global::G.OutputMessage? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

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
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.OutputMessage value) => new OutputItem((global::G.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessage?(OutputItem @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.OutputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.FileSearchToolCall value) => new OutputItem((global::G.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchToolCall?(OutputItem @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.FileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.FunctionToolCall value) => new OutputItem((global::G.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCall?(OutputItem @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.FunctionToolCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.WebSearchToolCall value) => new OutputItem((global::G.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchToolCall?(OutputItem @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.WebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.ComputerToolCall value) => new OutputItem((global::G.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCall?(OutputItem @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.ComputerToolCall? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.ReasoningItem value) => new OutputItem((global::G.ReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReasoningItem?(OutputItem @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.ReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.ImageGenToolCall value) => new OutputItem((global::G.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageGenToolCall?(OutputItem @this) => @this.ImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.ImageGenToolCall? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.CodeInterpreterToolCall value) => new OutputItem((global::G.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterToolCall?(OutputItem @this) => @this.CodeInterpreterCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.CodeInterpreterToolCall? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.LocalShellToolCall value) => new OutputItem((global::G.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalShellToolCall?(OutputItem @this) => @this.LocalShellCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.LocalShellToolCall? value)
        {
            LocalShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.MCPToolCall value) => new OutputItem((global::G.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPToolCall?(OutputItem @this) => @this.McpCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.MCPToolCall? value)
        {
            McpCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.MCPListTools value) => new OutputItem((global::G.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPListTools?(OutputItem @this) => @this.McpListTools;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.MCPListTools? value)
        {
            McpListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.MCPApprovalRequest value) => new OutputItem((global::G.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPApprovalRequest?(OutputItem @this) => @this.McpApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.MCPApprovalRequest? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(
            global::G.OutputMessage? message,
            global::G.FileSearchToolCall? fileSearchCall,
            global::G.FunctionToolCall? functionCall,
            global::G.WebSearchToolCall? webSearchCall,
            global::G.ComputerToolCall? computerCall,
            global::G.ReasoningItem? reasoning,
            global::G.ImageGenToolCall? imageGenerationCall,
            global::G.CodeInterpreterToolCall? codeInterpreterCall,
            global::G.LocalShellToolCall? localShellCall,
            global::G.MCPToolCall? mcpCall,
            global::G.MCPListTools? mcpListTools,
            global::G.MCPApprovalRequest? mcpApprovalRequest
            )
        {
            Message = message;
            FileSearchCall = fileSearchCall;
            FunctionCall = functionCall;
            WebSearchCall = webSearchCall;
            ComputerCall = computerCall;
            Reasoning = reasoning;
            ImageGenerationCall = imageGenerationCall;
            CodeInterpreterCall = codeInterpreterCall;
            LocalShellCall = localShellCall;
            McpCall = mcpCall;
            McpListTools = mcpListTools;
            McpApprovalRequest = mcpApprovalRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            McpApprovalRequest as object ??
            McpListTools as object ??
            McpCall as object ??
            LocalShellCall as object ??
            CodeInterpreterCall as object ??
            ImageGenerationCall as object ??
            Reasoning as object ??
            ComputerCall as object ??
            WebSearchCall as object ??
            FunctionCall as object ??
            FileSearchCall as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            FileSearchCall?.ToString() ??
            FunctionCall?.ToString() ??
            WebSearchCall?.ToString() ??
            ComputerCall?.ToString() ??
            Reasoning?.ToString() ??
            ImageGenerationCall?.ToString() ??
            CodeInterpreterCall?.ToString() ??
            LocalShellCall?.ToString() ??
            McpCall?.ToString() ??
            McpListTools?.ToString() ??
            McpApprovalRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage || IsFileSearchCall || IsFunctionCall || IsWebSearchCall || IsComputerCall || IsReasoning || IsImageGenerationCall || IsCodeInterpreterCall || IsLocalShellCall || IsMcpCall || IsMcpListTools || IsMcpApprovalRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputMessage?, TResult>? message = null,
            global::System.Func<global::G.FileSearchToolCall?, TResult>? fileSearchCall = null,
            global::System.Func<global::G.FunctionToolCall?, TResult>? functionCall = null,
            global::System.Func<global::G.WebSearchToolCall?, TResult>? webSearchCall = null,
            global::System.Func<global::G.ComputerToolCall?, TResult>? computerCall = null,
            global::System.Func<global::G.ReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::G.ImageGenToolCall?, TResult>? imageGenerationCall = null,
            global::System.Func<global::G.CodeInterpreterToolCall?, TResult>? codeInterpreterCall = null,
            global::System.Func<global::G.LocalShellToolCall?, TResult>? localShellCall = null,
            global::System.Func<global::G.MCPToolCall?, TResult>? mcpCall = null,
            global::System.Func<global::G.MCPListTools?, TResult>? mcpListTools = null,
            global::System.Func<global::G.MCPApprovalRequest?, TResult>? mcpApprovalRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
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
            else if (IsMcpCall && mcpCall != null)
            {
                return mcpCall(McpCall!);
            }
            else if (IsMcpListTools && mcpListTools != null)
            {
                return mcpListTools(McpListTools!);
            }
            else if (IsMcpApprovalRequest && mcpApprovalRequest != null)
            {
                return mcpApprovalRequest(McpApprovalRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputMessage?>? message = null,
            global::System.Action<global::G.FileSearchToolCall?>? fileSearchCall = null,
            global::System.Action<global::G.FunctionToolCall?>? functionCall = null,
            global::System.Action<global::G.WebSearchToolCall?>? webSearchCall = null,
            global::System.Action<global::G.ComputerToolCall?>? computerCall = null,
            global::System.Action<global::G.ReasoningItem?>? reasoning = null,
            global::System.Action<global::G.ImageGenToolCall?>? imageGenerationCall = null,
            global::System.Action<global::G.CodeInterpreterToolCall?>? codeInterpreterCall = null,
            global::System.Action<global::G.LocalShellToolCall?>? localShellCall = null,
            global::System.Action<global::G.MCPToolCall?>? mcpCall = null,
            global::System.Action<global::G.MCPListTools?>? mcpListTools = null,
            global::System.Action<global::G.MCPApprovalRequest?>? mcpApprovalRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
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
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
            }
            else if (IsMcpListTools)
            {
                mcpListTools?.Invoke(McpListTools!);
            }
            else if (IsMcpApprovalRequest)
            {
                mcpApprovalRequest?.Invoke(McpApprovalRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::G.OutputMessage),
                FileSearchCall,
                typeof(global::G.FileSearchToolCall),
                FunctionCall,
                typeof(global::G.FunctionToolCall),
                WebSearchCall,
                typeof(global::G.WebSearchToolCall),
                ComputerCall,
                typeof(global::G.ComputerToolCall),
                Reasoning,
                typeof(global::G.ReasoningItem),
                ImageGenerationCall,
                typeof(global::G.ImageGenToolCall),
                CodeInterpreterCall,
                typeof(global::G.CodeInterpreterToolCall),
                LocalShellCall,
                typeof(global::G.LocalShellToolCall),
                McpCall,
                typeof(global::G.MCPToolCall),
                McpListTools,
                typeof(global::G.MCPListTools),
                McpApprovalRequest,
                typeof(global::G.MCPApprovalRequest),
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
        public bool Equals(OutputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageGenToolCall?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalShellToolCall?>.Default.Equals(LocalShellCall, other.LocalShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPToolCall?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPListTools?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPApprovalRequest?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputItem obj1, OutputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputItem obj1, OutputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItem o && Equals(o);
        }
    }
}
