//HintName: G.Models.ChatRequestStop.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Stop sequences (up to 4)
    /// </summary>
    public readonly partial struct ChatRequestStop : global::System.IEquatable<ChatRequestStop>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatRequestStopVariant1 { get; init; }
#else
        public string? ChatRequestStopVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestStopVariant1))]
#endif
        public bool IsChatRequestStopVariant1 => ChatRequestStopVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? ChatRequestStopVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? ChatRequestStopVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestStopVariant2))]
#endif
        public bool IsChatRequestStopVariant2 => ChatRequestStopVariant2 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ChatRequestStopVariant3 { get; init; }
#else
        public object? ChatRequestStopVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestStopVariant3))]
#endif
        public bool IsChatRequestStopVariant3 => ChatRequestStopVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestStop(string value) => new ChatRequestStop((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatRequestStop @this) => @this.ChatRequestStopVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestStop(string? value)
        {
            ChatRequestStopVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestStop(
            string? chatRequestStopVariant1,
            global::System.Collections.Generic.IList<string>? chatRequestStopVariant2,
            object? chatRequestStopVariant3
            )
        {
            ChatRequestStopVariant1 = chatRequestStopVariant1;
            ChatRequestStopVariant2 = chatRequestStopVariant2;
            ChatRequestStopVariant3 = chatRequestStopVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatRequestStopVariant3 as object ??
            ChatRequestStopVariant2 as object ??
            ChatRequestStopVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatRequestStopVariant1?.ToString() ??
            ChatRequestStopVariant2?.ToString() ??
            ChatRequestStopVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatRequestStopVariant1 && !IsChatRequestStopVariant2 && !IsChatRequestStopVariant3 || !IsChatRequestStopVariant1 && IsChatRequestStopVariant2 && !IsChatRequestStopVariant3 || !IsChatRequestStopVariant1 && !IsChatRequestStopVariant2 && IsChatRequestStopVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? chatRequestStopVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? chatRequestStopVariant2 = null,
            global::System.Func<object?, TResult>? chatRequestStopVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatRequestStopVariant1 && chatRequestStopVariant1 != null)
            {
                return chatRequestStopVariant1(ChatRequestStopVariant1!);
            }
            else if (IsChatRequestStopVariant2 && chatRequestStopVariant2 != null)
            {
                return chatRequestStopVariant2(ChatRequestStopVariant2!);
            }
            else if (IsChatRequestStopVariant3 && chatRequestStopVariant3 != null)
            {
                return chatRequestStopVariant3(ChatRequestStopVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? chatRequestStopVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? chatRequestStopVariant2 = null,
            global::System.Action<object?>? chatRequestStopVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatRequestStopVariant1)
            {
                chatRequestStopVariant1?.Invoke(ChatRequestStopVariant1!);
            }
            else if (IsChatRequestStopVariant2)
            {
                chatRequestStopVariant2?.Invoke(ChatRequestStopVariant2!);
            }
            else if (IsChatRequestStopVariant3)
            {
                chatRequestStopVariant3?.Invoke(ChatRequestStopVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatRequestStopVariant1,
                typeof(string),
                ChatRequestStopVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
                ChatRequestStopVariant3,
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
        public bool Equals(ChatRequestStop other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatRequestStopVariant1, other.ChatRequestStopVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(ChatRequestStopVariant2, other.ChatRequestStopVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ChatRequestStopVariant3, other.ChatRequestStopVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestStop obj1, ChatRequestStop obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestStop>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestStop obj1, ChatRequestStop obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestStop o && Equals(o);
        }
    }
}
