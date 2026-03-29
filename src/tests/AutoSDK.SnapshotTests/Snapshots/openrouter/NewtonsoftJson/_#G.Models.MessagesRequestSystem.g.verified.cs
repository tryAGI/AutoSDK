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
        public static implicit operator string?(MessagesRequestSystem @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestSystem(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestSystem(
            string? value1,
            global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>? messagesRequestSystem1
            )
        {
            Value1 = value1;
            MessagesRequestSystem1 = messagesRequestSystem1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestSystem1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            MessagesRequestSystem1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsMessagesRequestSystem1 || !IsValue1 && IsMessagesRequestSystem1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>?, TResult>? messagesRequestSystem1 = null,
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
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.MessagesRequestSystemOneOf1Items>?>? messagesRequestSystem1 = null,
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
                Value1,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
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
