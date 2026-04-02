//HintName: G.Models.Crop.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Crop : global::System.IEquatable<Crop>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CropVariant1? CropVariant1 { get; init; }
#else
        public global::G.CropVariant1? CropVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CropVariant1))]
#endif
        public bool IsCropVariant1 => CropVariant1 != null;

        /// <summary>
        /// Custom crop
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CropVariant2? CropVariant2 { get; init; }
#else
        public global::G.CropVariant2? CropVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CropVariant2))]
#endif
        public bool IsCropVariant2 => CropVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Crop(global::G.CropVariant1 value) => new Crop((global::G.CropVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CropVariant1?(Crop @this) => @this.CropVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Crop(global::G.CropVariant1? value)
        {
            CropVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Crop(global::G.CropVariant2 value) => new Crop((global::G.CropVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CropVariant2?(Crop @this) => @this.CropVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Crop(global::G.CropVariant2? value)
        {
            CropVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Crop(
            global::G.CropVariant1? cropVariant1,
            global::G.CropVariant2? cropVariant2
            )
        {
            CropVariant1 = cropVariant1;
            CropVariant2 = cropVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CropVariant2 as object ??
            CropVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CropVariant1?.ToString() ??
            CropVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCropVariant1 || IsCropVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CropVariant1?, TResult>? cropVariant1 = null,
            global::System.Func<global::G.CropVariant2?, TResult>? cropVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCropVariant1 && cropVariant1 != null)
            {
                return cropVariant1(CropVariant1!);
            }
            else if (IsCropVariant2 && cropVariant2 != null)
            {
                return cropVariant2(CropVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CropVariant1?>? cropVariant1 = null,
            global::System.Action<global::G.CropVariant2?>? cropVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCropVariant1)
            {
                cropVariant1?.Invoke(CropVariant1!);
            }
            else if (IsCropVariant2)
            {
                cropVariant2?.Invoke(CropVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CropVariant1,
                typeof(global::G.CropVariant1),
                CropVariant2,
                typeof(global::G.CropVariant2),
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
        public bool Equals(Crop other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CropVariant1?>.Default.Equals(CropVariant1, other.CropVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CropVariant2?>.Default.Equals(CropVariant2, other.CropVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Crop obj1, Crop obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Crop>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Crop obj1, Crop obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Crop o && Equals(o);
        }
    }
}
