//HintName: G.Models.UtteranceOrToolCall.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UtteranceOrToolCall : global::System.IEquatable<UtteranceOrToolCall>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Utterance? Utterance { get; init; }
#else
        public global::G.Utterance? Utterance { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Utterance))]
#endif
        public bool IsUtterance => Utterance != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolCallInvocationUtterance? Invocation { get; init; }
#else
        public global::G.ToolCallInvocationUtterance? Invocation { get; }
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
        public global::G.ToolCallResultUtterance? Result { get; init; }
#else
        public global::G.ToolCallResultUtterance? Result { get; }
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
        public global::G.NodeTransitionUtterance? NodeTransition { get; init; }
#else
        public global::G.NodeTransitionUtterance? NodeTransition { get; }
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
        public global::G.DTMFUtterance? Dtmf { get; init; }
#else
        public global::G.DTMFUtterance? Dtmf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dtmf))]
#endif
        public bool IsDtmf => Dtmf != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.Utterance value) => new UtteranceOrToolCall((global::G.Utterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Utterance?(UtteranceOrToolCall @this) => @this.Utterance;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.Utterance? value)
        {
            Utterance = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.ToolCallInvocationUtterance value) => new UtteranceOrToolCall((global::G.ToolCallInvocationUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallInvocationUtterance?(UtteranceOrToolCall @this) => @this.Invocation;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.ToolCallInvocationUtterance? value)
        {
            Invocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.ToolCallResultUtterance value) => new UtteranceOrToolCall((global::G.ToolCallResultUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallResultUtterance?(UtteranceOrToolCall @this) => @this.Result;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.ToolCallResultUtterance? value)
        {
            Result = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.NodeTransitionUtterance value) => new UtteranceOrToolCall((global::G.NodeTransitionUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeTransitionUtterance?(UtteranceOrToolCall @this) => @this.NodeTransition;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.NodeTransitionUtterance? value)
        {
            NodeTransition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.DTMFUtterance value) => new UtteranceOrToolCall((global::G.DTMFUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DTMFUtterance?(UtteranceOrToolCall @this) => @this.Dtmf;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.DTMFUtterance? value)
        {
            Dtmf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(
            global::G.Utterance? utterance,
            global::G.ToolCallInvocationUtterance? invocation,
            global::G.ToolCallResultUtterance? result,
            global::G.NodeTransitionUtterance? nodeTransition,
            global::G.DTMFUtterance? dtmf
            )
        {
            Utterance = utterance;
            Invocation = invocation;
            Result = result;
            NodeTransition = nodeTransition;
            Dtmf = dtmf;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Dtmf as object ??
            NodeTransition as object ??
            Result as object ??
            Invocation as object ??
            Utterance as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Utterance?.ToString() ??
            Invocation?.ToString() ??
            Result?.ToString() ??
            NodeTransition?.ToString() ??
            Dtmf?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUtterance && !IsInvocation && !IsResult && !IsNodeTransition && !IsDtmf || !IsUtterance && IsInvocation && !IsResult && !IsNodeTransition && !IsDtmf || !IsUtterance && !IsInvocation && IsResult && !IsNodeTransition && !IsDtmf || !IsUtterance && !IsInvocation && !IsResult && IsNodeTransition && !IsDtmf || !IsUtterance && !IsInvocation && !IsResult && !IsNodeTransition && IsDtmf;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Utterance?, TResult>? utterance = null,
            global::System.Func<global::G.ToolCallInvocationUtterance?, TResult>? invocation = null,
            global::System.Func<global::G.ToolCallResultUtterance?, TResult>? result = null,
            global::System.Func<global::G.NodeTransitionUtterance?, TResult>? nodeTransition = null,
            global::System.Func<global::G.DTMFUtterance?, TResult>? dtmf = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUtterance && utterance != null)
            {
                return utterance(Utterance!);
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
            else if (IsDtmf && dtmf != null)
            {
                return dtmf(Dtmf!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Utterance?>? utterance = null,
            global::System.Action<global::G.ToolCallInvocationUtterance?>? invocation = null,
            global::System.Action<global::G.ToolCallResultUtterance?>? result = null,
            global::System.Action<global::G.NodeTransitionUtterance?>? nodeTransition = null,
            global::System.Action<global::G.DTMFUtterance?>? dtmf = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUtterance)
            {
                utterance?.Invoke(Utterance!);
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
            else if (IsDtmf)
            {
                dtmf?.Invoke(Dtmf!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Utterance,
                typeof(global::G.Utterance),
                Invocation,
                typeof(global::G.ToolCallInvocationUtterance),
                Result,
                typeof(global::G.ToolCallResultUtterance),
                NodeTransition,
                typeof(global::G.NodeTransitionUtterance),
                Dtmf,
                typeof(global::G.DTMFUtterance),
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
        public bool Equals(UtteranceOrToolCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Utterance?>.Default.Equals(Utterance, other.Utterance) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallInvocationUtterance?>.Default.Equals(Invocation, other.Invocation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallResultUtterance?>.Default.Equals(Result, other.Result) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NodeTransitionUtterance?>.Default.Equals(NodeTransition, other.NodeTransition) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DTMFUtterance?>.Default.Equals(Dtmf, other.Dtmf) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UtteranceOrToolCall obj1, UtteranceOrToolCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UtteranceOrToolCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UtteranceOrToolCall obj1, UtteranceOrToolCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UtteranceOrToolCall o && Equals(o);
        }
    }
}
