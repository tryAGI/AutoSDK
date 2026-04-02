//HintName: G.Models.StartFrom.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StartFrom : global::System.IEquatable<StartFrom>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public long? StartFromVariant1 { get; init; }
#else
        public long? StartFromVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StartFromVariant1))]
#endif
        public bool IsStartFromVariant1 => StartFromVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? StartFromVariant2 { get; init; }
#else
        public double? StartFromVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StartFromVariant2))]
#endif
        public bool IsStartFromVariant2 => StartFromVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.DateTime? DateTime { get; init; }
#else
        public global::System.DateTime? DateTime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DateTime))]
#endif
        public bool IsDateTime => DateTime != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StartFrom(long value) => new StartFrom((long?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator long?(StartFrom @this) => @this.StartFromVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StartFrom(long? value)
        {
            StartFromVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StartFrom(double value) => new StartFrom((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(StartFrom @this) => @this.StartFromVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StartFrom(double? value)
        {
            StartFromVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StartFrom(global::System.DateTime value) => new StartFrom((global::System.DateTime?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.DateTime?(StartFrom @this) => @this.DateTime;

        /// <summary>
        /// 
        /// </summary>
        public StartFrom(global::System.DateTime? value)
        {
            DateTime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StartFrom(
            long? startFromVariant1,
            double? startFromVariant2,
            global::System.DateTime? dateTime
            )
        {
            StartFromVariant1 = startFromVariant1;
            StartFromVariant2 = startFromVariant2;
            DateTime = dateTime;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DateTime as object ??
            StartFromVariant2 as object ??
            StartFromVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StartFromVariant1?.ToString() ??
            StartFromVariant2?.ToString() ??
            DateTime?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStartFromVariant1 || IsStartFromVariant2 || IsDateTime;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<long?, TResult>? startFromVariant1 = null,
            global::System.Func<double?, TResult>? startFromVariant2 = null,
            global::System.Func<global::System.DateTime?, TResult>? dateTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStartFromVariant1 && startFromVariant1 != null)
            {
                return startFromVariant1(StartFromVariant1!);
            }
            else if (IsStartFromVariant2 && startFromVariant2 != null)
            {
                return startFromVariant2(StartFromVariant2!);
            }
            else if (IsDateTime && dateTime != null)
            {
                return dateTime(DateTime!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<long?>? startFromVariant1 = null,
            global::System.Action<double?>? startFromVariant2 = null,
            global::System.Action<global::System.DateTime?>? dateTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStartFromVariant1)
            {
                startFromVariant1?.Invoke(StartFromVariant1!);
            }
            else if (IsStartFromVariant2)
            {
                startFromVariant2?.Invoke(StartFromVariant2!);
            }
            else if (IsDateTime)
            {
                dateTime?.Invoke(DateTime!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StartFromVariant1,
                typeof(long),
                StartFromVariant2,
                typeof(double),
                DateTime,
                typeof(global::System.DateTime),
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
        public bool Equals(StartFrom other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<long?>.Default.Equals(StartFromVariant1, other.StartFromVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(StartFromVariant2, other.StartFromVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.DateTime?>.Default.Equals(DateTime, other.DateTime) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StartFrom obj1, StartFrom obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StartFrom>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StartFrom obj1, StartFrom obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StartFrom o && Equals(o);
        }
    }
}
