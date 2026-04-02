//HintName: G.Models.MessagesRequestProviderIgnoreItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestProviderIgnoreItems : global::System.IEquatable<MessagesRequestProviderIgnoreItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ProviderName? ProviderName { get; init; }
#else
        public global::G.ProviderName? ProviderName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderName))]
#endif
        public bool IsProviderName => ProviderName != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MessagesRequestProviderIgnoreItemsVariant2 { get; init; }
#else
        public string? MessagesRequestProviderIgnoreItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestProviderIgnoreItemsVariant2))]
#endif
        public bool IsMessagesRequestProviderIgnoreItemsVariant2 => MessagesRequestProviderIgnoreItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestProviderIgnoreItems(global::G.ProviderName value) => new MessagesRequestProviderIgnoreItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(MessagesRequestProviderIgnoreItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestProviderIgnoreItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestProviderIgnoreItems(string value) => new MessagesRequestProviderIgnoreItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MessagesRequestProviderIgnoreItems @this) => @this.MessagesRequestProviderIgnoreItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestProviderIgnoreItems(string? value)
        {
            MessagesRequestProviderIgnoreItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestProviderIgnoreItems(
            global::G.ProviderName? providerName,
            string? messagesRequestProviderIgnoreItemsVariant2
            )
        {
            ProviderName = providerName;
            MessagesRequestProviderIgnoreItemsVariant2 = messagesRequestProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestProviderIgnoreItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            MessagesRequestProviderIgnoreItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsMessagesRequestProviderIgnoreItemsVariant2 || !IsProviderName && IsMessagesRequestProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? messagesRequestProviderIgnoreItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName && providerName != null)
            {
                return providerName(ProviderName!);
            }
            else if (IsMessagesRequestProviderIgnoreItemsVariant2 && messagesRequestProviderIgnoreItemsVariant2 != null)
            {
                return messagesRequestProviderIgnoreItemsVariant2(MessagesRequestProviderIgnoreItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? messagesRequestProviderIgnoreItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName)
            {
                providerName?.Invoke(ProviderName!);
            }
            else if (IsMessagesRequestProviderIgnoreItemsVariant2)
            {
                messagesRequestProviderIgnoreItemsVariant2?.Invoke(MessagesRequestProviderIgnoreItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ProviderName,
                typeof(global::G.ProviderName),
                MessagesRequestProviderIgnoreItemsVariant2,
                typeof(string),
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
        public bool Equals(MessagesRequestProviderIgnoreItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MessagesRequestProviderIgnoreItemsVariant2, other.MessagesRequestProviderIgnoreItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestProviderIgnoreItems obj1, MessagesRequestProviderIgnoreItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestProviderIgnoreItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestProviderIgnoreItems obj1, MessagesRequestProviderIgnoreItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestProviderIgnoreItems o && Equals(o);
        }
    }
}
