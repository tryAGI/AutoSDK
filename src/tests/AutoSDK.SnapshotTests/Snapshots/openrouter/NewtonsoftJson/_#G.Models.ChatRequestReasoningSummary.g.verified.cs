//HintName: G.Models.ChatRequestReasoningSummary.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatRequestReasoningSummary : global::System.IEquatable<ChatRequestReasoningSummary>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatReasoningSummaryVerbosityEnum? ChatReasoningSummaryVerbosityEnum { get; init; }
#else
        public global::G.ChatReasoningSummaryVerbosityEnum? ChatReasoningSummaryVerbosityEnum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatReasoningSummaryVerbosityEnum))]
#endif
        public bool IsChatReasoningSummaryVerbosityEnum => ChatReasoningSummaryVerbosityEnum != null;

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
        public static implicit operator ChatRequestReasoningSummary(global::G.ChatReasoningSummaryVerbosityEnum value) => new ChatRequestReasoningSummary((global::G.ChatReasoningSummaryVerbosityEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatReasoningSummaryVerbosityEnum?(ChatRequestReasoningSummary @this) => @this.ChatReasoningSummaryVerbosityEnum;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestReasoningSummary(global::G.ChatReasoningSummaryVerbosityEnum? value)
        {
            ChatReasoningSummaryVerbosityEnum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestReasoningSummary(
            global::G.ChatReasoningSummaryVerbosityEnum? chatReasoningSummaryVerbosityEnum,
            object? value2,
            object? value3
            )
        {
            ChatReasoningSummaryVerbosityEnum = chatReasoningSummaryVerbosityEnum;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            ChatReasoningSummaryVerbosityEnum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatReasoningSummaryVerbosityEnum?.ToValueString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatReasoningSummaryVerbosityEnum && !IsValue2 && !IsValue3 || !IsChatReasoningSummaryVerbosityEnum && IsValue2 && !IsValue3 || !IsChatReasoningSummaryVerbosityEnum && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatReasoningSummaryVerbosityEnum?, TResult>? chatReasoningSummaryVerbosityEnum = null,
            global::System.Func<object?, TResult>? value2 = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatReasoningSummaryVerbosityEnum && chatReasoningSummaryVerbosityEnum != null)
            {
                return chatReasoningSummaryVerbosityEnum(ChatReasoningSummaryVerbosityEnum!);
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
            global::System.Action<global::G.ChatReasoningSummaryVerbosityEnum?>? chatReasoningSummaryVerbosityEnum = null,
            global::System.Action<object?>? value2 = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatReasoningSummaryVerbosityEnum)
            {
                chatReasoningSummaryVerbosityEnum?.Invoke(ChatReasoningSummaryVerbosityEnum!);
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
                ChatReasoningSummaryVerbosityEnum,
                typeof(global::G.ChatReasoningSummaryVerbosityEnum),
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
        public bool Equals(ChatRequestReasoningSummary other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatReasoningSummaryVerbosityEnum?>.Default.Equals(ChatReasoningSummaryVerbosityEnum, other.ChatReasoningSummaryVerbosityEnum) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestReasoningSummary obj1, ChatRequestReasoningSummary obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestReasoningSummary>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestReasoningSummary obj1, ChatRequestReasoningSummary obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestReasoningSummary o && Equals(o);
        }
    }
}
