//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf1Keep.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestContextManagementEditsItemsOneOf1Keep : global::System.IEquatable<MessagesRequestContextManagementEditsItemsOneOf1Keep>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0? MessagesRequestContextManagementEditsItemsOneOf1Keep0 { get; init; }
#else
        public global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0? MessagesRequestContextManagementEditsItemsOneOf1Keep0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf1Keep0))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf1Keep0 => MessagesRequestContextManagementEditsItemsOneOf1Keep0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1? MessagesRequestContextManagementEditsItemsOneOf1Keep1 { get; init; }
#else
        public global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1? MessagesRequestContextManagementEditsItemsOneOf1Keep1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf1Keep1))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 => MessagesRequestContextManagementEditsItemsOneOf1Keep1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2? MessagesRequestContextManagementEditsItemsOneOf1Keep2 { get; init; }
#else
        public global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2? MessagesRequestContextManagementEditsItemsOneOf1Keep2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf1Keep2))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf1Keep2 => MessagesRequestContextManagementEditsItemsOneOf1Keep2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf1Keep(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0 value) => new MessagesRequestContextManagementEditsItemsOneOf1Keep((global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0?(MessagesRequestContextManagementEditsItemsOneOf1Keep @this) => @this.MessagesRequestContextManagementEditsItemsOneOf1Keep0;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0? value)
        {
            MessagesRequestContextManagementEditsItemsOneOf1Keep0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf1Keep(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1 value) => new MessagesRequestContextManagementEditsItemsOneOf1Keep((global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1?(MessagesRequestContextManagementEditsItemsOneOf1Keep @this) => @this.MessagesRequestContextManagementEditsItemsOneOf1Keep1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1? value)
        {
            MessagesRequestContextManagementEditsItemsOneOf1Keep1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf1Keep(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2 value) => new MessagesRequestContextManagementEditsItemsOneOf1Keep((global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2?(MessagesRequestContextManagementEditsItemsOneOf1Keep @this) => @this.MessagesRequestContextManagementEditsItemsOneOf1Keep2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2? value)
        {
            MessagesRequestContextManagementEditsItemsOneOf1Keep2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep(
            global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0? messagesRequestContextManagementEditsItemsOneOf1Keep0,
            global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1? messagesRequestContextManagementEditsItemsOneOf1Keep1,
            global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2? messagesRequestContextManagementEditsItemsOneOf1Keep2
            )
        {
            MessagesRequestContextManagementEditsItemsOneOf1Keep0 = messagesRequestContextManagementEditsItemsOneOf1Keep0;
            MessagesRequestContextManagementEditsItemsOneOf1Keep1 = messagesRequestContextManagementEditsItemsOneOf1Keep1;
            MessagesRequestContextManagementEditsItemsOneOf1Keep2 = messagesRequestContextManagementEditsItemsOneOf1Keep2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestContextManagementEditsItemsOneOf1Keep2 as object ??
            MessagesRequestContextManagementEditsItemsOneOf1Keep1 as object ??
            MessagesRequestContextManagementEditsItemsOneOf1Keep0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesRequestContextManagementEditsItemsOneOf1Keep0?.ToString() ??
            MessagesRequestContextManagementEditsItemsOneOf1Keep1?.ToString() ??
            MessagesRequestContextManagementEditsItemsOneOf1Keep2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesRequestContextManagementEditsItemsOneOf1Keep0 && !IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 && !IsMessagesRequestContextManagementEditsItemsOneOf1Keep2 || !IsMessagesRequestContextManagementEditsItemsOneOf1Keep0 && IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 && !IsMessagesRequestContextManagementEditsItemsOneOf1Keep2 || !IsMessagesRequestContextManagementEditsItemsOneOf1Keep0 && !IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 && IsMessagesRequestContextManagementEditsItemsOneOf1Keep2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0?, TResult>? messagesRequestContextManagementEditsItemsOneOf1Keep0 = null,
            global::System.Func<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1?, TResult>? messagesRequestContextManagementEditsItemsOneOf1Keep1 = null,
            global::System.Func<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2?, TResult>? messagesRequestContextManagementEditsItemsOneOf1Keep2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep0 && messagesRequestContextManagementEditsItemsOneOf1Keep0 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf1Keep0(MessagesRequestContextManagementEditsItemsOneOf1Keep0!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep1 && messagesRequestContextManagementEditsItemsOneOf1Keep1 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf1Keep1(MessagesRequestContextManagementEditsItemsOneOf1Keep1!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep2 && messagesRequestContextManagementEditsItemsOneOf1Keep2 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf1Keep2(MessagesRequestContextManagementEditsItemsOneOf1Keep2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0?>? messagesRequestContextManagementEditsItemsOneOf1Keep0 = null,
            global::System.Action<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1?>? messagesRequestContextManagementEditsItemsOneOf1Keep1 = null,
            global::System.Action<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2?>? messagesRequestContextManagementEditsItemsOneOf1Keep2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep0)
            {
                messagesRequestContextManagementEditsItemsOneOf1Keep0?.Invoke(MessagesRequestContextManagementEditsItemsOneOf1Keep0!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep1)
            {
                messagesRequestContextManagementEditsItemsOneOf1Keep1?.Invoke(MessagesRequestContextManagementEditsItemsOneOf1Keep1!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf1Keep2)
            {
                messagesRequestContextManagementEditsItemsOneOf1Keep2?.Invoke(MessagesRequestContextManagementEditsItemsOneOf1Keep2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesRequestContextManagementEditsItemsOneOf1Keep0,
                typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0),
                MessagesRequestContextManagementEditsItemsOneOf1Keep1,
                typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1),
                MessagesRequestContextManagementEditsItemsOneOf1Keep2,
                typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2),
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
        public bool Equals(MessagesRequestContextManagementEditsItemsOneOf1Keep other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep0?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf1Keep0, other.MessagesRequestContextManagementEditsItemsOneOf1Keep0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep1?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf1Keep1, other.MessagesRequestContextManagementEditsItemsOneOf1Keep1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestContextManagementEditsItemsOneOf1Keep2?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf1Keep2, other.MessagesRequestContextManagementEditsItemsOneOf1Keep2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestContextManagementEditsItemsOneOf1Keep obj1, MessagesRequestContextManagementEditsItemsOneOf1Keep obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestContextManagementEditsItemsOneOf1Keep>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestContextManagementEditsItemsOneOf1Keep obj1, MessagesRequestContextManagementEditsItemsOneOf1Keep obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestContextManagementEditsItemsOneOf1Keep o && Equals(o);
        }
    }
}
