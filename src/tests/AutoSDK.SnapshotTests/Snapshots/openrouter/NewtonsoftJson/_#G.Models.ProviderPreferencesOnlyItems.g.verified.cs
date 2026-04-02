//HintName: G.Models.ProviderPreferencesOnlyItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ProviderPreferencesOnlyItems : global::System.IEquatable<ProviderPreferencesOnlyItems>
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
        public string? ProviderPreferencesOnlyItemsVariant2 { get; init; }
#else
        public string? ProviderPreferencesOnlyItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderPreferencesOnlyItemsVariant2))]
#endif
        public bool IsProviderPreferencesOnlyItemsVariant2 => ProviderPreferencesOnlyItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProviderPreferencesOnlyItems(global::G.ProviderName value) => new ProviderPreferencesOnlyItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(ProviderPreferencesOnlyItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesOnlyItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProviderPreferencesOnlyItems(string value) => new ProviderPreferencesOnlyItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ProviderPreferencesOnlyItems @this) => @this.ProviderPreferencesOnlyItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesOnlyItems(string? value)
        {
            ProviderPreferencesOnlyItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesOnlyItems(
            global::G.ProviderName? providerName,
            string? providerPreferencesOnlyItemsVariant2
            )
        {
            ProviderName = providerName;
            ProviderPreferencesOnlyItemsVariant2 = providerPreferencesOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ProviderPreferencesOnlyItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ProviderPreferencesOnlyItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsProviderPreferencesOnlyItemsVariant2 || !IsProviderName && IsProviderPreferencesOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? providerPreferencesOnlyItemsVariant2 = null,
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
            else if (IsProviderPreferencesOnlyItemsVariant2 && providerPreferencesOnlyItemsVariant2 != null)
            {
                return providerPreferencesOnlyItemsVariant2(ProviderPreferencesOnlyItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? providerPreferencesOnlyItemsVariant2 = null,
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
            else if (IsProviderPreferencesOnlyItemsVariant2)
            {
                providerPreferencesOnlyItemsVariant2?.Invoke(ProviderPreferencesOnlyItemsVariant2!);
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
                ProviderPreferencesOnlyItemsVariant2,
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
        public bool Equals(ProviderPreferencesOnlyItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ProviderPreferencesOnlyItemsVariant2, other.ProviderPreferencesOnlyItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ProviderPreferencesOnlyItems obj1, ProviderPreferencesOnlyItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderPreferencesOnlyItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ProviderPreferencesOnlyItems obj1, ProviderPreferencesOnlyItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderPreferencesOnlyItems o && Equals(o);
        }
    }
}
