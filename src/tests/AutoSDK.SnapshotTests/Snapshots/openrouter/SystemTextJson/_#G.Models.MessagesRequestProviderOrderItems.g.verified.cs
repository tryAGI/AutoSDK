//HintName: G.Models.MessagesRequestProviderOrderItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestProviderOrderItems : global::System.IEquatable<MessagesRequestProviderOrderItems>
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
        public string? MessagesRequestProviderOrderItemsVariant2 { get; init; }
#else
        public string? MessagesRequestProviderOrderItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestProviderOrderItemsVariant2))]
#endif
        public bool IsMessagesRequestProviderOrderItemsVariant2 => MessagesRequestProviderOrderItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestProviderOrderItems(global::G.ProviderName value) => new MessagesRequestProviderOrderItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(MessagesRequestProviderOrderItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestProviderOrderItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestProviderOrderItems(string value) => new MessagesRequestProviderOrderItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MessagesRequestProviderOrderItems @this) => @this.MessagesRequestProviderOrderItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestProviderOrderItems(string? value)
        {
            MessagesRequestProviderOrderItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestProviderOrderItems(
            global::G.ProviderName? providerName,
            string? messagesRequestProviderOrderItemsVariant2
            )
        {
            ProviderName = providerName;
            MessagesRequestProviderOrderItemsVariant2 = messagesRequestProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestProviderOrderItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            MessagesRequestProviderOrderItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsMessagesRequestProviderOrderItemsVariant2 || !IsProviderName && IsMessagesRequestProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? messagesRequestProviderOrderItemsVariant2 = null,
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
            else if (IsMessagesRequestProviderOrderItemsVariant2 && messagesRequestProviderOrderItemsVariant2 != null)
            {
                return messagesRequestProviderOrderItemsVariant2(MessagesRequestProviderOrderItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? messagesRequestProviderOrderItemsVariant2 = null,
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
            else if (IsMessagesRequestProviderOrderItemsVariant2)
            {
                messagesRequestProviderOrderItemsVariant2?.Invoke(MessagesRequestProviderOrderItemsVariant2!);
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
                MessagesRequestProviderOrderItemsVariant2,
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
        public bool Equals(MessagesRequestProviderOrderItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MessagesRequestProviderOrderItemsVariant2, other.MessagesRequestProviderOrderItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestProviderOrderItems obj1, MessagesRequestProviderOrderItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestProviderOrderItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestProviderOrderItems obj1, MessagesRequestProviderOrderItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestProviderOrderItems o && Equals(o);
        }
    }
}
