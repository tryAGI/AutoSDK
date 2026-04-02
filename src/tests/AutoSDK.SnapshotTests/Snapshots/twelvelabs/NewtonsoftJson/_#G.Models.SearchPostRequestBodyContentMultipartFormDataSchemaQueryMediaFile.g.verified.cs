//HintName: G.Models.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A local media file to use as a query. This parameter is required for media queries if `query_media_url` is not provided.<br/>
    /// You can provide up to 10 images by specifying this parameter multiple times (Marengo 3.0 only):<br/>
    /// ```<br/>
    /// --form query_media_file=@/path/to/image1.jpg \<br/>
    /// --form query_media_file=@/path/to/image2.jpg<br/>
    /// ```
    /// </summary>
    public readonly partial struct SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile : global::System.IEquatable<SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 { get; init; }
#else
        public byte[]? SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1))]
#endif
        public bool IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 => SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<byte[]>? SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<byte[]>? SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2))]
#endif
        public bool IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 => SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile(byte[] value) => new SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile @this) => @this.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile(byte[]? value)
        {
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile(
            byte[]? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1,
            global::System.Collections.Generic.IList<byte[]>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2
            )
        {
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 = searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1;
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 = searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 as object ??
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1?.ToString() ??
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 && !IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 || !IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 && IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[]?, TResult>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<byte[]>?, TResult>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 && searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 != null)
            {
                return searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1!);
            }
            else if (IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 && searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 != null)
            {
                return searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]?>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<byte[]>?>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1)
            {
                searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1?.Invoke(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1!);
            }
            else if (IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2)
            {
                searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2?.Invoke(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1,
                typeof(byte[]),
                SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2,
                typeof(global::System.Collections.Generic.IList<byte[]>),
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
        public bool Equals(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1, other.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<byte[]>?>.Default.Equals(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2, other.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile obj1, SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile obj1, SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile o && Equals(o);
        }
    }
}
