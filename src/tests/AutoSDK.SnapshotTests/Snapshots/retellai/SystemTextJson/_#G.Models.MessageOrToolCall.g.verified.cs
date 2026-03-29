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
        public global::G.Message? Value1 { get; init; }
#else
        public global::G.Message? Value1 { get; }
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
        public global::G.ToolCallInvocationMessage? Value2 { get; init; }
#else
        public global::G.ToolCallInvocationMessage? Value2 { get; }
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
        public global::G.ToolCallResultMessage? Value3 { get; init; }
#else
        public global::G.ToolCallResultMessage? Value3 { get; }
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
        public global::G.NodeTransitionMessage? Value4 { get; init; }
#else
        public global::G.NodeTransitionMessage? Value4 { get; }
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
        public global::G.StateTransitionMessage? Value5 { get; init; }
#else
        public global::G.StateTransitionMessage? Value5 { get; }
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
        public static implicit operator MessageOrToolCall(global::G.Message value) => new MessageOrToolCall((global::G.Message?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Message?(MessageOrToolCall @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.Message? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::G.ToolCallInvocationMessage value) => new MessageOrToolCall((global::G.ToolCallInvocationMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallInvocationMessage?(MessageOrToolCall @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.ToolCallInvocationMessage? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::G.ToolCallResultMessage value) => new MessageOrToolCall((global::G.ToolCallResultMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCallResultMessage?(MessageOrToolCall @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.ToolCallResultMessage? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::G.NodeTransitionMessage value) => new MessageOrToolCall((global::G.NodeTransitionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeTransitionMessage?(MessageOrToolCall @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.NodeTransitionMessage? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageOrToolCall(global::G.StateTransitionMessage value) => new MessageOrToolCall((global::G.StateTransitionMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StateTransitionMessage?(MessageOrToolCall @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(global::G.StateTransitionMessage? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageOrToolCall(
            global::G.Message? value1,
            global::G.ToolCallInvocationMessage? value2,
            global::G.ToolCallResultMessage? value3,
            global::G.NodeTransitionMessage? value4,
            global::G.StateTransitionMessage? value5
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
            global::System.Func<global::G.Message?, TResult>? value1 = null,
            global::System.Func<global::G.ToolCallInvocationMessage?, TResult>? value2 = null,
            global::System.Func<global::G.ToolCallResultMessage?, TResult>? value3 = null,
            global::System.Func<global::G.NodeTransitionMessage?, TResult>? value4 = null,
            global::System.Func<global::G.StateTransitionMessage?, TResult>? value5 = null,
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
            global::System.Action<global::G.Message?>? value1 = null,
            global::System.Action<global::G.ToolCallInvocationMessage?>? value2 = null,
            global::System.Action<global::G.ToolCallResultMessage?>? value3 = null,
            global::System.Action<global::G.NodeTransitionMessage?>? value4 = null,
            global::System.Action<global::G.StateTransitionMessage?>? value5 = null,
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
                typeof(global::G.Message),
                Value2,
                typeof(global::G.ToolCallInvocationMessage),
                Value3,
                typeof(global::G.ToolCallResultMessage),
                Value4,
                typeof(global::G.NodeTransitionMessage),
                Value5,
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
                global::System.Collections.Generic.EqualityComparer<global::G.Message?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallInvocationMessage?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCallResultMessage?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NodeTransitionMessage?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StateTransitionMessage?>.Default.Equals(Value5, other.Value5) 
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
