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
        public double? Value1 { get; init; }
#else
        public double? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

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
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreferredMinThroughput(double value) => new PreferredMinThroughput((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(PreferredMinThroughput @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public PreferredMinThroughput(double? value)
        {
            Value1 = value;
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
            double? value1,
            global::G.PercentileThroughputCutoffs? percentileThroughputCutoffs,
            object? value3
            )
        {
            Value1 = value1;
            PercentileThroughputCutoffs = percentileThroughputCutoffs;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            PercentileThroughputCutoffs as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            PercentileThroughputCutoffs?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsPercentileThroughputCutoffs && !IsValue3 || !IsValue1 && IsPercentileThroughputCutoffs && !IsValue3 || !IsValue1 && !IsPercentileThroughputCutoffs && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? value1 = null,
            global::System.Func<global::G.PercentileThroughputCutoffs?, TResult>? percentileThroughputCutoffs = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsPercentileThroughputCutoffs && percentileThroughputCutoffs != null)
            {
                return percentileThroughputCutoffs(PercentileThroughputCutoffs!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<double?>? value1 = null,
            global::System.Action<global::G.PercentileThroughputCutoffs?>? percentileThroughputCutoffs = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsPercentileThroughputCutoffs)
            {
                percentileThroughputCutoffs?.Invoke(PercentileThroughputCutoffs!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(double),
                PercentileThroughputCutoffs,
                typeof(global::G.PercentileThroughputCutoffs),
                Value3,
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
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PercentileThroughputCutoffs?>.Default.Equals(PercentileThroughputCutoffs, other.PercentileThroughputCutoffs) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
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
