//HintName: G.Models.DocumentsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DocumentsItem : global::System.IEquatable<DocumentsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetKnowledgeBaseSummaryURLResponseModel? Url { get; init; }
#else
        public global::G.GetKnowledgeBaseSummaryURLResponseModel? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentsItem(global::G.GetKnowledgeBaseSummaryURLResponseModel value) => new DocumentsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseSummaryURLResponseModel?(DocumentsItem @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public DocumentsItem(global::G.GetKnowledgeBaseSummaryURLResponseModel? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetKnowledgeBaseSummaryFileResponseModel? File { get; init; }
#else
        public global::G.GetKnowledgeBaseSummaryFileResponseModel? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentsItem(global::G.GetKnowledgeBaseSummaryFileResponseModel value) => new DocumentsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseSummaryFileResponseModel?(DocumentsItem @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public DocumentsItem(global::G.GetKnowledgeBaseSummaryFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentsItem(
            global::G.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? type,
            global::G.GetKnowledgeBaseSummaryURLResponseModel? url,
            global::G.GetKnowledgeBaseSummaryFileResponseModel? file
            )
        {
            Type = type;

            Url = url;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Url as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUrl && !IsFile || !IsUrl && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GetKnowledgeBaseSummaryURLResponseModel?, TResult>? url = null,
            global::System.Func<global::G.GetKnowledgeBaseSummaryFileResponseModel?, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl && url != null)
            {
                return url(Url!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GetKnowledgeBaseSummaryURLResponseModel?>? url = null,
            global::System.Action<global::G.GetKnowledgeBaseSummaryFileResponseModel?>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl)
            {
                url?.Invoke(Url!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Url,
                typeof(global::G.GetKnowledgeBaseSummaryURLResponseModel),
                File,
                typeof(global::G.GetKnowledgeBaseSummaryFileResponseModel),
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
        public bool Equals(DocumentsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseSummaryURLResponseModel?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseSummaryFileResponseModel?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DocumentsItem obj1, DocumentsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DocumentsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DocumentsItem obj1, DocumentsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DocumentsItem o && Equals(o);
        }
    }
}
