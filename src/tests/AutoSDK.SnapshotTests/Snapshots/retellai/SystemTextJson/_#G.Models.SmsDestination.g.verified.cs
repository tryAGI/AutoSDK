//HintName: G.Models.SmsDestination.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SmsDestination : global::System.IEquatable<SmsDestination>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SmsDestinationVariant1? SmsDestinationVariant1 { get; init; }
#else
        public global::G.SmsDestinationVariant1? SmsDestinationVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsDestinationVariant1))]
#endif
        public bool IsSmsDestinationVariant1 => SmsDestinationVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SmsDestinationVariant2? SmsDestinationVariant2 { get; init; }
#else
        public global::G.SmsDestinationVariant2? SmsDestinationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsDestinationVariant2))]
#endif
        public bool IsSmsDestinationVariant2 => SmsDestinationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsDestination(global::G.SmsDestinationVariant1 value) => new SmsDestination((global::G.SmsDestinationVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsDestinationVariant1?(SmsDestination @this) => @this.SmsDestinationVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SmsDestination(global::G.SmsDestinationVariant1? value)
        {
            SmsDestinationVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsDestination(global::G.SmsDestinationVariant2 value) => new SmsDestination((global::G.SmsDestinationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsDestinationVariant2?(SmsDestination @this) => @this.SmsDestinationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SmsDestination(global::G.SmsDestinationVariant2? value)
        {
            SmsDestinationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SmsDestination(
            global::G.SmsDestinationVariant1? smsDestinationVariant1,
            global::G.SmsDestinationVariant2? smsDestinationVariant2
            )
        {
            SmsDestinationVariant1 = smsDestinationVariant1;
            SmsDestinationVariant2 = smsDestinationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SmsDestinationVariant2 as object ??
            SmsDestinationVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SmsDestinationVariant1?.ToString() ??
            SmsDestinationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSmsDestinationVariant1 && !IsSmsDestinationVariant2 || !IsSmsDestinationVariant1 && IsSmsDestinationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SmsDestinationVariant1?, TResult>? smsDestinationVariant1 = null,
            global::System.Func<global::G.SmsDestinationVariant2?, TResult>? smsDestinationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSmsDestinationVariant1 && smsDestinationVariant1 != null)
            {
                return smsDestinationVariant1(SmsDestinationVariant1!);
            }
            else if (IsSmsDestinationVariant2 && smsDestinationVariant2 != null)
            {
                return smsDestinationVariant2(SmsDestinationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SmsDestinationVariant1?>? smsDestinationVariant1 = null,
            global::System.Action<global::G.SmsDestinationVariant2?>? smsDestinationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSmsDestinationVariant1)
            {
                smsDestinationVariant1?.Invoke(SmsDestinationVariant1!);
            }
            else if (IsSmsDestinationVariant2)
            {
                smsDestinationVariant2?.Invoke(SmsDestinationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SmsDestinationVariant1,
                typeof(global::G.SmsDestinationVariant1),
                SmsDestinationVariant2,
                typeof(global::G.SmsDestinationVariant2),
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
        public bool Equals(SmsDestination other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SmsDestinationVariant1?>.Default.Equals(SmsDestinationVariant1, other.SmsDestinationVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SmsDestinationVariant2?>.Default.Equals(SmsDestinationVariant2, other.SmsDestinationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SmsDestination obj1, SmsDestination obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsDestination>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SmsDestination obj1, SmsDestination obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsDestination o && Equals(o);
        }
    }
}
