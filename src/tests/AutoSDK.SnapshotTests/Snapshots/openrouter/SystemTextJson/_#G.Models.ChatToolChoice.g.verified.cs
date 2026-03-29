//HintName: G.Models.ChatToolChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Tool choice configuration
    /// </summary>
    public readonly partial struct ChatToolChoice : global::System.IEquatable<ChatToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolChoice0? ChatToolChoice0 { get; init; }
#else
        public global::G.ChatToolChoice0? ChatToolChoice0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolChoice0))]
#endif
        public bool IsChatToolChoice0 => ChatToolChoice0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolChoice1? ChatToolChoice1 { get; init; }
#else
        public global::G.ChatToolChoice1? ChatToolChoice1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolChoice1))]
#endif
        public bool IsChatToolChoice1 => ChatToolChoice1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatToolChoice2? ChatToolChoice2 { get; init; }
#else
        public global::G.ChatToolChoice2? ChatToolChoice2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolChoice2))]
#endif
        public bool IsChatToolChoice2 => ChatToolChoice2 != null;

        /// <summary>
        /// Named tool choice for specific function
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatNamedToolChoice? ChatNamedToolChoice { get; init; }
#else
        public global::G.ChatNamedToolChoice? ChatNamedToolChoice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatNamedToolChoice))]
#endif
        public bool IsChatNamedToolChoice => ChatNamedToolChoice != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolChoice(global::G.ChatToolChoice0 value) => new ChatToolChoice((global::G.ChatToolChoice0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolChoice0?(ChatToolChoice @this) => @this.ChatToolChoice0;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(global::G.ChatToolChoice0? value)
        {
            ChatToolChoice0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolChoice(global::G.ChatToolChoice1 value) => new ChatToolChoice((global::G.ChatToolChoice1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolChoice1?(ChatToolChoice @this) => @this.ChatToolChoice1;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(global::G.ChatToolChoice1? value)
        {
            ChatToolChoice1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolChoice(global::G.ChatToolChoice2 value) => new ChatToolChoice((global::G.ChatToolChoice2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatToolChoice2?(ChatToolChoice @this) => @this.ChatToolChoice2;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(global::G.ChatToolChoice2? value)
        {
            ChatToolChoice2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolChoice(global::G.ChatNamedToolChoice value) => new ChatToolChoice((global::G.ChatNamedToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatNamedToolChoice?(ChatToolChoice @this) => @this.ChatNamedToolChoice;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(global::G.ChatNamedToolChoice? value)
        {
            ChatNamedToolChoice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(
            global::G.ChatToolChoice0? chatToolChoice0,
            global::G.ChatToolChoice1? chatToolChoice1,
            global::G.ChatToolChoice2? chatToolChoice2,
            global::G.ChatNamedToolChoice? chatNamedToolChoice
            )
        {
            ChatToolChoice0 = chatToolChoice0;
            ChatToolChoice1 = chatToolChoice1;
            ChatToolChoice2 = chatToolChoice2;
            ChatNamedToolChoice = chatNamedToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatNamedToolChoice as object ??
            ChatToolChoice2 as object ??
            ChatToolChoice1 as object ??
            ChatToolChoice0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatToolChoice0?.ToValueString() ??
            ChatToolChoice1?.ToValueString() ??
            ChatToolChoice2?.ToValueString() ??
            ChatNamedToolChoice?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatToolChoice0 && !IsChatToolChoice1 && !IsChatToolChoice2 && !IsChatNamedToolChoice || !IsChatToolChoice0 && IsChatToolChoice1 && !IsChatToolChoice2 && !IsChatNamedToolChoice || !IsChatToolChoice0 && !IsChatToolChoice1 && IsChatToolChoice2 && !IsChatNamedToolChoice || !IsChatToolChoice0 && !IsChatToolChoice1 && !IsChatToolChoice2 && IsChatNamedToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatToolChoice0?, TResult>? chatToolChoice0 = null,
            global::System.Func<global::G.ChatToolChoice1?, TResult>? chatToolChoice1 = null,
            global::System.Func<global::G.ChatToolChoice2?, TResult>? chatToolChoice2 = null,
            global::System.Func<global::G.ChatNamedToolChoice?, TResult>? chatNamedToolChoice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatToolChoice0 && chatToolChoice0 != null)
            {
                return chatToolChoice0(ChatToolChoice0!);
            }
            else if (IsChatToolChoice1 && chatToolChoice1 != null)
            {
                return chatToolChoice1(ChatToolChoice1!);
            }
            else if (IsChatToolChoice2 && chatToolChoice2 != null)
            {
                return chatToolChoice2(ChatToolChoice2!);
            }
            else if (IsChatNamedToolChoice && chatNamedToolChoice != null)
            {
                return chatNamedToolChoice(ChatNamedToolChoice!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatToolChoice0?>? chatToolChoice0 = null,
            global::System.Action<global::G.ChatToolChoice1?>? chatToolChoice1 = null,
            global::System.Action<global::G.ChatToolChoice2?>? chatToolChoice2 = null,
            global::System.Action<global::G.ChatNamedToolChoice?>? chatNamedToolChoice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatToolChoice0)
            {
                chatToolChoice0?.Invoke(ChatToolChoice0!);
            }
            else if (IsChatToolChoice1)
            {
                chatToolChoice1?.Invoke(ChatToolChoice1!);
            }
            else if (IsChatToolChoice2)
            {
                chatToolChoice2?.Invoke(ChatToolChoice2!);
            }
            else if (IsChatNamedToolChoice)
            {
                chatNamedToolChoice?.Invoke(ChatNamedToolChoice!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatToolChoice0,
                typeof(global::G.ChatToolChoice0),
                ChatToolChoice1,
                typeof(global::G.ChatToolChoice1),
                ChatToolChoice2,
                typeof(global::G.ChatToolChoice2),
                ChatNamedToolChoice,
                typeof(global::G.ChatNamedToolChoice),
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
        public bool Equals(ChatToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolChoice0?>.Default.Equals(ChatToolChoice0, other.ChatToolChoice0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolChoice1?>.Default.Equals(ChatToolChoice1, other.ChatToolChoice1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatToolChoice2?>.Default.Equals(ChatToolChoice2, other.ChatToolChoice2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatNamedToolChoice?>.Default.Equals(ChatNamedToolChoice, other.ChatNamedToolChoice) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolChoice obj1, ChatToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolChoice obj1, ChatToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolChoice o && Equals(o);
        }
    }
}
