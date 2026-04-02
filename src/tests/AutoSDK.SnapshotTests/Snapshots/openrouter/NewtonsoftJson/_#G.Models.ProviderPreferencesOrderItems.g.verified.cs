//HintName: G.Models.ProviderPreferencesOrderItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ProviderPreferencesOrderItems : global::System.IEquatable<ProviderPreferencesOrderItems>
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
        public string? ProviderPreferencesOrderItemsVariant2 { get; init; }
#else
        public string? ProviderPreferencesOrderItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderPreferencesOrderItemsVariant2))]
#endif
        public bool IsProviderPreferencesOrderItemsVariant2 => ProviderPreferencesOrderItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProviderPreferencesOrderItems(global::G.ProviderName value) => new ProviderPreferencesOrderItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(ProviderPreferencesOrderItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesOrderItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProviderPreferencesOrderItems(string value) => new ProviderPreferencesOrderItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ProviderPreferencesOrderItems @this) => @this.ProviderPreferencesOrderItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesOrderItems(string? value)
        {
            ProviderPreferencesOrderItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesOrderItems(
            global::G.ProviderName? providerName,
            string? providerPreferencesOrderItemsVariant2
            )
        {
            ProviderName = providerName;
            ProviderPreferencesOrderItemsVariant2 = providerPreferencesOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ProviderPreferencesOrderItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ProviderPreferencesOrderItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsProviderPreferencesOrderItemsVariant2 || !IsProviderName && IsProviderPreferencesOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? providerPreferencesOrderItemsVariant2 = null,
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
            else if (IsProviderPreferencesOrderItemsVariant2 && providerPreferencesOrderItemsVariant2 != null)
            {
                return providerPreferencesOrderItemsVariant2(ProviderPreferencesOrderItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? providerPreferencesOrderItemsVariant2 = null,
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
            else if (IsProviderPreferencesOrderItemsVariant2)
            {
                providerPreferencesOrderItemsVariant2?.Invoke(ProviderPreferencesOrderItemsVariant2!);
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
                ProviderPreferencesOrderItemsVariant2,
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
        public bool Equals(ProviderPreferencesOrderItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ProviderPreferencesOrderItemsVariant2, other.ProviderPreferencesOrderItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ProviderPreferencesOrderItems obj1, ProviderPreferencesOrderItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderPreferencesOrderItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ProviderPreferencesOrderItems obj1, ProviderPreferencesOrderItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderPreferencesOrderItems o && Equals(o);
        }
    }
}
