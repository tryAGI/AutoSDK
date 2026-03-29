//HintName: G.Models.MessagesRequestThinking.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestThinking : global::System.IEquatable<MessagesRequestThinking>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestThinking0? MessagesRequestThinking0 { get; init; }
#else
        public global::G.MessagesRequestThinking0? MessagesRequestThinking0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestThinking0))]
#endif
        public bool IsMessagesRequestThinking0 => MessagesRequestThinking0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestThinking1? MessagesRequestThinking1 { get; init; }
#else
        public global::G.MessagesRequestThinking1? MessagesRequestThinking1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestThinking1))]
#endif
        public bool IsMessagesRequestThinking1 => MessagesRequestThinking1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestThinking2? MessagesRequestThinking2 { get; init; }
#else
        public global::G.MessagesRequestThinking2? MessagesRequestThinking2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestThinking2))]
#endif
        public bool IsMessagesRequestThinking2 => MessagesRequestThinking2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestThinking(global::G.MessagesRequestThinking0 value) => new MessagesRequestThinking((global::G.MessagesRequestThinking0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestThinking0?(MessagesRequestThinking @this) => @this.MessagesRequestThinking0;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestThinking(global::G.MessagesRequestThinking0? value)
        {
            MessagesRequestThinking0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestThinking(global::G.MessagesRequestThinking1 value) => new MessagesRequestThinking((global::G.MessagesRequestThinking1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestThinking1?(MessagesRequestThinking @this) => @this.MessagesRequestThinking1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestThinking(global::G.MessagesRequestThinking1? value)
        {
            MessagesRequestThinking1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestThinking(global::G.MessagesRequestThinking2 value) => new MessagesRequestThinking((global::G.MessagesRequestThinking2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestThinking2?(MessagesRequestThinking @this) => @this.MessagesRequestThinking2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestThinking(global::G.MessagesRequestThinking2? value)
        {
            MessagesRequestThinking2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestThinking(
            global::G.MessagesRequestThinking0? messagesRequestThinking0,
            global::G.MessagesRequestThinking1? messagesRequestThinking1,
            global::G.MessagesRequestThinking2? messagesRequestThinking2
            )
        {
            MessagesRequestThinking0 = messagesRequestThinking0;
            MessagesRequestThinking1 = messagesRequestThinking1;
            MessagesRequestThinking2 = messagesRequestThinking2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestThinking2 as object ??
            MessagesRequestThinking1 as object ??
            MessagesRequestThinking0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesRequestThinking0?.ToString() ??
            MessagesRequestThinking1?.ToString() ??
            MessagesRequestThinking2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesRequestThinking0 && !IsMessagesRequestThinking1 && !IsMessagesRequestThinking2 || !IsMessagesRequestThinking0 && IsMessagesRequestThinking1 && !IsMessagesRequestThinking2 || !IsMessagesRequestThinking0 && !IsMessagesRequestThinking1 && IsMessagesRequestThinking2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessagesRequestThinking0?, TResult>? messagesRequestThinking0 = null,
            global::System.Func<global::G.MessagesRequestThinking1?, TResult>? messagesRequestThinking1 = null,
            global::System.Func<global::G.MessagesRequestThinking2?, TResult>? messagesRequestThinking2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestThinking0 && messagesRequestThinking0 != null)
            {
                return messagesRequestThinking0(MessagesRequestThinking0!);
            }
            else if (IsMessagesRequestThinking1 && messagesRequestThinking1 != null)
            {
                return messagesRequestThinking1(MessagesRequestThinking1!);
            }
            else if (IsMessagesRequestThinking2 && messagesRequestThinking2 != null)
            {
                return messagesRequestThinking2(MessagesRequestThinking2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessagesRequestThinking0?>? messagesRequestThinking0 = null,
            global::System.Action<global::G.MessagesRequestThinking1?>? messagesRequestThinking1 = null,
            global::System.Action<global::G.MessagesRequestThinking2?>? messagesRequestThinking2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestThinking0)
            {
                messagesRequestThinking0?.Invoke(MessagesRequestThinking0!);
            }
            else if (IsMessagesRequestThinking1)
            {
                messagesRequestThinking1?.Invoke(MessagesRequestThinking1!);
            }
            else if (IsMessagesRequestThinking2)
            {
                messagesRequestThinking2?.Invoke(MessagesRequestThinking2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesRequestThinking0,
                typeof(global::G.MessagesRequestThinking0),
                MessagesRequestThinking1,
                typeof(global::G.MessagesRequestThinking1),
                MessagesRequestThinking2,
                typeof(global::G.MessagesRequestThinking2),
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
        public bool Equals(MessagesRequestThinking other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestThinking0?>.Default.Equals(MessagesRequestThinking0, other.MessagesRequestThinking0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestThinking1?>.Default.Equals(MessagesRequestThinking1, other.MessagesRequestThinking1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestThinking2?>.Default.Equals(MessagesRequestThinking2, other.MessagesRequestThinking2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestThinking obj1, MessagesRequestThinking obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestThinking>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestThinking obj1, MessagesRequestThinking obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestThinking o && Equals(o);
        }
    }
}
