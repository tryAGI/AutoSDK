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
        public byte[]? Value1 { get; init; }
#else
        public byte[]? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<byte[]>? Value2 { get; init; }
#else
        public global::System.Collections.Generic.IList<byte[]>? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile(byte[] value) => new SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile(byte[]? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile(
            byte[]? value1,
            global::System.Collections.Generic.IList<byte[]>? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[]?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<byte[]>?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<byte[]>?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(byte[]),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<byte[]>?>.Default.Equals(Value2, other.Value2) 
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
