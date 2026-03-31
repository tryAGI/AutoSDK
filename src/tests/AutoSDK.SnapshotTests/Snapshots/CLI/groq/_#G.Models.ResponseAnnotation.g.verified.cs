//HintName: G.Models.ResponseAnnotation.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseAnnotation : global::System.IEquatable<ResponseAnnotation>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseAnnotationDiscriminatorType? Type { get; }

        /// <summary>
        /// A citation to a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFileCitation? FileCitation { get; init; }
#else
        public global::G.ResponseFileCitation? FileCitation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileCitation))]
#endif
        public bool IsFileCitation => FileCitation != null;

        /// <summary>
        /// A citation for a web resource.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseUrlCitation? UrlCitation { get; init; }
#else
        public global::G.ResponseUrlCitation? UrlCitation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UrlCitation))]
#endif
        public bool IsUrlCitation => UrlCitation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseAnnotation(global::G.ResponseFileCitation value) => new ResponseAnnotation((global::G.ResponseFileCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFileCitation?(ResponseAnnotation @this) => @this.FileCitation;

        /// <summary>
        /// 
        /// </summary>
        public ResponseAnnotation(global::G.ResponseFileCitation? value)
        {
            FileCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseAnnotation(global::G.ResponseUrlCitation value) => new ResponseAnnotation((global::G.ResponseUrlCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseUrlCitation?(ResponseAnnotation @this) => @this.UrlCitation;

        /// <summary>
        /// 
        /// </summary>
        public ResponseAnnotation(global::G.ResponseUrlCitation? value)
        {
            UrlCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseAnnotation(
            global::G.ResponseAnnotationDiscriminatorType? type,
            global::G.ResponseFileCitation? fileCitation,
            global::G.ResponseUrlCitation? urlCitation
            )
        {
            Type = type;

            FileCitation = fileCitation;
            UrlCitation = urlCitation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UrlCitation as object ??
            FileCitation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileCitation?.ToString() ??
            UrlCitation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitation && !IsUrlCitation || !IsFileCitation && IsUrlCitation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseFileCitation?, TResult>? fileCitation = null,
            global::System.Func<global::G.ResponseUrlCitation?, TResult>? urlCitation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitation && fileCitation != null)
            {
                return fileCitation(FileCitation!);
            }
            else if (IsUrlCitation && urlCitation != null)
            {
                return urlCitation(UrlCitation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseFileCitation?>? fileCitation = null,
            global::System.Action<global::G.ResponseUrlCitation?>? urlCitation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitation)
            {
                fileCitation?.Invoke(FileCitation!);
            }
            else if (IsUrlCitation)
            {
                urlCitation?.Invoke(UrlCitation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileCitation,
                typeof(global::G.ResponseFileCitation),
                UrlCitation,
                typeof(global::G.ResponseUrlCitation),
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
        public bool Equals(ResponseAnnotation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFileCitation?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseUrlCitation?>.Default.Equals(UrlCitation, other.UrlCitation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseAnnotation obj1, ResponseAnnotation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseAnnotation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseAnnotation obj1, ResponseAnnotation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseAnnotation o && Equals(o);
        }
    }
}
