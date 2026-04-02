//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content : global::System.IEquatable<MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 { get; init; }
#else
        public string? MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 => MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items>? MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items>? MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 => MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content(string value) => new MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content @this) => @this.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content(string? value)
        {
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content(
            string? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1,
            global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items>? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1
            )
        {
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 = messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1;
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 = messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 as object ??
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1?.ToString() ??
            MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 && !IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 || !IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 && IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items>?, TResult>? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 && messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1!);
            }
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 && messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items>?>? messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1)
            {
                messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1!);
            }
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1)
            {
                messagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1,
                typeof(string),
                MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1,
                typeof(global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items>),
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
        public bool Equals(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1, other.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1Items>?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1, other.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content obj1, MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content obj1, MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content o && Equals(o);
        }
    }
}
