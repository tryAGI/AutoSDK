//HintName: G.Models.ChatSystemMessageContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// System message content
    /// </summary>
    public readonly partial struct ChatSystemMessageContent : global::System.IEquatable<ChatSystemMessageContent>
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
        public global::System.Collections.Generic.IList<global::G.ChatContentText>? ChatSystemMessageContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ChatContentText>? ChatSystemMessageContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatSystemMessageContent1))]
#endif
        public bool IsChatSystemMessageContent1 => ChatSystemMessageContent1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatSystemMessageContent(string value) => new ChatSystemMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatSystemMessageContent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatSystemMessageContent(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatSystemMessageContent(
            string? value1,
            global::System.Collections.Generic.IList<global::G.ChatContentText>? chatSystemMessageContent1
            )
        {
            Value1 = value1;
            ChatSystemMessageContent1 = chatSystemMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatSystemMessageContent1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            ChatSystemMessageContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsChatSystemMessageContent1 || !IsValue1 && IsChatSystemMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ChatContentText>?, TResult>? chatSystemMessageContent1 = null,
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
            else if (IsChatSystemMessageContent1 && chatSystemMessageContent1 != null)
            {
                return chatSystemMessageContent1(ChatSystemMessageContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ChatContentText>?>? chatSystemMessageContent1 = null,
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
            else if (IsChatSystemMessageContent1)
            {
                chatSystemMessageContent1?.Invoke(ChatSystemMessageContent1!);
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
                ChatSystemMessageContent1,
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
        public bool Equals(ChatSystemMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ChatContentText>?>.Default.Equals(ChatSystemMessageContent1, other.ChatSystemMessageContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatSystemMessageContent obj1, ChatSystemMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatSystemMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatSystemMessageContent obj1, ChatSystemMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatSystemMessageContent o && Equals(o);
        }
    }
}
