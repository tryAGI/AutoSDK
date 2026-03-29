//HintName: G.Models.MessagesMessageParamContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesMessageParamContent : global::System.IEquatable<MessagesMessageParamContent>
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
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1Items>? MessagesMessageParamContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1Items>? MessagesMessageParamContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContent1))]
#endif
        public bool IsMessagesMessageParamContent1 => MessagesMessageParamContent1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContent(string value) => new MessagesMessageParamContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MessagesMessageParamContent @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContent(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContent(
            string? value1,
            global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1Items>? messagesMessageParamContent1
            )
        {
            Value1 = value1;
            MessagesMessageParamContent1 = messagesMessageParamContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesMessageParamContent1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            MessagesMessageParamContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsMessagesMessageParamContent1 || !IsValue1 && IsMessagesMessageParamContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1Items>?, TResult>? messagesMessageParamContent1 = null,
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
            else if (IsMessagesMessageParamContent1 && messagesMessageParamContent1 != null)
            {
                return messagesMessageParamContent1(MessagesMessageParamContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1Items>?>? messagesMessageParamContent1 = null,
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
            else if (IsMessagesMessageParamContent1)
            {
                messagesMessageParamContent1?.Invoke(MessagesMessageParamContent1!);
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
                MessagesMessageParamContent1,
                typeof(global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1Items>),
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
        public bool Equals(MessagesMessageParamContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1Items>?>.Default.Equals(MessagesMessageParamContent1, other.MessagesMessageParamContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesMessageParamContent obj1, MessagesMessageParamContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesMessageParamContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesMessageParamContent obj1, MessagesMessageParamContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesMessageParamContent o && Equals(o);
        }
    }
}
