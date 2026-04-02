//HintName: G.Models.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema : global::System.IEquatable<IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 { get; init; }
#else
        public string? IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1))]
#endif
        public bool IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 => IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 { get; init; }
#else
        public double? IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2))]
#endif
        public bool IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 => IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 { get; init; }
#else
        public bool? IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3))]
#endif
        public bool IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 => IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema(string value) => new IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema @this) => @this.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1;

        /// <summary>
        /// 
        /// </summary>
        public IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema(string? value)
        {
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema(double value) => new IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema @this) => @this.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2;

        /// <summary>
        /// 
        /// </summary>
        public IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema(double? value)
        {
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema(bool value) => new IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema @this) => @this.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3;

        /// <summary>
        /// 
        /// </summary>
        public IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema(bool? value)
        {
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema(
            string? indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1,
            double? indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2,
            bool? indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3
            )
        {
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 = indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1;
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 = indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2;
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 = indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 as object ??
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 as object ??
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1?.ToString() ??
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2?.ToString() ??
            IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 && !IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 && !IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 || !IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 && IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 && !IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 || !IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 && !IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 && IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 = null,
            global::System.Func<double?, TResult>? indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 = null,
            global::System.Func<bool?, TResult>? indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 && indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 != null)
            {
                return indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1!);
            }
            else if (IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 && indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 != null)
            {
                return indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2!);
            }
            else if (IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 && indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 != null)
            {
                return indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1 = null,
            global::System.Action<double?>? indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2 = null,
            global::System.Action<bool?>? indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1)
            {
                indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1?.Invoke(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1!);
            }
            else if (IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2)
            {
                indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2?.Invoke(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2!);
            }
            else if (IsIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3)
            {
                indexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3?.Invoke(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1,
                typeof(string),
                IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2,
                typeof(double),
                IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3,
                typeof(bool),
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
        public bool Equals(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1, other.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2, other.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3, other.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema obj1, IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema obj1, IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema o && Equals(o);
        }
    }
}
