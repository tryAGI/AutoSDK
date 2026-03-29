//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf8Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesMessageParamContentOneOf1ItemsOneOf8Content : global::System.IEquatable<MessagesMessageParamContentOneOf1ItemsOneOf8Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0Items>? MessagesMessageParamContentOneOf1ItemsOneOf8Content0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0Items>? MessagesMessageParamContentOneOf1ItemsOneOf8Content0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf8Content0))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf8Content0 => MessagesMessageParamContentOneOf1ItemsOneOf8Content0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1? MessagesMessageParamContentOneOf1ItemsOneOf8Content1 { get; init; }
#else
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1? MessagesMessageParamContentOneOf1ItemsOneOf8Content1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf8Content1))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf8Content1 => MessagesMessageParamContentOneOf1ItemsOneOf8Content1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf8Content(global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1 value) => new MessagesMessageParamContentOneOf1ItemsOneOf8Content((global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1?(MessagesMessageParamContentOneOf1ItemsOneOf8Content @this) => @this.MessagesMessageParamContentOneOf1ItemsOneOf8Content1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf8Content(global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1? value)
        {
            MessagesMessageParamContentOneOf1ItemsOneOf8Content1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf8Content(
            global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0Items>? messagesMessageParamContentOneOf1ItemsOneOf8Content0,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1? messagesMessageParamContentOneOf1ItemsOneOf8Content1
            )
        {
            MessagesMessageParamContentOneOf1ItemsOneOf8Content0 = messagesMessageParamContentOneOf1ItemsOneOf8Content0;
            MessagesMessageParamContentOneOf1ItemsOneOf8Content1 = messagesMessageParamContentOneOf1ItemsOneOf8Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesMessageParamContentOneOf1ItemsOneOf8Content1 as object ??
            MessagesMessageParamContentOneOf1ItemsOneOf8Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesMessageParamContentOneOf1ItemsOneOf8Content0?.ToString() ??
            MessagesMessageParamContentOneOf1ItemsOneOf8Content1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesMessageParamContentOneOf1ItemsOneOf8Content0 && !IsMessagesMessageParamContentOneOf1ItemsOneOf8Content1 || !IsMessagesMessageParamContentOneOf1ItemsOneOf8Content0 && IsMessagesMessageParamContentOneOf1ItemsOneOf8Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0Items>?, TResult>? messagesMessageParamContentOneOf1ItemsOneOf8Content0 = null,
            global::System.Func<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1?, TResult>? messagesMessageParamContentOneOf1ItemsOneOf8Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesMessageParamContentOneOf1ItemsOneOf8Content0 && messagesMessageParamContentOneOf1ItemsOneOf8Content0 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf8Content0(MessagesMessageParamContentOneOf1ItemsOneOf8Content0!);
            }
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf8Content1 && messagesMessageParamContentOneOf1ItemsOneOf8Content1 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf8Content1(MessagesMessageParamContentOneOf1ItemsOneOf8Content1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0Items>?>? messagesMessageParamContentOneOf1ItemsOneOf8Content0 = null,
            global::System.Action<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1?>? messagesMessageParamContentOneOf1ItemsOneOf8Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesMessageParamContentOneOf1ItemsOneOf8Content0)
            {
                messagesMessageParamContentOneOf1ItemsOneOf8Content0?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf8Content0!);
            }
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf8Content1)
            {
                messagesMessageParamContentOneOf1ItemsOneOf8Content1?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf8Content1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesMessageParamContentOneOf1ItemsOneOf8Content0,
                typeof(global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0Items>),
                MessagesMessageParamContentOneOf1ItemsOneOf8Content1,
                typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1),
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
        public bool Equals(MessagesMessageParamContentOneOf1ItemsOneOf8Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0Items>?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf8Content0, other.MessagesMessageParamContentOneOf1ItemsOneOf8Content0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesMessageParamContentOneOf1ItemsOneOf8Content1?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf8Content1, other.MessagesMessageParamContentOneOf1ItemsOneOf8Content1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesMessageParamContentOneOf1ItemsOneOf8Content obj1, MessagesMessageParamContentOneOf1ItemsOneOf8Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesMessageParamContentOneOf1ItemsOneOf8Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesMessageParamContentOneOf1ItemsOneOf8Content obj1, MessagesMessageParamContentOneOf1ItemsOneOf8Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesMessageParamContentOneOf1ItemsOneOf8Content o && Equals(o);
        }
    }
}
