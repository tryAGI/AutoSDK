//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf4Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesMessageParamContentOneOf1ItemsOneOf4Content : global::System.IEquatable<MessagesMessageParamContentOneOf1ItemsOneOf4Content>
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
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>? MessagesMessageParamContentOneOf1ItemsOneOf4Content1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>? MessagesMessageParamContentOneOf1ItemsOneOf4Content1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf4Content1))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf4Content1 => MessagesMessageParamContentOneOf1ItemsOneOf4Content1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf4Content(string value) => new MessagesMessageParamContentOneOf1ItemsOneOf4Content((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MessagesMessageParamContentOneOf1ItemsOneOf4Content @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4Content(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4Content(
            string? value1,
            global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>? messagesMessageParamContentOneOf1ItemsOneOf4Content1
            )
        {
            Value1 = value1;
            MessagesMessageParamContentOneOf1ItemsOneOf4Content1 = messagesMessageParamContentOneOf1ItemsOneOf4Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesMessageParamContentOneOf1ItemsOneOf4Content1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            MessagesMessageParamContentOneOf1ItemsOneOf4Content1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsMessagesMessageParamContentOneOf1ItemsOneOf4Content1 || !IsValue1 && IsMessagesMessageParamContentOneOf1ItemsOneOf4Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>?, TResult>? messagesMessageParamContentOneOf1ItemsOneOf4Content1 = null,
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
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf4Content1 && messagesMessageParamContentOneOf1ItemsOneOf4Content1 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf4Content1(MessagesMessageParamContentOneOf1ItemsOneOf4Content1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>?>? messagesMessageParamContentOneOf1ItemsOneOf4Content1 = null,
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
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf4Content1)
            {
                messagesMessageParamContentOneOf1ItemsOneOf4Content1?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf4Content1!);
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
                MessagesMessageParamContentOneOf1ItemsOneOf4Content1,
                typeof(global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>),
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
        public bool Equals(MessagesMessageParamContentOneOf1ItemsOneOf4Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf4Content1, other.MessagesMessageParamContentOneOf1ItemsOneOf4Content1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesMessageParamContentOneOf1ItemsOneOf4Content obj1, MessagesMessageParamContentOneOf1ItemsOneOf4Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesMessageParamContentOneOf1ItemsOneOf4Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesMessageParamContentOneOf1ItemsOneOf4Content obj1, MessagesMessageParamContentOneOf1ItemsOneOf4Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesMessageParamContentOneOf1ItemsOneOf4Content o && Equals(o);
        }
    }
}
