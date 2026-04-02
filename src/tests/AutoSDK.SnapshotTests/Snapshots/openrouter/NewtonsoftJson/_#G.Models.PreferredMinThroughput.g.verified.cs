//HintName: G.Models.PreferredMinThroughput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Preferred minimum throughput (in tokens per second). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints below the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.
    /// </summary>
    public readonly partial struct PreferredMinThroughput : global::System.IEquatable<PreferredMinThroughput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? PreferredMinThroughputVariant1 { get; init; }
#else
        public double? PreferredMinThroughputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreferredMinThroughputVariant1))]
#endif
        public bool IsPreferredMinThroughputVariant1 => PreferredMinThroughputVariant1 != null;

        /// <summary>
        /// Percentile-based throughput cutoffs. All specified cutoffs must be met for an endpoint to be preferred.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PercentileThroughputCutoffs? PercentileThroughputCutoffs { get; init; }
#else
        public global::G.PercentileThroughputCutoffs? PercentileThroughputCutoffs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PercentileThroughputCutoffs))]
#endif
        public bool IsPercentileThroughputCutoffs => PercentileThroughputCutoffs != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? PreferredMinThroughputVariant3 { get; init; }
#else
        public object? PreferredMinThroughputVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreferredMinThroughputVariant3))]
#endif
        public bool IsPreferredMinThroughputVariant3 => PreferredMinThroughputVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreferredMinThroughput(double value) => new PreferredMinThroughput((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(PreferredMinThroughput @this) => @this.PreferredMinThroughputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PreferredMinThroughput(double? value)
        {
            PreferredMinThroughputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreferredMinThroughput(global::G.PercentileThroughputCutoffs value) => new PreferredMinThroughput((global::G.PercentileThroughputCutoffs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PercentileThroughputCutoffs?(PreferredMinThroughput @this) => @this.PercentileThroughputCutoffs;

        /// <summary>
        /// 
        /// </summary>
        public PreferredMinThroughput(global::G.PercentileThroughputCutoffs? value)
        {
            PercentileThroughputCutoffs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PreferredMinThroughput(
            double? preferredMinThroughputVariant1,
            global::G.PercentileThroughputCutoffs? percentileThroughputCutoffs,
            object? preferredMinThroughputVariant3
            )
        {
            PreferredMinThroughputVariant1 = preferredMinThroughputVariant1;
            PercentileThroughputCutoffs = percentileThroughputCutoffs;
            PreferredMinThroughputVariant3 = preferredMinThroughputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PreferredMinThroughputVariant3 as object ??
            PercentileThroughputCutoffs as object ??
            PreferredMinThroughputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PreferredMinThroughputVariant1?.ToString() ??
            PercentileThroughputCutoffs?.ToString() ??
            PreferredMinThroughputVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPreferredMinThroughputVariant1 && !IsPercentileThroughputCutoffs && !IsPreferredMinThroughputVariant3 || !IsPreferredMinThroughputVariant1 && IsPercentileThroughputCutoffs && !IsPreferredMinThroughputVariant3 || !IsPreferredMinThroughputVariant1 && !IsPercentileThroughputCutoffs && IsPreferredMinThroughputVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? preferredMinThroughputVariant1 = null,
            global::System.Func<global::G.PercentileThroughputCutoffs?, TResult>? percentileThroughputCutoffs = null,
            global::System.Func<object?, TResult>? preferredMinThroughputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreferredMinThroughputVariant1 && preferredMinThroughputVariant1 != null)
            {
                return preferredMinThroughputVariant1(PreferredMinThroughputVariant1!);
            }
            else if (IsPercentileThroughputCutoffs && percentileThroughputCutoffs != null)
            {
                return percentileThroughputCutoffs(PercentileThroughputCutoffs!);
            }
            else if (IsPreferredMinThroughputVariant3 && preferredMinThroughputVariant3 != null)
            {
                return preferredMinThroughputVariant3(PreferredMinThroughputVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<double?>? preferredMinThroughputVariant1 = null,
            global::System.Action<global::G.PercentileThroughputCutoffs?>? percentileThroughputCutoffs = null,
            global::System.Action<object?>? preferredMinThroughputVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreferredMinThroughputVariant1)
            {
                preferredMinThroughputVariant1?.Invoke(PreferredMinThroughputVariant1!);
            }
            else if (IsPercentileThroughputCutoffs)
            {
                percentileThroughputCutoffs?.Invoke(PercentileThroughputCutoffs!);
            }
            else if (IsPreferredMinThroughputVariant3)
            {
                preferredMinThroughputVariant3?.Invoke(PreferredMinThroughputVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PreferredMinThroughputVariant1,
                typeof(double),
                PercentileThroughputCutoffs,
                typeof(global::G.PercentileThroughputCutoffs),
                PreferredMinThroughputVariant3,
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
        public bool Equals(PreferredMinThroughput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(PreferredMinThroughputVariant1, other.PreferredMinThroughputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PercentileThroughputCutoffs?>.Default.Equals(PercentileThroughputCutoffs, other.PercentileThroughputCutoffs) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(PreferredMinThroughputVariant3, other.PreferredMinThroughputVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PreferredMinThroughput obj1, PreferredMinThroughput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PreferredMinThroughput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PreferredMinThroughput obj1, PreferredMinThroughput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PreferredMinThroughput o && Equals(o);
        }
    }
}
