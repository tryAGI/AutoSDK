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
        public object? ChatChoiceFinishReasonVariant2 { get; init; }
#else
        public object? ChatChoiceFinishReasonVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatChoiceFinishReasonVariant2))]
#endif
        public bool IsChatChoiceFinishReasonVariant2 => ChatChoiceFinishReasonVariant2 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ChatChoiceFinishReasonVariant3 { get; init; }
#else
        public object? ChatChoiceFinishReasonVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatChoiceFinishReasonVariant3))]
#endif
        public bool IsChatChoiceFinishReasonVariant3 => ChatChoiceFinishReasonVariant3 != null;
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
            object? chatChoiceFinishReasonVariant2,
            object? chatChoiceFinishReasonVariant3
            )
        {
            ChatFinishReasonEnum = chatFinishReasonEnum;
            ChatChoiceFinishReasonVariant2 = chatChoiceFinishReasonVariant2;
            ChatChoiceFinishReasonVariant3 = chatChoiceFinishReasonVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatChoiceFinishReasonVariant3 as object ??
            ChatChoiceFinishReasonVariant2 as object ??
            ChatFinishReasonEnum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatFinishReasonEnum?.ToValueString() ??
            ChatChoiceFinishReasonVariant2?.ToString() ??
            ChatChoiceFinishReasonVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatFinishReasonEnum && !IsChatChoiceFinishReasonVariant2 && !IsChatChoiceFinishReasonVariant3 || !IsChatFinishReasonEnum && IsChatChoiceFinishReasonVariant2 && !IsChatChoiceFinishReasonVariant3 || !IsChatFinishReasonEnum && !IsChatChoiceFinishReasonVariant2 && IsChatChoiceFinishReasonVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatFinishReasonEnum?, TResult>? chatFinishReasonEnum = null,
            global::System.Func<object?, TResult>? chatChoiceFinishReasonVariant2 = null,
            global::System.Func<object?, TResult>? chatChoiceFinishReasonVariant3 = null,
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
            else if (IsChatChoiceFinishReasonVariant2 && chatChoiceFinishReasonVariant2 != null)
            {
                return chatChoiceFinishReasonVariant2(ChatChoiceFinishReasonVariant2!);
            }
            else if (IsChatChoiceFinishReasonVariant3 && chatChoiceFinishReasonVariant3 != null)
            {
                return chatChoiceFinishReasonVariant3(ChatChoiceFinishReasonVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatFinishReasonEnum?>? chatFinishReasonEnum = null,
            global::System.Action<object?>? chatChoiceFinishReasonVariant2 = null,
            global::System.Action<object?>? chatChoiceFinishReasonVariant3 = null,
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
            else if (IsChatChoiceFinishReasonVariant2)
            {
                chatChoiceFinishReasonVariant2?.Invoke(ChatChoiceFinishReasonVariant2!);
            }
            else if (IsChatChoiceFinishReasonVariant3)
            {
                chatChoiceFinishReasonVariant3?.Invoke(ChatChoiceFinishReasonVariant3!);
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
                ChatChoiceFinishReasonVariant2,
                typeof(object),
                ChatChoiceFinishReasonVariant3,
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
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ChatChoiceFinishReasonVariant2, other.ChatChoiceFinishReasonVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ChatChoiceFinishReasonVariant3, other.ChatChoiceFinishReasonVariant3) 
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
