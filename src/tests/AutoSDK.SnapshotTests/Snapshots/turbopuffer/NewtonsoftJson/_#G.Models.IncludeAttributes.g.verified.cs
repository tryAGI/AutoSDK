//HintName: G.Models.IncludeAttributes.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to include attributes in the response.
    /// </summary>
    public readonly partial struct IncludeAttributes : global::System.IEquatable<IncludeAttributes>
    {
        /// <summary>
        /// When `true`, include all attributes in the response. When `false`, include no attributes in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? IncludeAttributesVariant1 { get; init; }
#else
        public bool? IncludeAttributesVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IncludeAttributesVariant1))]
#endif
        public bool IsIncludeAttributesVariant1 => IncludeAttributesVariant1 != null;

        /// <summary>
        /// Include exactly the specified attributes in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? IncludeAttributesVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? IncludeAttributesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IncludeAttributesVariant2))]
#endif
        public bool IsIncludeAttributesVariant2 => IncludeAttributesVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludeAttributes(bool value) => new IncludeAttributes((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(IncludeAttributes @this) => @this.IncludeAttributesVariant1;

        /// <summary>
        /// 
        /// </summary>
        public IncludeAttributes(bool? value)
        {
            IncludeAttributesVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IncludeAttributes(
            bool? includeAttributesVariant1,
            global::System.Collections.Generic.IList<string>? includeAttributesVariant2
            )
        {
            IncludeAttributesVariant1 = includeAttributesVariant1;
            IncludeAttributesVariant2 = includeAttributesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IncludeAttributesVariant2 as object ??
            IncludeAttributesVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            IncludeAttributesVariant1?.ToString().ToLowerInvariant() ??
            IncludeAttributesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIncludeAttributesVariant1 && !IsIncludeAttributesVariant2 || !IsIncludeAttributesVariant1 && IsIncludeAttributesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? includeAttributesVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? includeAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIncludeAttributesVariant1 && includeAttributesVariant1 != null)
            {
                return includeAttributesVariant1(IncludeAttributesVariant1!);
            }
            else if (IsIncludeAttributesVariant2 && includeAttributesVariant2 != null)
            {
                return includeAttributesVariant2(IncludeAttributesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? includeAttributesVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? includeAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIncludeAttributesVariant1)
            {
                includeAttributesVariant1?.Invoke(IncludeAttributesVariant1!);
            }
            else if (IsIncludeAttributesVariant2)
            {
                includeAttributesVariant2?.Invoke(IncludeAttributesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IncludeAttributesVariant1,
                typeof(bool),
                IncludeAttributesVariant2,
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
        public bool Equals(IncludeAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(IncludeAttributesVariant1, other.IncludeAttributesVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(IncludeAttributesVariant2, other.IncludeAttributesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludeAttributes obj1, IncludeAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludeAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludeAttributes obj1, IncludeAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludeAttributes o && Equals(o);
        }
    }
}
