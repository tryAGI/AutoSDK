//HintName: G.Models.PayloadSelector.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies how to treat payload selector
    /// </summary>
    public readonly partial struct PayloadSelector : global::System.IEquatable<PayloadSelector>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadSelectorInclude? Include { get; init; }
#else
        public global::G.PayloadSelectorInclude? Include { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Include))]
#endif
        public bool IsInclude => Include != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadSelectorExclude? Exclude { get; init; }
#else
        public global::G.PayloadSelectorExclude? Exclude { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exclude))]
#endif
        public bool IsExclude => Exclude != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSelector(global::G.PayloadSelectorInclude value) => new PayloadSelector((global::G.PayloadSelectorInclude?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadSelectorInclude?(PayloadSelector @this) => @this.Include;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSelector(global::G.PayloadSelectorInclude? value)
        {
            Include = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadSelector(global::G.PayloadSelectorExclude value) => new PayloadSelector((global::G.PayloadSelectorExclude?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadSelectorExclude?(PayloadSelector @this) => @this.Exclude;

        /// <summary>
        /// 
        /// </summary>
        public PayloadSelector(global::G.PayloadSelectorExclude? value)
        {
            Exclude = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PayloadSelector(
            global::G.PayloadSelectorInclude? include,
            global::G.PayloadSelectorExclude? exclude
            )
        {
            Include = include;
            Exclude = exclude;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Exclude as object ??
            Include as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Include?.ToString() ??
            Exclude?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInclude || IsExclude;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PayloadSelectorInclude?, TResult>? include = null,
            global::System.Func<global::G.PayloadSelectorExclude?, TResult>? exclude = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInclude && include != null)
            {
                return include(Include!);
            }
            else if (IsExclude && exclude != null)
            {
                return exclude(Exclude!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PayloadSelectorInclude?>? include = null,
            global::System.Action<global::G.PayloadSelectorExclude?>? exclude = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInclude)
            {
                include?.Invoke(Include!);
            }
            else if (IsExclude)
            {
                exclude?.Invoke(Exclude!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Include,
                typeof(global::G.PayloadSelectorInclude),
                Exclude,
                typeof(global::G.PayloadSelectorExclude),
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
        public bool Equals(PayloadSelector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadSelectorInclude?>.Default.Equals(Include, other.Include) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadSelectorExclude?>.Default.Equals(Exclude, other.Exclude) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PayloadSelector obj1, PayloadSelector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PayloadSelector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PayloadSelector obj1, PayloadSelector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PayloadSelector o && Equals(o);
        }
    }
}
