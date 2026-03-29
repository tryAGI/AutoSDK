//HintName: G.Models.QuantizationConfigDiff.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct QuantizationConfigDiff : global::System.IEquatable<QuantizationConfigDiff>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ScalarQuantization? Scalar { get; init; }
#else
        public global::G.ScalarQuantization? Scalar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scalar))]
#endif
        public bool IsScalar => Scalar != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ProductQuantization? Product { get; init; }
#else
        public global::G.ProductQuantization? Product { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Product))]
#endif
        public bool IsProduct => Product != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BinaryQuantization? Binary { get; init; }
#else
        public global::G.BinaryQuantization? Binary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Binary))]
#endif
        public bool IsBinary => Binary != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DisabledType? DisabledType { get; init; }
#else
        public global::G.DisabledType? DisabledType { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DisabledType))]
#endif
        public bool IsDisabledType => DisabledType != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QuantizationConfigDiff(global::G.ScalarQuantization value) => new QuantizationConfigDiff((global::G.ScalarQuantization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ScalarQuantization?(QuantizationConfigDiff @this) => @this.Scalar;

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(global::G.ScalarQuantization? value)
        {
            Scalar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QuantizationConfigDiff(global::G.ProductQuantization value) => new QuantizationConfigDiff((global::G.ProductQuantization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProductQuantization?(QuantizationConfigDiff @this) => @this.Product;

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(global::G.ProductQuantization? value)
        {
            Product = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QuantizationConfigDiff(global::G.BinaryQuantization value) => new QuantizationConfigDiff((global::G.BinaryQuantization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BinaryQuantization?(QuantizationConfigDiff @this) => @this.Binary;

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(global::G.BinaryQuantization? value)
        {
            Binary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QuantizationConfigDiff(global::G.DisabledType value) => new QuantizationConfigDiff((global::G.DisabledType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DisabledType?(QuantizationConfigDiff @this) => @this.DisabledType;

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(global::G.DisabledType? value)
        {
            DisabledType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QuantizationConfigDiff(
            global::G.ScalarQuantization? scalar,
            global::G.ProductQuantization? product,
            global::G.BinaryQuantization? binary,
            global::G.DisabledType? disabledType
            )
        {
            Scalar = scalar;
            Product = product;
            Binary = binary;
            DisabledType = disabledType;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DisabledType as object ??
            Binary as object ??
            Product as object ??
            Scalar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Scalar?.ToString() ??
            Product?.ToString() ??
            Binary?.ToString() ??
            DisabledType?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScalar || IsProduct || IsBinary || IsDisabledType;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ScalarQuantization?, TResult>? scalar = null,
            global::System.Func<global::G.ProductQuantization?, TResult>? product = null,
            global::System.Func<global::G.BinaryQuantization?, TResult>? binary = null,
            global::System.Func<global::G.DisabledType?, TResult>? disabledType = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScalar && scalar != null)
            {
                return scalar(Scalar!);
            }
            else if (IsProduct && product != null)
            {
                return product(Product!);
            }
            else if (IsBinary && binary != null)
            {
                return binary(Binary!);
            }
            else if (IsDisabledType && disabledType != null)
            {
                return disabledType(DisabledType!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ScalarQuantization?>? scalar = null,
            global::System.Action<global::G.ProductQuantization?>? product = null,
            global::System.Action<global::G.BinaryQuantization?>? binary = null,
            global::System.Action<global::G.DisabledType?>? disabledType = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScalar)
            {
                scalar?.Invoke(Scalar!);
            }
            else if (IsProduct)
            {
                product?.Invoke(Product!);
            }
            else if (IsBinary)
            {
                binary?.Invoke(Binary!);
            }
            else if (IsDisabledType)
            {
                disabledType?.Invoke(DisabledType!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Scalar,
                typeof(global::G.ScalarQuantization),
                Product,
                typeof(global::G.ProductQuantization),
                Binary,
                typeof(global::G.BinaryQuantization),
                DisabledType,
                typeof(global::G.DisabledType),
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
        public bool Equals(QuantizationConfigDiff other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ScalarQuantization?>.Default.Equals(Scalar, other.Scalar) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ProductQuantization?>.Default.Equals(Product, other.Product) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BinaryQuantization?>.Default.Equals(Binary, other.Binary) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DisabledType?>.Default.Equals(DisabledType, other.DisabledType) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QuantizationConfigDiff obj1, QuantizationConfigDiff obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QuantizationConfigDiff>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QuantizationConfigDiff obj1, QuantizationConfigDiff obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QuantizationConfigDiff o && Equals(o);
        }
    }
}
