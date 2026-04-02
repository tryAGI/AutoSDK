//HintName: G.Models.Vector2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A vector embedding associated with a document.
    /// </summary>
    public readonly partial struct Vector2 : global::System.IEquatable<Vector2>
    {
        /// <summary>
        /// A dense vector encoded as an array of floats.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<double>? VectorVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<double>? VectorVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorVariant1))]
#endif
        public bool IsVectorVariant1 => VectorVariant1 != null;

        /// <summary>
        /// A dense vector encoded as a base64 string.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VectorVariant2 { get; init; }
#else
        public string? VectorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorVariant2))]
#endif
        public bool IsVectorVariant2 => VectorVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Vector2(string value) => new Vector2((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Vector2 @this) => @this.VectorVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Vector2(string? value)
        {
            VectorVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Vector2(
            global::System.Collections.Generic.IList<double>? vectorVariant1,
            string? vectorVariant2
            )
        {
            VectorVariant1 = vectorVariant1;
            VectorVariant2 = vectorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorVariant2 as object ??
            VectorVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorVariant1?.ToString() ??
            VectorVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorVariant1 && !IsVectorVariant2 || !IsVectorVariant1 && IsVectorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<double>?, TResult>? vectorVariant1 = null,
            global::System.Func<string?, TResult>? vectorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorVariant1 && vectorVariant1 != null)
            {
                return vectorVariant1(VectorVariant1!);
            }
            else if (IsVectorVariant2 && vectorVariant2 != null)
            {
                return vectorVariant2(VectorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<double>?>? vectorVariant1 = null,
            global::System.Action<string?>? vectorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorVariant1)
            {
                vectorVariant1?.Invoke(VectorVariant1!);
            }
            else if (IsVectorVariant2)
            {
                vectorVariant2?.Invoke(VectorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorVariant1,
                typeof(global::System.Collections.Generic.IList<double>),
                VectorVariant2,
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
        public bool Equals(Vector2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<double>?>.Default.Equals(VectorVariant1, other.VectorVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VectorVariant2, other.VectorVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Vector2 obj1, Vector2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Vector2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Vector2 obj1, Vector2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Vector2 o && Equals(o);
        }
    }
}
