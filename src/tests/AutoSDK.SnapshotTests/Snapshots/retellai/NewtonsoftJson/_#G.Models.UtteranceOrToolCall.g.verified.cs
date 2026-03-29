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
        public global::G.Utterance? Value1 { get; init; }
#else
        public global::G.Utterance? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolCallInvocationUtterance? Value2 { get; init; }
#else
        public global::G.ToolCallInvocationUtterance? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolCallResultUtterance? Value3 { get; init; }
#else
        public global::G.ToolCallResultUtterance? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NodeTransitionUtterance? Value4 { get; init; }
#else
        public global::G.NodeTransitionUtterance? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DTMFUtterance? Value5 { get; init; }
#else
        public global::G.DTMFUtterance? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.Utterance value) => new UtteranceOrToolCall((global::G.Utterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Utterance?(UtteranceOrToolCall @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.Utterance? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.ToolCallInvocationUtterance value) => new UtteranceOrToolCall((global::G.ToolCallInvocationUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallInvocationUtterance?(UtteranceOrToolCall @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.ToolCallInvocationUtterance? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.ToolCallResultUtterance value) => new UtteranceOrToolCall((global::G.ToolCallResultUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallResultUtterance?(UtteranceOrToolCall @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.ToolCallResultUtterance? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.NodeTransitionUtterance value) => new UtteranceOrToolCall((global::G.NodeTransitionUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeTransitionUtterance?(UtteranceOrToolCall @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.NodeTransitionUtterance? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UtteranceOrToolCall(global::G.DTMFUtterance value) => new UtteranceOrToolCall((global::G.DTMFUtterance?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DTMFUtterance?(UtteranceOrToolCall @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(global::G.DTMFUtterance? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UtteranceOrToolCall(
            global::G.Utterance? value1,
            global::G.ToolCallInvocationUtterance? value2,
            global::G.ToolCallResultUtterance? value3,
            global::G.NodeTransitionUtterance? value4,
            global::G.DTMFUtterance? value5
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Utterance?, TResult>? value1 = null,
            global::System.Func<global::G.ToolCallInvocationUtterance?, TResult>? value2 = null,
            global::System.Func<global::G.ToolCallResultUtterance?, TResult>? value3 = null,
            global::System.Func<global::G.NodeTransitionUtterance?, TResult>? value4 = null,
            global::System.Func<global::G.DTMFUtterance?, TResult>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Utterance?>? value1 = null,
            global::System.Action<global::G.ToolCallInvocationUtterance?>? value2 = null,
            global::System.Action<global::G.ToolCallResultUtterance?>? value3 = null,
            global::System.Action<global::G.NodeTransitionUtterance?>? value4 = null,
            global::System.Action<global::G.DTMFUtterance?>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.Utterance),
                Value2,
                typeof(global::G.ToolCallInvocationUtterance),
                Value3,
                typeof(global::G.ToolCallResultUtterance),
                Value4,
                typeof(global::G.NodeTransitionUtterance),
                Value5,
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
                global::System.Collections.Generic.EqualityComparer<global::G.Utterance?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallInvocationUtterance?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallResultUtterance?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NodeTransitionUtterance?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DTMFUtterance?>.Default.Equals(Value5, other.Value5) 
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
