//HintName: G.Models.SmsSender.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SmsSender : global::System.IEquatable<SmsSender>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SmsSenderVariant1? SmsSenderVariant1 { get; init; }
#else
        public global::G.SmsSenderVariant1? SmsSenderVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsSenderVariant1))]
#endif
        public bool IsSmsSenderVariant1 => SmsSenderVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SmsSenderVariant2? SmsSenderVariant2 { get; init; }
#else
        public global::G.SmsSenderVariant2? SmsSenderVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsSenderVariant2))]
#endif
        public bool IsSmsSenderVariant2 => SmsSenderVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsSender(global::G.SmsSenderVariant1 value) => new SmsSender((global::G.SmsSenderVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsSenderVariant1?(SmsSender @this) => @this.SmsSenderVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SmsSender(global::G.SmsSenderVariant1? value)
        {
            SmsSenderVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsSender(global::G.SmsSenderVariant2 value) => new SmsSender((global::G.SmsSenderVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsSenderVariant2?(SmsSender @this) => @this.SmsSenderVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SmsSender(global::G.SmsSenderVariant2? value)
        {
            SmsSenderVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SmsSender(
            global::G.SmsSenderVariant1? smsSenderVariant1,
            global::G.SmsSenderVariant2? smsSenderVariant2
            )
        {
            SmsSenderVariant1 = smsSenderVariant1;
            SmsSenderVariant2 = smsSenderVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SmsSenderVariant2 as object ??
            SmsSenderVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SmsSenderVariant1?.ToString() ??
            SmsSenderVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSmsSenderVariant1 && !IsSmsSenderVariant2 || !IsSmsSenderVariant1 && IsSmsSenderVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SmsSenderVariant1?, TResult>? smsSenderVariant1 = null,
            global::System.Func<global::G.SmsSenderVariant2?, TResult>? smsSenderVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSmsSenderVariant1 && smsSenderVariant1 != null)
            {
                return smsSenderVariant1(SmsSenderVariant1!);
            }
            else if (IsSmsSenderVariant2 && smsSenderVariant2 != null)
            {
                return smsSenderVariant2(SmsSenderVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SmsSenderVariant1?>? smsSenderVariant1 = null,
            global::System.Action<global::G.SmsSenderVariant2?>? smsSenderVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSmsSenderVariant1)
            {
                smsSenderVariant1?.Invoke(SmsSenderVariant1!);
            }
            else if (IsSmsSenderVariant2)
            {
                smsSenderVariant2?.Invoke(SmsSenderVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SmsSenderVariant1,
                typeof(global::G.SmsSenderVariant1),
                SmsSenderVariant2,
                typeof(global::G.SmsSenderVariant2),
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
        public bool Equals(SmsSender other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SmsSenderVariant1?>.Default.Equals(SmsSenderVariant1, other.SmsSenderVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SmsSenderVariant2?>.Default.Equals(SmsSenderVariant2, other.SmsSenderVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SmsSender obj1, SmsSender obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsSender>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SmsSender obj1, SmsSender obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsSender o && Equals(o);
        }
    }
}
