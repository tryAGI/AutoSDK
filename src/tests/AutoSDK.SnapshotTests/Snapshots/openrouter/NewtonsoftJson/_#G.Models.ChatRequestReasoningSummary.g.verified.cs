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
        public object? ChatRequestReasoningSummaryVariant2 { get; init; }
#else
        public object? ChatRequestReasoningSummaryVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestReasoningSummaryVariant2))]
#endif
        public bool IsChatRequestReasoningSummaryVariant2 => ChatRequestReasoningSummaryVariant2 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ChatRequestReasoningSummaryVariant3 { get; init; }
#else
        public object? ChatRequestReasoningSummaryVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestReasoningSummaryVariant3))]
#endif
        public bool IsChatRequestReasoningSummaryVariant3 => ChatRequestReasoningSummaryVariant3 != null;
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
            object? chatRequestReasoningSummaryVariant2,
            object? chatRequestReasoningSummaryVariant3
            )
        {
            ChatReasoningSummaryVerbosityEnum = chatReasoningSummaryVerbosityEnum;
            ChatRequestReasoningSummaryVariant2 = chatRequestReasoningSummaryVariant2;
            ChatRequestReasoningSummaryVariant3 = chatRequestReasoningSummaryVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatRequestReasoningSummaryVariant3 as object ??
            ChatRequestReasoningSummaryVariant2 as object ??
            ChatReasoningSummaryVerbosityEnum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatReasoningSummaryVerbosityEnum?.ToValueString() ??
            ChatRequestReasoningSummaryVariant2?.ToString() ??
            ChatRequestReasoningSummaryVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatReasoningSummaryVerbosityEnum && !IsChatRequestReasoningSummaryVariant2 && !IsChatRequestReasoningSummaryVariant3 || !IsChatReasoningSummaryVerbosityEnum && IsChatRequestReasoningSummaryVariant2 && !IsChatRequestReasoningSummaryVariant3 || !IsChatReasoningSummaryVerbosityEnum && !IsChatRequestReasoningSummaryVariant2 && IsChatRequestReasoningSummaryVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatReasoningSummaryVerbosityEnum?, TResult>? chatReasoningSummaryVerbosityEnum = null,
            global::System.Func<object?, TResult>? chatRequestReasoningSummaryVariant2 = null,
            global::System.Func<object?, TResult>? chatRequestReasoningSummaryVariant3 = null,
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
            else if (IsChatRequestReasoningSummaryVariant2 && chatRequestReasoningSummaryVariant2 != null)
            {
                return chatRequestReasoningSummaryVariant2(ChatRequestReasoningSummaryVariant2!);
            }
            else if (IsChatRequestReasoningSummaryVariant3 && chatRequestReasoningSummaryVariant3 != null)
            {
                return chatRequestReasoningSummaryVariant3(ChatRequestReasoningSummaryVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatReasoningSummaryVerbosityEnum?>? chatReasoningSummaryVerbosityEnum = null,
            global::System.Action<object?>? chatRequestReasoningSummaryVariant2 = null,
            global::System.Action<object?>? chatRequestReasoningSummaryVariant3 = null,
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
            else if (IsChatRequestReasoningSummaryVariant2)
            {
                chatRequestReasoningSummaryVariant2?.Invoke(ChatRequestReasoningSummaryVariant2!);
            }
            else if (IsChatRequestReasoningSummaryVariant3)
            {
                chatRequestReasoningSummaryVariant3?.Invoke(ChatRequestReasoningSummaryVariant3!);
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
                ChatRequestReasoningSummaryVariant2,
                typeof(object),
                ChatRequestReasoningSummaryVariant3,
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
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ChatRequestReasoningSummaryVariant2, other.ChatRequestReasoningSummaryVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ChatRequestReasoningSummaryVariant3, other.ChatRequestReasoningSummaryVariant3) 
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
