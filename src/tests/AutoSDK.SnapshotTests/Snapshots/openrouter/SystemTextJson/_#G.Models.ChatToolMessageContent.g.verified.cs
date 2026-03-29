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
        public static implicit operator string?(ChatToolMessageContent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolMessageContent(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatToolMessageContent(
            string? value1,
            global::System.Collections.Generic.IList<global::G.ChatContentItems>? chatToolMessageContent1
            )
        {
            Value1 = value1;
            ChatToolMessageContent1 = chatToolMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatToolMessageContent1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            ChatToolMessageContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsChatToolMessageContent1 || !IsValue1 && IsChatToolMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.ChatContentItems>?, TResult>? chatToolMessageContent1 = null,
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
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.ChatContentItems>?>? chatToolMessageContent1 = null,
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
                Value1,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
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
