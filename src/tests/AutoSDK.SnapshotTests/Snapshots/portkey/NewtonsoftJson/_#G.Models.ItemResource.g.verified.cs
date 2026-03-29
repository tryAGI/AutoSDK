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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.OutputMessage value) => new ItemResource((global::G.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessage?(ItemResource @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.OutputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.FileSearchToolCall value) => new ItemResource((global::G.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchToolCall?(ItemResource @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.FileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.ComputerToolCall value) => new ItemResource((global::G.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCall?(ItemResource @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.ComputerToolCall? value)
        {
            ComputerCall = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::G.WebSearchToolCall value) => new ItemResource((global::G.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchToolCall?(ItemResource @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::G.WebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

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
        /// 
        /// </summary>
        public ItemResource(
            global::G.InputMessageResource? inputMessage,
            global::G.OutputMessage? message,
            global::G.FileSearchToolCall? fileSearchCall,
            global::G.ComputerToolCall? computerCall,
            global::G.ComputerToolCallOutputResource? computerToolCallOutput,
            global::G.WebSearchToolCall? webSearchCall,
            global::G.FunctionToolCallResource? functionToolCall,
            global::G.FunctionToolCallOutputResource? functionToolCallOutput
            )
        {
            InputMessage = inputMessage;
            Message = message;
            FileSearchCall = fileSearchCall;
            ComputerCall = computerCall;
            ComputerToolCallOutput = computerToolCallOutput;
            WebSearchCall = webSearchCall;
            FunctionToolCall = functionToolCall;
            FunctionToolCallOutput = functionToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionToolCallOutput as object ??
            FunctionToolCall as object ??
            WebSearchCall as object ??
            ComputerToolCallOutput as object ??
            ComputerCall as object ??
            FileSearchCall as object ??
            Message as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            Message?.ToString() ??
            FileSearchCall?.ToString() ??
            ComputerCall?.ToString() ??
            ComputerToolCallOutput?.ToString() ??
            WebSearchCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            FunctionToolCallOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && IsWebSearchCall && !IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && IsFunctionToolCall && !IsFunctionToolCallOutput || !IsInputMessage && !IsMessage && !IsFileSearchCall && !IsComputerCall && !IsComputerToolCallOutput && !IsWebSearchCall && !IsFunctionToolCall && IsFunctionToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputMessageResource?, TResult>? inputMessage = null,
            global::System.Func<global::G.OutputMessage?, TResult>? message = null,
            global::System.Func<global::G.FileSearchToolCall?, TResult>? fileSearchCall = null,
            global::System.Func<global::G.ComputerToolCall?, TResult>? computerCall = null,
            global::System.Func<global::G.ComputerToolCallOutputResource?, TResult>? computerToolCallOutput = null,
            global::System.Func<global::G.WebSearchToolCall?, TResult>? webSearchCall = null,
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
            else if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
            }
            else if (IsComputerToolCallOutput && computerToolCallOutput != null)
            {
                return computerToolCallOutput(ComputerToolCallOutput!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
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
            global::System.Action<global::G.OutputMessage?>? message = null,
            global::System.Action<global::G.FileSearchToolCall?>? fileSearchCall = null,
            global::System.Action<global::G.ComputerToolCall?>? computerCall = null,
            global::System.Action<global::G.ComputerToolCallOutputResource?>? computerToolCallOutput = null,
            global::System.Action<global::G.WebSearchToolCall?>? webSearchCall = null,
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
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerToolCallOutput)
            {
                computerToolCallOutput?.Invoke(ComputerToolCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
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
                Message,
                typeof(global::G.OutputMessage),
                FileSearchCall,
                typeof(global::G.FileSearchToolCall),
                ComputerCall,
                typeof(global::G.ComputerToolCall),
                ComputerToolCallOutput,
                typeof(global::G.ComputerToolCallOutputResource),
                WebSearchCall,
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
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCallOutputResource?>.Default.Equals(ComputerToolCallOutput, other.ComputerToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
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
