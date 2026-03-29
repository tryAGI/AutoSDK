//HintName: G.Models.ChatChoiceFinishReason.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatChoiceFinishReason : global::System.IEquatable<ChatChoiceFinishReason>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatFinishReasonEnum? ChatFinishReasonEnum { get; init; }
#else
        public global::G.ChatFinishReasonEnum? ChatFinishReasonEnum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFinishReasonEnum))]
#endif
        public bool IsChatFinishReasonEnum => ChatFinishReasonEnum != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value2 { get; init; }
#else
        public object? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
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
        public static implicit operator ChatChoiceFinishReason(global::G.ChatFinishReasonEnum value) => new ChatChoiceFinishReason((global::G.ChatFinishReasonEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatFinishReasonEnum?(ChatChoiceFinishReason @this) => @this.ChatFinishReasonEnum;

        /// <summary>
        /// 
        /// </summary>
        public ChatChoiceFinishReason(global::G.ChatFinishReasonEnum? value)
        {
            ChatFinishReasonEnum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatChoiceFinishReason(
            global::G.ChatFinishReasonEnum? chatFinishReasonEnum,
            object? value2,
            object? value3
            )
        {
            ChatFinishReasonEnum = chatFinishReasonEnum;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            ChatFinishReasonEnum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatFinishReasonEnum?.ToValueString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatFinishReasonEnum && !IsValue2 && !IsValue3 || !IsChatFinishReasonEnum && IsValue2 && !IsValue3 || !IsChatFinishReasonEnum && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatFinishReasonEnum?, TResult>? chatFinishReasonEnum = null,
            global::System.Func<object?, TResult>? value2 = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatFinishReasonEnum && chatFinishReasonEnum != null)
            {
                return chatFinishReasonEnum(ChatFinishReasonEnum!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatFinishReasonEnum?>? chatFinishReasonEnum = null,
            global::System.Action<object?>? value2 = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatFinishReasonEnum)
            {
                chatFinishReasonEnum?.Invoke(ChatFinishReasonEnum!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatFinishReasonEnum,
                typeof(global::G.ChatFinishReasonEnum),
                Value2,
                typeof(object),
                Value3,
                typeof(object),
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
        public bool Equals(ChatChoiceFinishReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatFinishReasonEnum?>.Default.Equals(ChatFinishReasonEnum, other.ChatFinishReasonEnum) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatChoiceFinishReason obj1, ChatChoiceFinishReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatChoiceFinishReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatChoiceFinishReason obj1, ChatChoiceFinishReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatChoiceFinishReason o && Equals(o);
        }
    }
}
