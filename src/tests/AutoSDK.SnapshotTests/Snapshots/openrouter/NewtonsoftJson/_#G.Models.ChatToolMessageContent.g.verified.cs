//HintName: G.Models.ChatToolMessageContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Tool response content
    /// </summary>
    public readonly partial struct ChatToolMessageContent : global::System.IEquatable<ChatToolMessageContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatToolMessageContentVariant1 { get; init; }
#else
        public string? ChatToolMessageContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolMessageContentVariant1))]
#endif
        public bool IsChatToolMessageContentVariant1 => ChatToolMessageContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.ChatContentItems>? ChatToolMessageContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ChatContentItems>? ChatToolMessageContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolMessageContent1))]
#endif
        public bool IsChatToolMessageContent1 => ChatToolMessageContent1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolMessageContent(string value) => new ChatToolMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatToolMessageContent @this) => @this.ChatToolMessageContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolMessageContent(string? value)
        {
            ChatToolMessageContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolMessageContent(
            string? chatToolMessageContentVariant1,
            global::System.Collections.Generic.IList<global::G.ChatContentItems>? chatToolMessageContent1
            )
        {
            ChatToolMessageContentVariant1 = chatToolMessageContentVariant1;
            ChatToolMessageContent1 = chatToolMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatToolMessageContent1 as object ??
            ChatToolMessageContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatToolMessageContentVariant1?.ToString() ??
            ChatToolMessageContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatToolMessageContentVariant1 && !IsChatToolMessageContent1 || !IsChatToolMessageContentVariant1 && IsChatToolMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? chatToolMessageContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ChatContentItems>?, TResult>? chatToolMessageContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatToolMessageContentVariant1 && chatToolMessageContentVariant1 != null)
            {
                return chatToolMessageContentVariant1(ChatToolMessageContentVariant1!);
            }
            else if (IsChatToolMessageContent1 && chatToolMessageContent1 != null)
            {
                return chatToolMessageContent1(ChatToolMessageContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? chatToolMessageContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ChatContentItems>?>? chatToolMessageContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatToolMessageContentVariant1)
            {
                chatToolMessageContentVariant1?.Invoke(ChatToolMessageContentVariant1!);
            }
            else if (IsChatToolMessageContent1)
            {
                chatToolMessageContent1?.Invoke(ChatToolMessageContent1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatToolMessageContentVariant1,
                typeof(string),
                ChatToolMessageContent1,
                typeof(global::System.Collections.Generic.IList<global::G.ChatContentItems>),
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
        public bool Equals(ChatToolMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatToolMessageContentVariant1, other.ChatToolMessageContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ChatContentItems>?>.Default.Equals(ChatToolMessageContent1, other.ChatToolMessageContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolMessageContent obj1, ChatToolMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolMessageContent obj1, ChatToolMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolMessageContent o && Equals(o);
        }
    }
}
