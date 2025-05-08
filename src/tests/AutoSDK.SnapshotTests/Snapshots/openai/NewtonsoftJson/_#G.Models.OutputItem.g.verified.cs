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
        public static implicit operator OutputItem(global::G.FileSearchToolCall value) => new OutputItem((global::G.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchToolCall?(OutputItem @this) => @this.FileSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.FileSearchToolCall? value)
        {
            FileSearchToolCall = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::G.FunctionToolCall value) => new OutputItem((global::G.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCall?(OutputItem @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.FunctionToolCall? value)
        {
            FunctionToolCall = value;
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
        public static implicit operator OutputItem(global::G.WebSearchToolCall value) => new OutputItem((global::G.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchToolCall?(OutputItem @this) => @this.WebSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.WebSearchToolCall? value)
        {
            WebSearchToolCall = value;
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
        public static implicit operator OutputItem(global::G.ComputerToolCall value) => new OutputItem((global::G.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCall?(OutputItem @this) => @this.ComputerToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::G.ComputerToolCall? value)
        {
            ComputerToolCall = value;
        }

        /// <summary>
        /// A description of the chain of thought used by a reasoning model while generating<br/>
        /// a response.
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
        public OutputItem(
            global::G.OutputMessage? message,
            global::G.FileSearchToolCall? fileSearchToolCall,
            global::G.FunctionToolCall? functionToolCall,
            global::G.WebSearchToolCall? webSearchToolCall,
            global::G.ComputerToolCall? computerToolCall,
            global::G.ReasoningItem? reasoning
            )
        {
            Message = message;
            FileSearchToolCall = fileSearchToolCall;
            FunctionToolCall = functionToolCall;
            WebSearchToolCall = webSearchToolCall;
            ComputerToolCall = computerToolCall;
            Reasoning = reasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Reasoning as object ??
            ComputerToolCall as object ??
            WebSearchToolCall as object ??
            FunctionToolCall as object ??
            FileSearchToolCall as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            FileSearchToolCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            WebSearchToolCall?.ToString() ??
            ComputerToolCall?.ToString() ??
            Reasoning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage || IsFileSearchToolCall || IsFunctionToolCall || IsWebSearchToolCall || IsComputerToolCall || IsReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputMessage?, TResult>? message = null,
            global::System.Func<global::G.FileSearchToolCall?, TResult>? fileSearchToolCall = null,
            global::System.Func<global::G.FunctionToolCall?, TResult>? functionToolCall = null,
            global::System.Func<global::G.WebSearchToolCall?, TResult>? webSearchToolCall = null,
            global::System.Func<global::G.ComputerToolCall?, TResult>? computerToolCall = null,
            global::System.Func<global::G.ReasoningItem?, TResult>? reasoning = null,
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
            else if (IsFileSearchToolCall && fileSearchToolCall != null)
            {
                return fileSearchToolCall(FileSearchToolCall!);
            }
            else if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsWebSearchToolCall && webSearchToolCall != null)
            {
                return webSearchToolCall(WebSearchToolCall!);
            }
            else if (IsComputerToolCall && computerToolCall != null)
            {
                return computerToolCall(ComputerToolCall!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputMessage?>? message = null,
            global::System.Action<global::G.FileSearchToolCall?>? fileSearchToolCall = null,
            global::System.Action<global::G.FunctionToolCall?>? functionToolCall = null,
            global::System.Action<global::G.WebSearchToolCall?>? webSearchToolCall = null,
            global::System.Action<global::G.ComputerToolCall?>? computerToolCall = null,
            global::System.Action<global::G.ReasoningItem?>? reasoning = null,
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
            else if (IsFileSearchToolCall)
            {
                fileSearchToolCall?.Invoke(FileSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsComputerToolCall)
            {
                computerToolCall?.Invoke(ComputerToolCall!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
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
                FileSearchToolCall,
                typeof(global::G.FileSearchToolCall),
                FunctionToolCall,
                typeof(global::G.FunctionToolCall),
                WebSearchToolCall,
                typeof(global::G.WebSearchToolCall),
                ComputerToolCall,
                typeof(global::G.ComputerToolCall),
                Reasoning,
                typeof(global::G.ReasoningItem),
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
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) 
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
