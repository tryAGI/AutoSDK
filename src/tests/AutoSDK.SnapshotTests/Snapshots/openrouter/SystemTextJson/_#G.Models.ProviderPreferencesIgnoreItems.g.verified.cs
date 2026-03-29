//HintName: G.Models.ProviderPreferencesIgnoreItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ProviderPreferencesIgnoreItems : global::System.IEquatable<ProviderPreferencesIgnoreItems>
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
        public string? Value2 { get; init; }
#else
        public string? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProviderPreferencesIgnoreItems(global::G.ProviderName value) => new ProviderPreferencesIgnoreItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(ProviderPreferencesIgnoreItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesIgnoreItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProviderPreferencesIgnoreItems(string value) => new ProviderPreferencesIgnoreItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ProviderPreferencesIgnoreItems @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesIgnoreItems(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesIgnoreItems(
            global::G.ProviderName? providerName,
            string? value2
            )
        {
            ProviderName = providerName;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsValue2 || !IsProviderName && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? value2 = null,
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
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? value2 = null,
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
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
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
                Value2,
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
        public bool Equals(ProviderPreferencesIgnoreItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ProviderPreferencesIgnoreItems obj1, ProviderPreferencesIgnoreItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderPreferencesIgnoreItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ProviderPreferencesIgnoreItems obj1, ProviderPreferencesIgnoreItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderPreferencesIgnoreItems o && Equals(o);
        }
    }
}
