//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf0Trigger.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestContextManagementEditsItemsOneOf0Trigger : global::System.IEquatable<MessagesRequestContextManagementEditsItemsOneOf0Trigger>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0? MessagesRequestContextManagementEditsItemsOneOf0Trigger0 { get; init; }
#else
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0? MessagesRequestContextManagementEditsItemsOneOf0Trigger0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf0Trigger0))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf0Trigger0 => MessagesRequestContextManagementEditsItemsOneOf0Trigger0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1? MessagesRequestContextManagementEditsItemsOneOf0Trigger1 { get; init; }
#else
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1? MessagesRequestContextManagementEditsItemsOneOf0Trigger1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestContextManagementEditsItemsOneOf0Trigger1))]
#endif
        public bool IsMessagesRequestContextManagementEditsItemsOneOf0Trigger1 => MessagesRequestContextManagementEditsItemsOneOf0Trigger1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0 value) => new MessagesRequestContextManagementEditsItemsOneOf0Trigger((global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0?(MessagesRequestContextManagementEditsItemsOneOf0Trigger @this) => @this.MessagesRequestContextManagementEditsItemsOneOf0Trigger0;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0? value)
        {
            MessagesRequestContextManagementEditsItemsOneOf0Trigger0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1 value) => new MessagesRequestContextManagementEditsItemsOneOf0Trigger((global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1?(MessagesRequestContextManagementEditsItemsOneOf0Trigger @this) => @this.MessagesRequestContextManagementEditsItemsOneOf0Trigger1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0Trigger(global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1? value)
        {
            MessagesRequestContextManagementEditsItemsOneOf0Trigger1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0Trigger(
            global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0? messagesRequestContextManagementEditsItemsOneOf0Trigger0,
            global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1? messagesRequestContextManagementEditsItemsOneOf0Trigger1
            )
        {
            MessagesRequestContextManagementEditsItemsOneOf0Trigger0 = messagesRequestContextManagementEditsItemsOneOf0Trigger0;
            MessagesRequestContextManagementEditsItemsOneOf0Trigger1 = messagesRequestContextManagementEditsItemsOneOf0Trigger1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestContextManagementEditsItemsOneOf0Trigger1 as object ??
            MessagesRequestContextManagementEditsItemsOneOf0Trigger0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesRequestContextManagementEditsItemsOneOf0Trigger0?.ToString() ??
            MessagesRequestContextManagementEditsItemsOneOf0Trigger1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesRequestContextManagementEditsItemsOneOf0Trigger0 && !IsMessagesRequestContextManagementEditsItemsOneOf0Trigger1 || !IsMessagesRequestContextManagementEditsItemsOneOf0Trigger0 && IsMessagesRequestContextManagementEditsItemsOneOf0Trigger1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0?, TResult>? messagesRequestContextManagementEditsItemsOneOf0Trigger0 = null,
            global::System.Func<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1?, TResult>? messagesRequestContextManagementEditsItemsOneOf0Trigger1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestContextManagementEditsItemsOneOf0Trigger0 && messagesRequestContextManagementEditsItemsOneOf0Trigger0 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf0Trigger0(MessagesRequestContextManagementEditsItemsOneOf0Trigger0!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf0Trigger1 && messagesRequestContextManagementEditsItemsOneOf0Trigger1 != null)
            {
                return messagesRequestContextManagementEditsItemsOneOf0Trigger1(MessagesRequestContextManagementEditsItemsOneOf0Trigger1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0?>? messagesRequestContextManagementEditsItemsOneOf0Trigger0 = null,
            global::System.Action<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1?>? messagesRequestContextManagementEditsItemsOneOf0Trigger1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestContextManagementEditsItemsOneOf0Trigger0)
            {
                messagesRequestContextManagementEditsItemsOneOf0Trigger0?.Invoke(MessagesRequestContextManagementEditsItemsOneOf0Trigger0!);
            }
            else if (IsMessagesRequestContextManagementEditsItemsOneOf0Trigger1)
            {
                messagesRequestContextManagementEditsItemsOneOf0Trigger1?.Invoke(MessagesRequestContextManagementEditsItemsOneOf0Trigger1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesRequestContextManagementEditsItemsOneOf0Trigger0,
                typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0),
                MessagesRequestContextManagementEditsItemsOneOf0Trigger1,
                typeof(global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1),
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
        public bool Equals(MessagesRequestContextManagementEditsItemsOneOf0Trigger other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger0?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf0Trigger0, other.MessagesRequestContextManagementEditsItemsOneOf0Trigger0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger1?>.Default.Equals(MessagesRequestContextManagementEditsItemsOneOf0Trigger1, other.MessagesRequestContextManagementEditsItemsOneOf0Trigger1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestContextManagementEditsItemsOneOf0Trigger obj1, MessagesRequestContextManagementEditsItemsOneOf0Trigger obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestContextManagementEditsItemsOneOf0Trigger>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestContextManagementEditsItemsOneOf0Trigger obj1, MessagesRequestContextManagementEditsItemsOneOf0Trigger obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestContextManagementEditsItemsOneOf0Trigger o && Equals(o);
        }
    }
}
