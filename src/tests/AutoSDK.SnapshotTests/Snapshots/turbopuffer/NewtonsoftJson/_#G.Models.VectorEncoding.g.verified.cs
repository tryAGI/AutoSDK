//HintName: G.Models.VectorEncoding.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The encoding to use for vectors in the response.
    /// </summary>
    public readonly partial struct VectorEncoding : global::System.IEquatable<VectorEncoding>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VectorEncodingVariant1 { get; init; }
#else
        public string? VectorEncodingVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorEncodingVariant1))]
#endif
        public bool IsVectorEncodingVariant1 => VectorEncodingVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VectorEncodingVariant2 { get; init; }
#else
        public string? VectorEncodingVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorEncodingVariant2))]
#endif
        public bool IsVectorEncodingVariant2 => VectorEncodingVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorEncoding(string value) => new VectorEncoding((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(VectorEncoding @this) => @this.VectorEncodingVariant1;

        /// <summary>
        /// 
        /// </summary>
        public VectorEncoding(string? value)
        {
            VectorEncodingVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorEncoding(
            string? vectorEncodingVariant1,
            string? vectorEncodingVariant2
            )
        {
            VectorEncodingVariant1 = vectorEncodingVariant1;
            VectorEncodingVariant2 = vectorEncodingVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorEncodingVariant2 as object ??
            VectorEncodingVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorEncodingVariant1?.ToString() ??
            VectorEncodingVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorEncodingVariant1 && !IsVectorEncodingVariant2 || !IsVectorEncodingVariant1 && IsVectorEncodingVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? vectorEncodingVariant1 = null,
            global::System.Func<string?, TResult>? vectorEncodingVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorEncodingVariant1 && vectorEncodingVariant1 != null)
            {
                return vectorEncodingVariant1(VectorEncodingVariant1!);
            }
            else if (IsVectorEncodingVariant2 && vectorEncodingVariant2 != null)
            {
                return vectorEncodingVariant2(VectorEncodingVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? vectorEncodingVariant1 = null,
            global::System.Action<string?>? vectorEncodingVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorEncodingVariant1)
            {
                vectorEncodingVariant1?.Invoke(VectorEncodingVariant1!);
            }
            else if (IsVectorEncodingVariant2)
            {
                vectorEncodingVariant2?.Invoke(VectorEncodingVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorEncodingVariant1,
                typeof(string),
                VectorEncodingVariant2,
                typeof(string),
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
        public bool Equals(VectorEncoding other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VectorEncodingVariant1, other.VectorEncodingVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VectorEncodingVariant2, other.VectorEncodingVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorEncoding obj1, VectorEncoding obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorEncoding>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorEncoding obj1, VectorEncoding obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorEncoding o && Equals(o);
        }
    }
}
