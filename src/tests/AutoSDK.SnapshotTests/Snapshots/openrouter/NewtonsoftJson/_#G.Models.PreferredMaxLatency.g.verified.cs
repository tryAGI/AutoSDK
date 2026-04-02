//HintName: G.Models.PreferredMaxLatency.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Preferred maximum latency (in seconds). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints above the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.
    /// </summary>
    public readonly partial struct PreferredMaxLatency : global::System.IEquatable<PreferredMaxLatency>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? PreferredMaxLatencyVariant1 { get; init; }
#else
        public double? PreferredMaxLatencyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreferredMaxLatencyVariant1))]
#endif
        public bool IsPreferredMaxLatencyVariant1 => PreferredMaxLatencyVariant1 != null;

        /// <summary>
        /// Percentile-based latency cutoffs. All specified cutoffs must be met for an endpoint to be preferred.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PercentileLatencyCutoffs? PercentileLatencyCutoffs { get; init; }
#else
        public global::G.PercentileLatencyCutoffs? PercentileLatencyCutoffs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PercentileLatencyCutoffs))]
#endif
        public bool IsPercentileLatencyCutoffs => PercentileLatencyCutoffs != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? PreferredMaxLatencyVariant3 { get; init; }
#else
        public object? PreferredMaxLatencyVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreferredMaxLatencyVariant3))]
#endif
        public bool IsPreferredMaxLatencyVariant3 => PreferredMaxLatencyVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreferredMaxLatency(double value) => new PreferredMaxLatency((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(PreferredMaxLatency @this) => @this.PreferredMaxLatencyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PreferredMaxLatency(double? value)
        {
            PreferredMaxLatencyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreferredMaxLatency(global::G.PercentileLatencyCutoffs value) => new PreferredMaxLatency((global::G.PercentileLatencyCutoffs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PercentileLatencyCutoffs?(PreferredMaxLatency @this) => @this.PercentileLatencyCutoffs;

        /// <summary>
        /// 
        /// </summary>
        public PreferredMaxLatency(global::G.PercentileLatencyCutoffs? value)
        {
            PercentileLatencyCutoffs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PreferredMaxLatency(
            double? preferredMaxLatencyVariant1,
            global::G.PercentileLatencyCutoffs? percentileLatencyCutoffs,
            object? preferredMaxLatencyVariant3
            )
        {
            PreferredMaxLatencyVariant1 = preferredMaxLatencyVariant1;
            PercentileLatencyCutoffs = percentileLatencyCutoffs;
            PreferredMaxLatencyVariant3 = preferredMaxLatencyVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PreferredMaxLatencyVariant3 as object ??
            PercentileLatencyCutoffs as object ??
            PreferredMaxLatencyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PreferredMaxLatencyVariant1?.ToString() ??
            PercentileLatencyCutoffs?.ToString() ??
            PreferredMaxLatencyVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPreferredMaxLatencyVariant1 && !IsPercentileLatencyCutoffs && !IsPreferredMaxLatencyVariant3 || !IsPreferredMaxLatencyVariant1 && IsPercentileLatencyCutoffs && !IsPreferredMaxLatencyVariant3 || !IsPreferredMaxLatencyVariant1 && !IsPercentileLatencyCutoffs && IsPreferredMaxLatencyVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? preferredMaxLatencyVariant1 = null,
            global::System.Func<global::G.PercentileLatencyCutoffs?, TResult>? percentileLatencyCutoffs = null,
            global::System.Func<object?, TResult>? preferredMaxLatencyVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreferredMaxLatencyVariant1 && preferredMaxLatencyVariant1 != null)
            {
                return preferredMaxLatencyVariant1(PreferredMaxLatencyVariant1!);
            }
            else if (IsPercentileLatencyCutoffs && percentileLatencyCutoffs != null)
            {
                return percentileLatencyCutoffs(PercentileLatencyCutoffs!);
            }
            else if (IsPreferredMaxLatencyVariant3 && preferredMaxLatencyVariant3 != null)
            {
                return preferredMaxLatencyVariant3(PreferredMaxLatencyVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<double?>? preferredMaxLatencyVariant1 = null,
            global::System.Action<global::G.PercentileLatencyCutoffs?>? percentileLatencyCutoffs = null,
            global::System.Action<object?>? preferredMaxLatencyVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreferredMaxLatencyVariant1)
            {
                preferredMaxLatencyVariant1?.Invoke(PreferredMaxLatencyVariant1!);
            }
            else if (IsPercentileLatencyCutoffs)
            {
                percentileLatencyCutoffs?.Invoke(PercentileLatencyCutoffs!);
            }
            else if (IsPreferredMaxLatencyVariant3)
            {
                preferredMaxLatencyVariant3?.Invoke(PreferredMaxLatencyVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PreferredMaxLatencyVariant1,
                typeof(double),
                PercentileLatencyCutoffs,
                typeof(global::G.PercentileLatencyCutoffs),
                PreferredMaxLatencyVariant3,
                typeof(object),
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
        public bool Equals(PreferredMaxLatency other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(PreferredMaxLatencyVariant1, other.PreferredMaxLatencyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PercentileLatencyCutoffs?>.Default.Equals(PercentileLatencyCutoffs, other.PercentileLatencyCutoffs) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(PreferredMaxLatencyVariant3, other.PreferredMaxLatencyVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PreferredMaxLatency obj1, PreferredMaxLatency obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PreferredMaxLatency>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PreferredMaxLatency obj1, PreferredMaxLatency obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PreferredMaxLatency o && Equals(o);
        }
    }
}
