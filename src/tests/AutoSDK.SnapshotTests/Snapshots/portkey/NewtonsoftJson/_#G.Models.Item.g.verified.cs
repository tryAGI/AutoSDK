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
        public global::G.ComputerToolCallOutput? ComputerCallOutput { get; init; }
#else
        public global::G.ComputerToolCallOutput? ComputerCallOutput { get; }
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
        public global::G.FunctionToolCallOutput? FunctionCallOutput { get; init; }
#else
        public global::G.FunctionToolCallOutput? FunctionCallOutput { get; }
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
        public static implicit operator Item(global::G.ComputerToolCallOutput value) => new Item((global::G.ComputerToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCallOutput?(Item @this) => @this.ComputerCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.ComputerToolCallOutput? value)
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
        public static implicit operator Item(global::G.FunctionToolCallOutput value) => new Item((global::G.FunctionToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCallOutput?(Item @this) => @this.FunctionCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.FunctionToolCallOutput? value)
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
        public Item(
            global::G.InputMessage? message1,
            global::G.OutputMessage? message2,
            global::G.FileSearchToolCall? fileSearchCall,
            global::G.ComputerToolCall? computerCall,
            global::G.ComputerToolCallOutput? computerCallOutput,
            global::G.WebSearchToolCall? webSearchCall,
            global::G.FunctionToolCall? functionCall,
            global::G.FunctionToolCallOutput? functionCallOutput,
            global::G.ReasoningItem? reasoning
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Reasoning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && IsFunctionCall && !IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && IsFunctionCallOutput && !IsReasoning || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && IsReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessage?, TResult>? message1 = null,
            global::System.Func<global::G.OutputMessage?, TResult>? message2 = null,
            global::System.Func<global::G.FileSearchToolCall?, TResult>? fileSearchCall = null,
            global::System.Func<global::G.ComputerToolCall?, TResult>? computerCall = null,
            global::System.Func<global::G.ComputerToolCallOutput?, TResult>? computerCallOutput = null,
            global::System.Func<global::G.WebSearchToolCall?, TResult>? webSearchCall = null,
            global::System.Func<global::G.FunctionToolCall?, TResult>? functionCall = null,
            global::System.Func<global::G.FunctionToolCallOutput?, TResult>? functionCallOutput = null,
            global::System.Func<global::G.ReasoningItem?, TResult>? reasoning = null,
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
            global::System.Action<global::G.ComputerToolCallOutput?>? computerCallOutput = null,
            global::System.Action<global::G.WebSearchToolCall?>? webSearchCall = null,
            global::System.Action<global::G.FunctionToolCall?>? functionCall = null,
            global::System.Action<global::G.FunctionToolCallOutput?>? functionCallOutput = null,
            global::System.Action<global::G.ReasoningItem?>? reasoning = null,
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
                typeof(global::G.ComputerToolCallOutput),
                WebSearchCall,
                typeof(global::G.WebSearchToolCall),
                FunctionCall,
                typeof(global::G.FunctionToolCall),
                FunctionCallOutput,
                typeof(global::G.FunctionToolCallOutput),
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
        public bool Equals(Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessage?>.Default.Equals(Message1, other.Message1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessage?>.Default.Equals(Message2, other.Message2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCallOutput?>.Default.Equals(ComputerCallOutput, other.ComputerCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCallOutput?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) 
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
