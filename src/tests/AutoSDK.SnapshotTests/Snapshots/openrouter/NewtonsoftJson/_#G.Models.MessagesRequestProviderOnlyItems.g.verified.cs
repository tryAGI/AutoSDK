//HintName: G.Models.MessagesRequestProviderOnlyItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesRequestProviderOnlyItems : global::System.IEquatable<MessagesRequestProviderOnlyItems>
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
        public string? MessagesRequestProviderOnlyItemsVariant2 { get; init; }
#else
        public string? MessagesRequestProviderOnlyItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesRequestProviderOnlyItemsVariant2))]
#endif
        public bool IsMessagesRequestProviderOnlyItemsVariant2 => MessagesRequestProviderOnlyItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestProviderOnlyItems(global::G.ProviderName value) => new MessagesRequestProviderOnlyItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(MessagesRequestProviderOnlyItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestProviderOnlyItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesRequestProviderOnlyItems(string value) => new MessagesRequestProviderOnlyItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MessagesRequestProviderOnlyItems @this) => @this.MessagesRequestProviderOnlyItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestProviderOnlyItems(string? value)
        {
            MessagesRequestProviderOnlyItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesRequestProviderOnlyItems(
            global::G.ProviderName? providerName,
            string? messagesRequestProviderOnlyItemsVariant2
            )
        {
            ProviderName = providerName;
            MessagesRequestProviderOnlyItemsVariant2 = messagesRequestProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesRequestProviderOnlyItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            MessagesRequestProviderOnlyItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsMessagesRequestProviderOnlyItemsVariant2 || !IsProviderName && IsMessagesRequestProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? messagesRequestProviderOnlyItemsVariant2 = null,
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
            else if (IsMessagesRequestProviderOnlyItemsVariant2 && messagesRequestProviderOnlyItemsVariant2 != null)
            {
                return messagesRequestProviderOnlyItemsVariant2(MessagesRequestProviderOnlyItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? messagesRequestProviderOnlyItemsVariant2 = null,
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
            else if (IsMessagesRequestProviderOnlyItemsVariant2)
            {
                messagesRequestProviderOnlyItemsVariant2?.Invoke(MessagesRequestProviderOnlyItemsVariant2!);
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
                MessagesRequestProviderOnlyItemsVariant2,
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
        public bool Equals(MessagesRequestProviderOnlyItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MessagesRequestProviderOnlyItemsVariant2, other.MessagesRequestProviderOnlyItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesRequestProviderOnlyItems obj1, MessagesRequestProviderOnlyItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesRequestProviderOnlyItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesRequestProviderOnlyItems obj1, MessagesRequestProviderOnlyItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesRequestProviderOnlyItems o && Equals(o);
        }
    }
}
