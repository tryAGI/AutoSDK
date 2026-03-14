//HintName: G.Models.ScheduleConfiguration.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for when and how often the schedule should execute.
    /// </summary>
    public readonly partial struct ScheduleConfiguration : global::System.IEquatable<ScheduleConfiguration>
    {
        /// <summary>
        /// Configuration for interval-based schedule execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.IntervalScheduleConfiguration? Interval { get; init; }
#else
        public global::G.IntervalScheduleConfiguration? Interval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Interval))]
#endif
        public bool IsInterval => Interval != null;

        /// <summary>
        /// Configuration for cron-based schedule execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CronScheduleConfiguration? Cron { get; init; }
#else
        public global::G.CronScheduleConfiguration? Cron { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cron))]
#endif
        public bool IsCron => Cron != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleConfiguration(global::G.IntervalScheduleConfiguration value) => new ScheduleConfiguration((global::G.IntervalScheduleConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.IntervalScheduleConfiguration?(ScheduleConfiguration @this) => @this.Interval;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleConfiguration(global::G.IntervalScheduleConfiguration? value)
        {
            Interval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleConfiguration(global::G.CronScheduleConfiguration value) => new ScheduleConfiguration((global::G.CronScheduleConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CronScheduleConfiguration?(ScheduleConfiguration @this) => @this.Cron;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleConfiguration(global::G.CronScheduleConfiguration? value)
        {
            Cron = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ScheduleConfiguration(
            global::G.IntervalScheduleConfiguration? interval,
            global::G.CronScheduleConfiguration? cron
            )
        {
            Interval = interval;
            Cron = cron;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Cron as object ??
            Interval as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Interval?.ToString() ??
            Cron?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInterval && !IsCron || !IsInterval && IsCron;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.IntervalScheduleConfiguration?, TResult>? interval = null,
            global::System.Func<global::G.CronScheduleConfiguration?, TResult>? cron = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInterval && interval != null)
            {
                return interval(Interval!);
            }
            else if (IsCron && cron != null)
            {
                return cron(Cron!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.IntervalScheduleConfiguration?>? interval = null,
            global::System.Action<global::G.CronScheduleConfiguration?>? cron = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInterval)
            {
                interval?.Invoke(Interval!);
            }
            else if (IsCron)
            {
                cron?.Invoke(Cron!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Interval,
                typeof(global::G.IntervalScheduleConfiguration),
                Cron,
                typeof(global::G.CronScheduleConfiguration),
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
        public bool Equals(ScheduleConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.IntervalScheduleConfiguration?>.Default.Equals(Interval, other.Interval) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CronScheduleConfiguration?>.Default.Equals(Cron, other.Cron) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScheduleConfiguration obj1, ScheduleConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScheduleConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScheduleConfiguration obj1, ScheduleConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScheduleConfiguration o && Equals(o);
        }
    }
}
