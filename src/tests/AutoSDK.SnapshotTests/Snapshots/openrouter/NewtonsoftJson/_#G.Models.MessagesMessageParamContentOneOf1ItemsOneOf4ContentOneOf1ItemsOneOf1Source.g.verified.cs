//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source : global::System.IEquatable<MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0? MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 { get; init; }
#else
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0? MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 => MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1? MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 { get; init; }
#else
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1? MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 => MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source((global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0?(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source @this) => @this.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0? value)
        {
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source((global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1?(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source @this) => @this.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1? value)
        {
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source(
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1
            )
        {
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 = messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0;
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 = messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 as object ??
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0?.ToString() ??
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 && !IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 || !IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 && IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0?, TResult>? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 = null,
            global::System.Func<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1?, TResult>? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0!);
            }
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0?>? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0 = null,
            global::System.Action<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1?>? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0)
            {
                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0!);
            }
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1)
            {
                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0,
                typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0),
                MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1,
                typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1),
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
        public bool Equals(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0, other.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1, other.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source obj1, MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source obj1, MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1Source o && Equals(o);
        }
    }
}
