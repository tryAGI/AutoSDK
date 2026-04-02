//HintName: G.Models.MessagesRequestSystem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestSystem : global::System.IEquatable<MessagesRequestSystem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MessagesRequestSystemVariant1 { get; init; }
#else
        public string? MessagesRequestSystemVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestSystemVariant1))]
#endif
        public bool IsMessagesRequestSystemVariant1 => MessagesRequestSystemVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>? MessagesRequestSystem1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>? MessagesRequestSystem1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestSystem1))]
#endif
        public bool IsMessagesRequestSystem1 => MessagesRequestSystem1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestSystem(string value) => new MessagesRequestSystem((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MessagesRequestSystem @this) => @this.MessagesRequestSystemVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestSystem(string? value)
        {
            MessagesRequestSystemVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestSystem(
            string? messagesRequestSystemVariant1,
            global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>? messagesRequestSystem1
            )
        {
            MessagesRequestSystemVariant1 = messagesRequestSystemVariant1;
            MessagesRequestSystem1 = messagesRequestSystem1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestSystem1 as object ??
            MessagesRequestSystemVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesRequestSystemVariant1?.ToString() ??
            MessagesRequestSystem1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesRequestSystemVariant1 && !IsMessagesRequestSystem1 || !IsMessagesRequestSystemVariant1 && IsMessagesRequestSystem1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? messagesRequestSystemVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>?, TResult>? messagesRequestSystem1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestSystemVariant1 && messagesRequestSystemVariant1 != null)
            {
                return messagesRequestSystemVariant1(MessagesRequestSystemVariant1!);
            }
            else if (IsMessagesRequestSystem1 && messagesRequestSystem1 != null)
            {
                return messagesRequestSystem1(MessagesRequestSystem1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? messagesRequestSystemVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>?>? messagesRequestSystem1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesRequestSystemVariant1)
            {
                messagesRequestSystemVariant1?.Invoke(MessagesRequestSystemVariant1!);
            }
            else if (IsMessagesRequestSystem1)
            {
                messagesRequestSystem1?.Invoke(MessagesRequestSystem1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesRequestSystemVariant1,
                typeof(string),
                MessagesRequestSystem1,
                typeof(global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>),
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
        public bool Equals(MessagesRequestSystem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MessagesRequestSystemVariant1, other.MessagesRequestSystemVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>?>.Default.Equals(MessagesRequestSystem1, other.MessagesRequestSystem1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestSystem obj1, MessagesRequestSystem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestSystem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestSystem obj1, MessagesRequestSystem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestSystem o && Equals(o);
        }
    }
}
