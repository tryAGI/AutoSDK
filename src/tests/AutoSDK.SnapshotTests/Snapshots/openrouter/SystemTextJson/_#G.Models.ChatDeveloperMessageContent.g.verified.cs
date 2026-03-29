//HintName: G.Models.ChatDeveloperMessageContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Developer message content
    /// </summary>
    public readonly partial struct ChatDeveloperMessageContent : global::System.IEquatable<ChatDeveloperMessageContent>
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
        public global::System.Collections.Generic.IList<global::G.ChatContentText>? ChatDeveloperMessageContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ChatContentText>? ChatDeveloperMessageContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatDeveloperMessageContent1))]
#endif
        public bool IsChatDeveloperMessageContent1 => ChatDeveloperMessageContent1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatDeveloperMessageContent(string value) => new ChatDeveloperMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatDeveloperMessageContent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatDeveloperMessageContent(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatDeveloperMessageContent(
            string? value1,
            global::System.Collections.Generic.IList<global::G.ChatContentText>? chatDeveloperMessageContent1
            )
        {
            Value1 = value1;
            ChatDeveloperMessageContent1 = chatDeveloperMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatDeveloperMessageContent1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            ChatDeveloperMessageContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsChatDeveloperMessageContent1 || !IsValue1 && IsChatDeveloperMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ChatContentText>?, TResult>? chatDeveloperMessageContent1 = null,
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
            else if (IsChatDeveloperMessageContent1 && chatDeveloperMessageContent1 != null)
            {
                return chatDeveloperMessageContent1(ChatDeveloperMessageContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ChatContentText>?>? chatDeveloperMessageContent1 = null,
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
            else if (IsChatDeveloperMessageContent1)
            {
                chatDeveloperMessageContent1?.Invoke(ChatDeveloperMessageContent1!);
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
                ChatDeveloperMessageContent1,
                typeof(global::System.Collections.Generic.IList<global::G.ChatContentText>),
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
        public bool Equals(ChatDeveloperMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ChatContentText>?>.Default.Equals(ChatDeveloperMessageContent1, other.ChatDeveloperMessageContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatDeveloperMessageContent obj1, ChatDeveloperMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatDeveloperMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatDeveloperMessageContent obj1, ChatDeveloperMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatDeveloperMessageContent o && Equals(o);
        }
    }
}
