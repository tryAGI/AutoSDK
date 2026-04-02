//HintName: G.Models.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The publicly accessible URL of a media file to use as a query. This parameter is required for media queries if `query_media_file` is not provided.<br/>
    /// You can provide up to 10 images by specifying this parameter multiple times (Marengo 3.0 only):<br/>
    /// ```<br/>
    /// --form query_media_url=https://example.com/image1.jpg \<br/>
    /// --form query_media_url=https://example.com/image2.jpg<br/>
    /// ```
    /// </summary>
    public readonly partial struct SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl : global::System.IEquatable<SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 { get; init; }
#else
        public string? SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1))]
#endif
        public bool IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 => SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2))]
#endif
        public bool IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 => SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl(string value) => new SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl @this) => @this.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl(string? value)
        {
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl(
            string? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1,
            global::System.Collections.Generic.IList<string>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2
            )
        {
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 = searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1;
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 = searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 as object ??
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1?.ToString() ??
            SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 && !IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 || !IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 && IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 && searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 != null)
            {
                return searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1!);
            }
            else if (IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 && searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 != null)
            {
                return searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1)
            {
                searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1?.Invoke(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1!);
            }
            else if (IsSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2)
            {
                searchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2?.Invoke(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1,
                typeof(string),
                SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2,
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
        public bool Equals(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1, other.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2, other.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl obj1, SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl obj1, SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl o && Equals(o);
        }
    }
}
