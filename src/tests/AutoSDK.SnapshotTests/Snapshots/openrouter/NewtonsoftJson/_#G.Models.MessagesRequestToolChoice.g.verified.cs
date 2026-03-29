//HintName: G.Models.MessagesRequestToolChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestToolChoice : global::System.IEquatable<MessagesRequestToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestToolChoice0? MessagesRequestToolChoice0 { get; init; }
#else
        public global::G.MessagesRequestToolChoice0? MessagesRequestToolChoice0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestToolChoice0))]
#endif
        public bool IsMessagesRequestToolChoice0 => MessagesRequestToolChoice0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestToolChoice1? MessagesRequestToolChoice1 { get; init; }
#else
        public global::G.MessagesRequestToolChoice1? MessagesRequestToolChoice1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestToolChoice1))]
#endif
        public bool IsMessagesRequestToolChoice1 => MessagesRequestToolChoice1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestToolChoice2? MessagesRequestToolChoice2 { get; init; }
#else
        public global::G.MessagesRequestToolChoice2? MessagesRequestToolChoice2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestToolChoice2))]
#endif
        public bool IsMessagesRequestToolChoice2 => MessagesRequestToolChoice2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestToolChoice3? MessagesRequestToolChoice3 { get; init; }
#else
        public global::G.MessagesRequestToolChoice3? MessagesRequestToolChoice3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestToolChoice3))]
#endif
        public bool IsMessagesRequestToolChoice3 => MessagesRequestToolChoice3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestToolChoice(global::G.MessagesRequestToolChoice0 value) => new MessagesRequestToolChoice((global::G.MessagesRequestToolChoice0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestToolChoice0?(MessagesRequestToolChoice @this) => @this.MessagesRequestToolChoice0;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestToolChoice(global::G.MessagesRequestToolChoice0? value)
        {
            MessagesRequestToolChoice0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestToolChoice(global::G.MessagesRequestToolChoice1 value) => new MessagesRequestToolChoice((global::G.MessagesRequestToolChoice1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestToolChoice1?(MessagesRequestToolChoice @this) => @this.MessagesRequestToolChoice1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestToolChoice(global::G.MessagesRequestToolChoice1? value)
        {
            MessagesRequestToolChoice1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestToolChoice(global::G.MessagesRequestToolChoice2 value) => new MessagesRequestToolChoice((global::G.MessagesRequestToolChoice2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestToolChoice2?(MessagesRequestToolChoice @this) => @this.MessagesRequestToolChoice2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestToolChoice(global::G.MessagesRequestToolChoice2? value)
        {
            MessagesRequestToolChoice2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestToolChoice(global::G.MessagesRequestToolChoice3 value) => new MessagesRequestToolChoice((global::G.MessagesRequestToolChoice3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestToolChoice3?(MessagesRequestToolChoice @this) => @this.MessagesRequestToolChoice3;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestToolChoice(global::G.MessagesRequestToolChoice3? value)
        {
            MessagesRequestToolChoice3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestToolChoice(
            global::G.MessagesRequestToolChoice0? messagesRequestToolChoice0,
            global::G.MessagesRequestToolChoice1? messagesRequestToolChoice1,
            global::G.MessagesRequestToolChoice2? messagesRequestToolChoice2,
            global::G.MessagesRequestToolChoice3? messagesRequestToolChoice3
            )
        {
            MessagesRequestToolChoice0 = messagesRequestToolChoice0;
            MessagesRequestToolChoice1 = messagesRequestToolChoice1;
            MessagesRequestToolChoice2 = messagesRequestToolChoice2;
            MessagesRequestToolChoice3 = messagesRequestToolChoice3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestToolChoice3 as object ??
            MessagesRequestToolChoice2 as object ??
            MessagesRequestToolChoice1 as object ??
            MessagesRequestToolChoice0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesRequestToolChoice0?.ToString() ??
            MessagesRequestToolChoice1?.ToString() ??
            MessagesRequestToolChoice2?.ToString() ??
            MessagesRequestToolChoice3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesRequestToolChoice0 && !IsMessagesRequestToolChoice1 && !IsMessagesRequestToolChoice2 && !IsMessagesRequestToolChoice3 || !IsMessagesRequestToolChoice0 && IsMessagesRequestToolChoice1 && !IsMessagesRequestToolChoice2 && !IsMessagesRequestToolChoice3 || !IsMessagesRequestToolChoice0 && !IsMessagesRequestToolChoice1 && IsMessagesRequestToolChoice2 && !IsMessagesRequestToolChoice3 || !IsMessagesRequestToolChoice0 && !IsMessagesRequestToolChoice1 && !IsMessagesRequestToolChoice2 && IsMessagesRequestToolChoice3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessagesRequestToolChoice0?, TResult>? messagesRequestToolChoice0 = null,
            global::System.Func<global::G.MessagesRequestToolChoice1?, TResult>? messagesRequestToolChoice1 = null,
            global::System.Func<global::G.MessagesRequestToolChoice2?, TResult>? messagesRequestToolChoice2 = null,
            global::System.Func<global::G.MessagesRequestToolChoice3?, TResult>? messagesRequestToolChoice3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestToolChoice0 && messagesRequestToolChoice0 != null)
            {
                return messagesRequestToolChoice0(MessagesRequestToolChoice0!);
            }
            else if (IsMessagesRequestToolChoice1 && messagesRequestToolChoice1 != null)
            {
                return messagesRequestToolChoice1(MessagesRequestToolChoice1!);
            }
            else if (IsMessagesRequestToolChoice2 && messagesRequestToolChoice2 != null)
            {
                return messagesRequestToolChoice2(MessagesRequestToolChoice2!);
            }
            else if (IsMessagesRequestToolChoice3 && messagesRequestToolChoice3 != null)
            {
                return messagesRequestToolChoice3(MessagesRequestToolChoice3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessagesRequestToolChoice0?>? messagesRequestToolChoice0 = null,
            global::System.Action<global::G.MessagesRequestToolChoice1?>? messagesRequestToolChoice1 = null,
            global::System.Action<global::G.MessagesRequestToolChoice2?>? messagesRequestToolChoice2 = null,
            global::System.Action<global::G.MessagesRequestToolChoice3?>? messagesRequestToolChoice3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestToolChoice0)
            {
                messagesRequestToolChoice0?.Invoke(MessagesRequestToolChoice0!);
            }
            else if (IsMessagesRequestToolChoice1)
            {
                messagesRequestToolChoice1?.Invoke(MessagesRequestToolChoice1!);
            }
            else if (IsMessagesRequestToolChoice2)
            {
                messagesRequestToolChoice2?.Invoke(MessagesRequestToolChoice2!);
            }
            else if (IsMessagesRequestToolChoice3)
            {
                messagesRequestToolChoice3?.Invoke(MessagesRequestToolChoice3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesRequestToolChoice0,
                typeof(global::G.MessagesRequestToolChoice0),
                MessagesRequestToolChoice1,
                typeof(global::G.MessagesRequestToolChoice1),
                MessagesRequestToolChoice2,
                typeof(global::G.MessagesRequestToolChoice2),
                MessagesRequestToolChoice3,
                typeof(global::G.MessagesRequestToolChoice3),
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
        public bool Equals(MessagesRequestToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestToolChoice0?>.Default.Equals(MessagesRequestToolChoice0, other.MessagesRequestToolChoice0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestToolChoice1?>.Default.Equals(MessagesRequestToolChoice1, other.MessagesRequestToolChoice1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestToolChoice2?>.Default.Equals(MessagesRequestToolChoice2, other.MessagesRequestToolChoice2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestToolChoice3?>.Default.Equals(MessagesRequestToolChoice3, other.MessagesRequestToolChoice3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestToolChoice obj1, MessagesRequestToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestToolChoice obj1, MessagesRequestToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestToolChoice o && Equals(o);
        }
    }
}
