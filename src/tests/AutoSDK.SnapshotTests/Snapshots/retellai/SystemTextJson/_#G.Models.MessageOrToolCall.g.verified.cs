//HintName: G.Models.MessageOrToolCall.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageOrToolCall : global::System.IEquatable<MessageOrToolCall>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Message? Message { get; init; }
#else
        public global::G.Message? Message { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ToolCallInvocationMessage? Invocation { get; init; }
#else
        public global::G.ToolCallInvocationMessage? Invocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Invocation))]
#endif
        public bool IsInvocation => Invocation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolCallResultMessage? Result { get; init; }
#else
        public global::G.ToolCallResultMessage? Result { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Result))]
#endif
        public bool IsResult => Result != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NodeTransitionMessage? NodeTransition { get; init; }
#else
        public global::G.NodeTransitionMessage? NodeTransition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeTransition))]
#endif
        public bool IsNodeTransition => NodeTransition != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StateTransitionMessage? StateTransition { get; init; }
#else
        public global::G.StateTransitionMessage? StateTransition { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StateTransition))]
#endif
        public bool IsStateTransition => StateTransition != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::G.Message value) => new MessageOrToolCall((global::G.Message?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Message?(MessageOrToolCall @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.Message? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::G.ToolCallInvocationMessage value) => new MessageOrToolCall((global::G.ToolCallInvocationMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallInvocationMessage?(MessageOrToolCall @this) => @this.Invocation;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.ToolCallInvocationMessage? value)
        {
            Invocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::G.ToolCallResultMessage value) => new MessageOrToolCall((global::G.ToolCallResultMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallResultMessage?(MessageOrToolCall @this) => @this.Result;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.ToolCallResultMessage? value)
        {
            Result = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::G.NodeTransitionMessage value) => new MessageOrToolCall((global::G.NodeTransitionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeTransitionMessage?(MessageOrToolCall @this) => @this.NodeTransition;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.NodeTransitionMessage? value)
        {
            NodeTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::G.StateTransitionMessage value) => new MessageOrToolCall((global::G.StateTransitionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StateTransitionMessage?(MessageOrToolCall @this) => @this.StateTransition;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.StateTransitionMessage? value)
        {
            StateTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(
            global::G.Message? message,
            global::G.ToolCallInvocationMessage? invocation,
            global::G.ToolCallResultMessage? result,
            global::G.NodeTransitionMessage? nodeTransition,
            global::G.StateTransitionMessage? stateTransition
            )
        {
            Message = message;
            Invocation = invocation;
            Result = result;
            NodeTransition = nodeTransition;
            StateTransition = stateTransition;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StateTransition as object ??
            NodeTransition as object ??
            Result as object ??
            Invocation as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            Invocation?.ToString() ??
            Result?.ToString() ??
            NodeTransition?.ToString() ??
            StateTransition?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsInvocation && !IsResult && !IsNodeTransition && !IsStateTransition || !IsMessage && IsInvocation && !IsResult && !IsNodeTransition && !IsStateTransition || !IsMessage && !IsInvocation && IsResult && !IsNodeTransition && !IsStateTransition || !IsMessage && !IsInvocation && !IsResult && IsNodeTransition && !IsStateTransition || !IsMessage && !IsInvocation && !IsResult && !IsNodeTransition && IsStateTransition;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Message?, TResult>? message = null,
            global::System.Func<global::G.ToolCallInvocationMessage?, TResult>? invocation = null,
            global::System.Func<global::G.ToolCallResultMessage?, TResult>? result = null,
            global::System.Func<global::G.NodeTransitionMessage?, TResult>? nodeTransition = null,
            global::System.Func<global::G.StateTransitionMessage?, TResult>? stateTransition = null,
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
            else if (IsInvocation && invocation != null)
            {
                return invocation(Invocation!);
            }
            else if (IsResult && result != null)
            {
                return result(Result!);
            }
            else if (IsNodeTransition && nodeTransition != null)
            {
                return nodeTransition(NodeTransition!);
            }
            else if (IsStateTransition && stateTransition != null)
            {
                return stateTransition(StateTransition!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Message?>? message = null,
            global::System.Action<global::G.ToolCallInvocationMessage?>? invocation = null,
            global::System.Action<global::G.ToolCallResultMessage?>? result = null,
            global::System.Action<global::G.NodeTransitionMessage?>? nodeTransition = null,
            global::System.Action<global::G.StateTransitionMessage?>? stateTransition = null,
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
            else if (IsInvocation)
            {
                invocation?.Invoke(Invocation!);
            }
            else if (IsResult)
            {
                result?.Invoke(Result!);
            }
            else if (IsNodeTransition)
            {
                nodeTransition?.Invoke(NodeTransition!);
            }
            else if (IsStateTransition)
            {
                stateTransition?.Invoke(StateTransition!);
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
                typeof(global::G.Message),
                Invocation,
                typeof(global::G.ToolCallInvocationMessage),
                Result,
                typeof(global::G.ToolCallResultMessage),
                NodeTransition,
                typeof(global::G.NodeTransitionMessage),
                StateTransition,
                typeof(global::G.StateTransitionMessage),
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
        public bool Equals(MessageOrToolCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Message?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallInvocationMessage?>.Default.Equals(Invocation, other.Invocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallResultMessage?>.Default.Equals(Result, other.Result) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NodeTransitionMessage?>.Default.Equals(NodeTransition, other.NodeTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StateTransitionMessage?>.Default.Equals(StateTransition, other.StateTransition) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageOrToolCall obj1, MessageOrToolCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageOrToolCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageOrToolCall obj1, MessageOrToolCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageOrToolCall o && Equals(o);
        }
    }
}
