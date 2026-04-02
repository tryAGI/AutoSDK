//HintName: G.Models.WithVector.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Options for specifying which vector to include
    /// </summary>
    public readonly partial struct WithVector : global::System.IEquatable<WithVector>
    {
        /// <summary>
        /// If `true` - return all vector, If `false` - do not return vector
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? WithVectorVariant1 { get; init; }
#else
        public bool? WithVectorVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WithVectorVariant1))]
#endif
        public bool IsWithVectorVariant1 => WithVectorVariant1 != null;

        /// <summary>
        /// Specify which vector to return
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? WithVectorVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? WithVectorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WithVectorVariant2))]
#endif
        public bool IsWithVectorVariant2 => WithVectorVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WithVector(bool value) => new WithVector((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(WithVector @this) => @this.WithVectorVariant1;

        /// <summary>
        /// 
        /// </summary>
        public WithVector(bool? value)
        {
            WithVectorVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WithVector(
            bool? withVectorVariant1,
            global::System.Collections.Generic.IList<string>? withVectorVariant2
            )
        {
            WithVectorVariant1 = withVectorVariant1;
            WithVectorVariant2 = withVectorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WithVectorVariant2 as object ??
            WithVectorVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WithVectorVariant1?.ToString().ToLowerInvariant() ??
            WithVectorVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWithVectorVariant1 || IsWithVectorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? withVectorVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? withVectorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWithVectorVariant1 && withVectorVariant1 != null)
            {
                return withVectorVariant1(WithVectorVariant1!);
            }
            else if (IsWithVectorVariant2 && withVectorVariant2 != null)
            {
                return withVectorVariant2(WithVectorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? withVectorVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? withVectorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWithVectorVariant1)
            {
                withVectorVariant1?.Invoke(WithVectorVariant1!);
            }
            else if (IsWithVectorVariant2)
            {
                withVectorVariant2?.Invoke(WithVectorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WithVectorVariant1,
                typeof(bool),
                WithVectorVariant2,
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
        public bool Equals(WithVector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(WithVectorVariant1, other.WithVectorVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(WithVectorVariant2, other.WithVectorVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WithVector obj1, WithVector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WithVector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WithVector obj1, WithVector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WithVector o && Equals(o);
        }
    }
}
