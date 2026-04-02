//HintName: G.Models.AssetDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Union type for asset operations (create or update)
    /// </summary>
    public readonly partial struct AssetDto : global::System.IEquatable<AssetDto>
    {
        /// <summary>
        /// DTO for creating a new asset
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssetDtoVariant1? AssetDtoVariant1 { get; init; }
#else
        public global::G.AssetDtoVariant1? AssetDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssetDtoVariant1))]
#endif
        public bool IsAssetDtoVariant1 => AssetDtoVariant1 != null;

        /// <summary>
        /// DTO for updating an existing asset
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssetDtoVariant2? AssetDtoVariant2 { get; init; }
#else
        public global::G.AssetDtoVariant2? AssetDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssetDtoVariant2))]
#endif
        public bool IsAssetDtoVariant2 => AssetDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssetDto(global::G.AssetDtoVariant1 value) => new AssetDto((global::G.AssetDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssetDtoVariant1?(AssetDto @this) => @this.AssetDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AssetDto(global::G.AssetDtoVariant1? value)
        {
            AssetDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssetDto(global::G.AssetDtoVariant2 value) => new AssetDto((global::G.AssetDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssetDtoVariant2?(AssetDto @this) => @this.AssetDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AssetDto(global::G.AssetDtoVariant2? value)
        {
            AssetDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssetDto(
            global::G.AssetDtoVariant1? assetDtoVariant1,
            global::G.AssetDtoVariant2? assetDtoVariant2
            )
        {
            AssetDtoVariant1 = assetDtoVariant1;
            AssetDtoVariant2 = assetDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AssetDtoVariant2 as object ??
            AssetDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AssetDtoVariant1?.ToString() ??
            AssetDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAssetDtoVariant1 || IsAssetDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AssetDtoVariant1?, TResult>? assetDtoVariant1 = null,
            global::System.Func<global::G.AssetDtoVariant2?, TResult>? assetDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssetDtoVariant1 && assetDtoVariant1 != null)
            {
                return assetDtoVariant1(AssetDtoVariant1!);
            }
            else if (IsAssetDtoVariant2 && assetDtoVariant2 != null)
            {
                return assetDtoVariant2(AssetDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AssetDtoVariant1?>? assetDtoVariant1 = null,
            global::System.Action<global::G.AssetDtoVariant2?>? assetDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssetDtoVariant1)
            {
                assetDtoVariant1?.Invoke(AssetDtoVariant1!);
            }
            else if (IsAssetDtoVariant2)
            {
                assetDtoVariant2?.Invoke(AssetDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AssetDtoVariant1,
                typeof(global::G.AssetDtoVariant1),
                AssetDtoVariant2,
                typeof(global::G.AssetDtoVariant2),
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
        public bool Equals(AssetDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AssetDtoVariant1?>.Default.Equals(AssetDtoVariant1, other.AssetDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssetDtoVariant2?>.Default.Equals(AssetDtoVariant2, other.AssetDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AssetDto obj1, AssetDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssetDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AssetDto obj1, AssetDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssetDto o && Equals(o);
        }
    }
}
