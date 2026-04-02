//HintName: G.Models.ChatAssistantMessageContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Assistant message content
    /// </summary>
    public readonly partial struct ChatAssistantMessageContent : global::System.IEquatable<ChatAssistantMessageContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatAssistantMessageContentVariant1 { get; init; }
#else
        public string? ChatAssistantMessageContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatAssistantMessageContentVariant1))]
#endif
        public bool IsChatAssistantMessageContentVariant1 => ChatAssistantMessageContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.ChatContentItems>? ChatAssistantMessageContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ChatContentItems>? ChatAssistantMessageContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatAssistantMessageContent1))]
#endif
        public bool IsChatAssistantMessageContent1 => ChatAssistantMessageContent1 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ChatAssistantMessageContentVariant3 { get; init; }
#else
        public object? ChatAssistantMessageContentVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatAssistantMessageContentVariant3))]
#endif
        public bool IsChatAssistantMessageContentVariant3 => ChatAssistantMessageContentVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatAssistantMessageContent(string value) => new ChatAssistantMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatAssistantMessageContent @this) => @this.ChatAssistantMessageContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatAssistantMessageContent(string? value)
        {
            ChatAssistantMessageContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatAssistantMessageContent(
            string? chatAssistantMessageContentVariant1,
            global::System.Collections.Generic.IList<global::G.ChatContentItems>? chatAssistantMessageContent1,
            object? chatAssistantMessageContentVariant3
            )
        {
            ChatAssistantMessageContentVariant1 = chatAssistantMessageContentVariant1;
            ChatAssistantMessageContent1 = chatAssistantMessageContent1;
            ChatAssistantMessageContentVariant3 = chatAssistantMessageContentVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatAssistantMessageContentVariant3 as object ??
            ChatAssistantMessageContent1 as object ??
            ChatAssistantMessageContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatAssistantMessageContentVariant1?.ToString() ??
            ChatAssistantMessageContent1?.ToString() ??
            ChatAssistantMessageContentVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatAssistantMessageContentVariant1 && !IsChatAssistantMessageContent1 && !IsChatAssistantMessageContentVariant3 || !IsChatAssistantMessageContentVariant1 && IsChatAssistantMessageContent1 && !IsChatAssistantMessageContentVariant3 || !IsChatAssistantMessageContentVariant1 && !IsChatAssistantMessageContent1 && IsChatAssistantMessageContentVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? chatAssistantMessageContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ChatContentItems>?, TResult>? chatAssistantMessageContent1 = null,
            global::System.Func<object?, TResult>? chatAssistantMessageContentVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatAssistantMessageContentVariant1 && chatAssistantMessageContentVariant1 != null)
            {
                return chatAssistantMessageContentVariant1(ChatAssistantMessageContentVariant1!);
            }
            else if (IsChatAssistantMessageContent1 && chatAssistantMessageContent1 != null)
            {
                return chatAssistantMessageContent1(ChatAssistantMessageContent1!);
            }
            else if (IsChatAssistantMessageContentVariant3 && chatAssistantMessageContentVariant3 != null)
            {
                return chatAssistantMessageContentVariant3(ChatAssistantMessageContentVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? chatAssistantMessageContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ChatContentItems>?>? chatAssistantMessageContent1 = null,
            global::System.Action<object?>? chatAssistantMessageContentVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatAssistantMessageContentVariant1)
            {
                chatAssistantMessageContentVariant1?.Invoke(ChatAssistantMessageContentVariant1!);
            }
            else if (IsChatAssistantMessageContent1)
            {
                chatAssistantMessageContent1?.Invoke(ChatAssistantMessageContent1!);
            }
            else if (IsChatAssistantMessageContentVariant3)
            {
                chatAssistantMessageContentVariant3?.Invoke(ChatAssistantMessageContentVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatAssistantMessageContentVariant1,
                typeof(string),
                ChatAssistantMessageContent1,
                typeof(global::System.Collections.Generic.IList<global::G.ChatContentItems>),
                ChatAssistantMessageContentVariant3,
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
        public bool Equals(ChatAssistantMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatAssistantMessageContentVariant1, other.ChatAssistantMessageContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ChatContentItems>?>.Default.Equals(ChatAssistantMessageContent1, other.ChatAssistantMessageContent1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ChatAssistantMessageContentVariant3, other.ChatAssistantMessageContentVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatAssistantMessageContent obj1, ChatAssistantMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatAssistantMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatAssistantMessageContent obj1, ChatAssistantMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatAssistantMessageContent o && Equals(o);
        }
    }
}
