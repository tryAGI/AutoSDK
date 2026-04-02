//HintName: G.Models.StopConfiguration.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Not supported with latest reasoning models `o3` and `o4-mini`.<br/>
    /// Up to 4 sequences where the API will stop generating further tokens. The<br/>
    /// returned text will not contain the stop sequence.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public readonly partial struct StopConfiguration : global::System.IEquatable<StopConfiguration>
    {
        /// <summary>
        /// Default Value: &lt;|endoftext|&gt;
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StopConfigurationVariant1 { get; init; }
#else
        public string? StopConfigurationVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StopConfigurationVariant1))]
#endif
        public bool IsStopConfigurationVariant1 => StopConfigurationVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? StopConfigurationVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? StopConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StopConfigurationVariant2))]
#endif
        public bool IsStopConfigurationVariant2 => StopConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StopConfiguration(string value) => new StopConfiguration((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StopConfiguration @this) => @this.StopConfigurationVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StopConfiguration(string? value)
        {
            StopConfigurationVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StopConfiguration(
            string? stopConfigurationVariant1,
            global::System.Collections.Generic.IList<string>? stopConfigurationVariant2
            )
        {
            StopConfigurationVariant1 = stopConfigurationVariant1;
            StopConfigurationVariant2 = stopConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StopConfigurationVariant2 as object ??
            StopConfigurationVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StopConfigurationVariant1?.ToString() ??
            StopConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStopConfigurationVariant1 && !IsStopConfigurationVariant2 || !IsStopConfigurationVariant1 && IsStopConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? stopConfigurationVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? stopConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStopConfigurationVariant1 && stopConfigurationVariant1 != null)
            {
                return stopConfigurationVariant1(StopConfigurationVariant1!);
            }
            else if (IsStopConfigurationVariant2 && stopConfigurationVariant2 != null)
            {
                return stopConfigurationVariant2(StopConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? stopConfigurationVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? stopConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStopConfigurationVariant1)
            {
                stopConfigurationVariant1?.Invoke(StopConfigurationVariant1!);
            }
            else if (IsStopConfigurationVariant2)
            {
                stopConfigurationVariant2?.Invoke(StopConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StopConfigurationVariant1,
                typeof(string),
                StopConfigurationVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(StopConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StopConfigurationVariant1, other.StopConfigurationVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(StopConfigurationVariant2, other.StopConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StopConfiguration obj1, StopConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StopConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StopConfiguration obj1, StopConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StopConfiguration o && Equals(o);
        }
    }
}
