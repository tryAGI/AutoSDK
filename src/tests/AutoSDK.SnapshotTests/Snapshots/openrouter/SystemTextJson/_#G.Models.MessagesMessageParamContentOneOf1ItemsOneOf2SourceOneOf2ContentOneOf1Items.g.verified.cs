//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items : global::System.IEquatable<MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0? MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 { get; init; }
#else
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0? MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 => MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1? MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 { get; init; }
#else
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1? MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 => MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 value) => new MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items((global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0?(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0? value)
        {
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 value) => new MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items((global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1?(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1? value)
        {
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items(
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1
            )
        {
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 = messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0;
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 = messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 as object ??
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0?.ToString() ??
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 && !IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 || !IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 && IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0?, TResult>? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 = null,
            global::System.Func<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1?, TResult>? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 && messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0!);
            }
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 && messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0?>? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0 = null,
            global::System.Action<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1?>? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0)
            {
                messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0!);
            }
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1)
            {
                messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0,
                typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0),
                MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1,
                typeof(global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1),
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
        public bool Equals(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0, other.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1, other.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items obj1, MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items obj1, MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items o && Equals(o);
        }
    }
}
