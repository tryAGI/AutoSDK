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
        /// 
        /// </summary>
        public static implicit operator Item(global::G.InputMessage value) => new Item(value);

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
        public static implicit operator Item(global::G.OutputMessage value) => new Item(value);

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
        public static implicit operator Item(global::G.FileSearchToolCall value) => new Item(value);

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
        public static implicit operator Item(global::G.ComputerToolCall value) => new Item(value);

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
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerToolCallOutput? ComputerToolCallOutput { get; init; }
#else
        public global::G.ComputerToolCallOutput? ComputerToolCallOutput { get; }
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
        public static implicit operator Item(global::G.ComputerToolCallOutput value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCallOutput?(Item @this) => @this.ComputerToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.ComputerToolCallOutput? value)
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
        public static implicit operator Item(global::G.WebSearchToolCall value) => new Item(value);

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
        public static implicit operator Item(global::G.FunctionToolCall value) => new Item(value);

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
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionToolCallOutput? FunctionToolCallOutput { get; init; }
#else
        public global::G.FunctionToolCallOutput? FunctionToolCallOutput { get; }
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
        public static implicit operator Item(global::G.FunctionToolCallOutput value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionToolCallOutput?(Item @this) => @this.FunctionToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::G.FunctionToolCallOutput? value)
        {
            FunctionToolCallOutput = value;
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
        public static implicit operator Item(global::G.ReasoningItem value) => new Item(value);

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
            global::G.InputMessage? inputMessage,
            global::G.OutputMessage? outputMessage,
            global::G.FileSearchToolCall? fileSearchToolCall,
            global::G.ComputerToolCall? computerToolCall,
            global::G.ComputerToolCallOutput? computerToolCallOutput,
            global::G.WebSearchToolCall? webSearchToolCall,
            global::G.FunctionToolCall? functionToolCall,
            global::G.FunctionToolCallOutput? functionToolCallOutput,
            global::G.ReasoningItem? reasoning
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
            Reasoning = reasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Reasoning as object ??
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
            Reasoning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && IsReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessage?, TResult>? inputMessage = null,
            global::System.Func<global::G.OutputMessage?, TResult>? outputMessage = null,
            global::System.Func<global::G.FileSearchToolCall?, TResult>? fileSearchToolCall = null,
            global::System.Func<global::G.ComputerToolCall?, TResult>? computerToolCall = null,
            global::System.Func<global::G.ComputerToolCallOutput?, TResult>? computerToolCallOutput = null,
            global::System.Func<global::G.WebSearchToolCall?, TResult>? webSearchToolCall = null,
            global::System.Func<global::G.FunctionToolCall?, TResult>? functionToolCall = null,
            global::System.Func<global::G.FunctionToolCallOutput?, TResult>? functionToolCallOutput = null,
            global::System.Func<global::G.ReasoningItem?, TResult>? reasoning = null,
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
            global::System.Action<global::G.InputMessage?>? inputMessage = null,
            global::System.Action<global::G.OutputMessage?>? outputMessage = null,
            global::System.Action<global::G.FileSearchToolCall?>? fileSearchToolCall = null,
            global::System.Action<global::G.ComputerToolCall?>? computerToolCall = null,
            global::System.Action<global::G.ComputerToolCallOutput?>? computerToolCallOutput = null,
            global::System.Action<global::G.WebSearchToolCall?>? webSearchToolCall = null,
            global::System.Action<global::G.FunctionToolCall?>? functionToolCall = null,
            global::System.Action<global::G.FunctionToolCallOutput?>? functionToolCallOutput = null,
            global::System.Action<global::G.ReasoningItem?>? reasoning = null,
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
                InputMessage,
                typeof(global::G.InputMessage),
                OutputMessage,
                typeof(global::G.OutputMessage),
                FileSearchToolCall,
                typeof(global::G.FileSearchToolCall),
                ComputerToolCall,
                typeof(global::G.ComputerToolCall),
                ComputerToolCallOutput,
                typeof(global::G.ComputerToolCallOutput),
                WebSearchToolCall,
                typeof(global::G.WebSearchToolCall),
                FunctionToolCall,
                typeof(global::G.FunctionToolCall),
                FunctionToolCallOutput,
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
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessage?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCallOutput?>.Default.Equals(ComputerToolCallOutput, other.ComputerToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCallOutput?>.Default.Equals(FunctionToolCallOutput, other.FunctionToolCallOutput) &&
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
