//HintName: G.Models.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse : global::System.IEquatable<UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetKnowledgeBaseURLResponseModel? Url { get; init; }
#else
        public global::G.GetKnowledgeBaseURLResponseModel? Url { get; }
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
        public static implicit operator UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::G.GetKnowledgeBaseURLResponseModel value) => new UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse((global::G.GetKnowledgeBaseURLResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseURLResponseModel?(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::G.GetKnowledgeBaseURLResponseModel? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetKnowledgeBaseFileResponseModel? File { get; init; }
#else
        public global::G.GetKnowledgeBaseFileResponseModel? File { get; }
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
        public static implicit operator UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::G.GetKnowledgeBaseFileResponseModel value) => new UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse((global::G.GetKnowledgeBaseFileResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseFileResponseModel?(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::G.GetKnowledgeBaseFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetKnowledgeBaseTextResponseModel? Text { get; init; }
#else
        public global::G.GetKnowledgeBaseTextResponseModel? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::G.GetKnowledgeBaseTextResponseModel value) => new UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse((global::G.GetKnowledgeBaseTextResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseTextResponseModel?(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::G.GetKnowledgeBaseTextResponseModel? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(
            global::G.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType? type,
            global::G.GetKnowledgeBaseURLResponseModel? url,
            global::G.GetKnowledgeBaseFileResponseModel? file,
            global::G.GetKnowledgeBaseTextResponseModel? text
            )
        {
            Type = type;

            Url = url;
            File = file;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            File as object ??
            Url as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Url?.ToString() ??
            File?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUrl && !IsFile && !IsText || !IsUrl && IsFile && !IsText || !IsUrl && !IsFile && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GetKnowledgeBaseURLResponseModel?, TResult>? url = null,
            global::System.Func<global::G.GetKnowledgeBaseFileResponseModel?, TResult>? file = null,
            global::System.Func<global::G.GetKnowledgeBaseTextResponseModel?, TResult>? text = null,
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
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GetKnowledgeBaseURLResponseModel?>? url = null,
            global::System.Action<global::G.GetKnowledgeBaseFileResponseModel?>? file = null,
            global::System.Action<global::G.GetKnowledgeBaseTextResponseModel?>? text = null,
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
            else if (IsText)
            {
                text?.Invoke(Text!);
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
                typeof(global::G.GetKnowledgeBaseURLResponseModel),
                File,
                typeof(global::G.GetKnowledgeBaseFileResponseModel),
                Text,
                typeof(global::G.GetKnowledgeBaseTextResponseModel),
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
        public bool Equals(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseURLResponseModel?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseFileResponseModel?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseTextResponseModel?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse obj1, UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse obj1, UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse o && Equals(o);
        }
    }
}
