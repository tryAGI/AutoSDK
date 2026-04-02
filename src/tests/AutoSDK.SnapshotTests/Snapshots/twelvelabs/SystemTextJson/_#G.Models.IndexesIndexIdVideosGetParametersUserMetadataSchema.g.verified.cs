//HintName: G.Models.IndexesIndexIdVideosGetParametersUserMetadataSchema.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IndexesIndexIdVideosGetParametersUserMetadataSchema : global::System.IEquatable<IndexesIndexIdVideosGetParametersUserMetadataSchema>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 { get; init; }
#else
        public string? IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1))]
#endif
        public bool IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 => IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 { get; init; }
#else
        public double? IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2))]
#endif
        public bool IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 => IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 { get; init; }
#else
        public bool? IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3))]
#endif
        public bool IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 => IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexesIndexIdVideosGetParametersUserMetadataSchema(string value) => new IndexesIndexIdVideosGetParametersUserMetadataSchema((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(IndexesIndexIdVideosGetParametersUserMetadataSchema @this) => @this.IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1;

        /// <summary>
        /// 
        /// </summary>
        public IndexesIndexIdVideosGetParametersUserMetadataSchema(string? value)
        {
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexesIndexIdVideosGetParametersUserMetadataSchema(double value) => new IndexesIndexIdVideosGetParametersUserMetadataSchema((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(IndexesIndexIdVideosGetParametersUserMetadataSchema @this) => @this.IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2;

        /// <summary>
        /// 
        /// </summary>
        public IndexesIndexIdVideosGetParametersUserMetadataSchema(double? value)
        {
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexesIndexIdVideosGetParametersUserMetadataSchema(bool value) => new IndexesIndexIdVideosGetParametersUserMetadataSchema((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(IndexesIndexIdVideosGetParametersUserMetadataSchema @this) => @this.IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3;

        /// <summary>
        /// 
        /// </summary>
        public IndexesIndexIdVideosGetParametersUserMetadataSchema(bool? value)
        {
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IndexesIndexIdVideosGetParametersUserMetadataSchema(
            string? indexesIndexIdVideosGetParametersUserMetadataSchemaVariant1,
            double? indexesIndexIdVideosGetParametersUserMetadataSchemaVariant2,
            bool? indexesIndexIdVideosGetParametersUserMetadataSchemaVariant3
            )
        {
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 = indexesIndexIdVideosGetParametersUserMetadataSchemaVariant1;
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 = indexesIndexIdVideosGetParametersUserMetadataSchemaVariant2;
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 = indexesIndexIdVideosGetParametersUserMetadataSchemaVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 as object ??
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 as object ??
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1?.ToString() ??
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2?.ToString() ??
            IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 && !IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 && !IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 || !IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 && IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 && !IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 || !IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 && !IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 && IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? indexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 = null,
            global::System.Func<double?, TResult>? indexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 = null,
            global::System.Func<bool?, TResult>? indexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 && indexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 != null)
            {
                return indexesIndexIdVideosGetParametersUserMetadataSchemaVariant1(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1!);
            }
            else if (IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 && indexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 != null)
            {
                return indexesIndexIdVideosGetParametersUserMetadataSchemaVariant2(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2!);
            }
            else if (IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 && indexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 != null)
            {
                return indexesIndexIdVideosGetParametersUserMetadataSchemaVariant3(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? indexesIndexIdVideosGetParametersUserMetadataSchemaVariant1 = null,
            global::System.Action<double?>? indexesIndexIdVideosGetParametersUserMetadataSchemaVariant2 = null,
            global::System.Action<bool?>? indexesIndexIdVideosGetParametersUserMetadataSchemaVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1)
            {
                indexesIndexIdVideosGetParametersUserMetadataSchemaVariant1?.Invoke(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1!);
            }
            else if (IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2)
            {
                indexesIndexIdVideosGetParametersUserMetadataSchemaVariant2?.Invoke(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2!);
            }
            else if (IsIndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3)
            {
                indexesIndexIdVideosGetParametersUserMetadataSchemaVariant3?.Invoke(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1,
                typeof(string),
                IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2,
                typeof(double),
                IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3,
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
        public bool Equals(IndexesIndexIdVideosGetParametersUserMetadataSchema other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1, other.IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2, other.IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3, other.IndexesIndexIdVideosGetParametersUserMetadataSchemaVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IndexesIndexIdVideosGetParametersUserMetadataSchema obj1, IndexesIndexIdVideosGetParametersUserMetadataSchema obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IndexesIndexIdVideosGetParametersUserMetadataSchema>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IndexesIndexIdVideosGetParametersUserMetadataSchema obj1, IndexesIndexIdVideosGetParametersUserMetadataSchema obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IndexesIndexIdVideosGetParametersUserMetadataSchema o && Equals(o);
        }
    }
}
