//HintName: G.Models.ChatUserMessageContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// User message content
    /// </summary>
    public readonly partial struct ChatUserMessageContent : global::System.IEquatable<ChatUserMessageContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
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
        public global::System.Collections.Generic.IList<global::G.ChatContentItems>? ChatUserMessageContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ChatContentItems>? ChatUserMessageContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatUserMessageContent1))]
#endif
        public bool IsChatUserMessageContent1 => ChatUserMessageContent1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatUserMessageContent(string value) => new ChatUserMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatUserMessageContent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatUserMessageContent(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatUserMessageContent(
            string? value1,
            global::System.Collections.Generic.IList<global::G.ChatContentItems>? chatUserMessageContent1
            )
        {
            Value1 = value1;
            ChatUserMessageContent1 = chatUserMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatUserMessageContent1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            ChatUserMessageContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsChatUserMessageContent1 || !IsValue1 && IsChatUserMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ChatContentItems>?, TResult>? chatUserMessageContent1 = null,
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
            else if (IsChatUserMessageContent1 && chatUserMessageContent1 != null)
            {
                return chatUserMessageContent1(ChatUserMessageContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ChatContentItems>?>? chatUserMessageContent1 = null,
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
            else if (IsChatUserMessageContent1)
            {
                chatUserMessageContent1?.Invoke(ChatUserMessageContent1!);
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
                typeof(string),
                ChatUserMessageContent1,
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
        public bool Equals(ChatUserMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ChatContentItems>?>.Default.Equals(ChatUserMessageContent1, other.ChatUserMessageContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatUserMessageContent obj1, ChatUserMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatUserMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatUserMessageContent obj1, ChatUserMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatUserMessageContent o && Equals(o);
        }
    }
}
