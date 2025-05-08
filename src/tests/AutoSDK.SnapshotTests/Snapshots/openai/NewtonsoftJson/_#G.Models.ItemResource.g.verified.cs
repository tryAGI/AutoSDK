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
        public static implicit operator ItemResource(global::G.InputMessageResource value) => new ItemResource(value);

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
        public static implicit operator ItemResource(global::G.OutputMessage value) => new ItemResource(value);

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
        public static implicit operator ItemResource(global::G.FileSearchToolCall value) => new ItemResource(value);

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
        public static implicit operator ItemResource(global::G.ComputerToolCall value) => new ItemResource(value);

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
        public static implicit operator ItemResource(global::G.ComputerToolCallOutputResource value) => new ItemResource(value);

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
        public static implicit operator ItemResource(global::G.WebSearchToolCall value) => new ItemResource(value);

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
        public static implicit operator ItemResource(global::G.FunctionToolCallResource value) => new ItemResource(value);

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
        public static implicit operator ItemResource(global::G.FunctionToolCallOutputResource value) => new ItemResource(value);

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
            global::G.FunctionToolCallOutputResource? functionToolCallOutput
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            FunctionToolCallOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsOutputMessage && IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && IsFunctionToolCallOutput;
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
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionToolCallOutputResource?>.Default.Equals(FunctionToolCallOutput, other.FunctionToolCallOutput) 
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
