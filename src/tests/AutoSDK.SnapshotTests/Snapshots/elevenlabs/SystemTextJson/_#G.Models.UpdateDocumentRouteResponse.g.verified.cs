//HintName: G.Models.UpdateDocumentRouteResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateDocumentRouteResponse : global::System.IEquatable<UpdateDocumentRouteResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateDocumentRouteResponseDiscriminatorType? Type { get; }

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
#if NET6_0_OR_GREATER
        public global::G.GetKnowledgeBaseFolderResponseModel? Folder { get; init; }
#else
        public global::G.GetKnowledgeBaseFolderResponseModel? Folder { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Folder))]
#endif
        public bool IsFolder => Folder != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateDocumentRouteResponse(global::G.GetKnowledgeBaseURLResponseModel value) => new UpdateDocumentRouteResponse((global::G.GetKnowledgeBaseURLResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseURLResponseModel?(UpdateDocumentRouteResponse @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(global::G.GetKnowledgeBaseURLResponseModel? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateDocumentRouteResponse(global::G.GetKnowledgeBaseFileResponseModel value) => new UpdateDocumentRouteResponse((global::G.GetKnowledgeBaseFileResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseFileResponseModel?(UpdateDocumentRouteResponse @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(global::G.GetKnowledgeBaseFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateDocumentRouteResponse(global::G.GetKnowledgeBaseTextResponseModel value) => new UpdateDocumentRouteResponse((global::G.GetKnowledgeBaseTextResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseTextResponseModel?(UpdateDocumentRouteResponse @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(global::G.GetKnowledgeBaseTextResponseModel? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateDocumentRouteResponse(global::G.GetKnowledgeBaseFolderResponseModel value) => new UpdateDocumentRouteResponse((global::G.GetKnowledgeBaseFolderResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseFolderResponseModel?(UpdateDocumentRouteResponse @this) => @this.Folder;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(global::G.GetKnowledgeBaseFolderResponseModel? value)
        {
            Folder = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(
            global::G.UpdateDocumentRouteResponseDiscriminatorType? type,
            global::G.GetKnowledgeBaseURLResponseModel? url,
            global::G.GetKnowledgeBaseFileResponseModel? file,
            global::G.GetKnowledgeBaseTextResponseModel? text,
            global::G.GetKnowledgeBaseFolderResponseModel? folder
            )
        {
            Type = type;

            Url = url;
            File = file;
            Text = text;
            Folder = folder;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Folder as object ??
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
            Text?.ToString() ??
            Folder?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUrl && !IsFile && !IsText && !IsFolder || !IsUrl && IsFile && !IsText && !IsFolder || !IsUrl && !IsFile && IsText && !IsFolder || !IsUrl && !IsFile && !IsText && IsFolder;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GetKnowledgeBaseURLResponseModel?, TResult>? url = null,
            global::System.Func<global::G.GetKnowledgeBaseFileResponseModel?, TResult>? file = null,
            global::System.Func<global::G.GetKnowledgeBaseTextResponseModel?, TResult>? text = null,
            global::System.Func<global::G.GetKnowledgeBaseFolderResponseModel?, TResult>? folder = null,
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
            else if (IsFolder && folder != null)
            {
                return folder(Folder!);
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
            global::System.Action<global::G.GetKnowledgeBaseFolderResponseModel?>? folder = null,
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
            else if (IsFolder)
            {
                folder?.Invoke(Folder!);
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
                Folder,
                typeof(global::G.GetKnowledgeBaseFolderResponseModel),
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
        public bool Equals(UpdateDocumentRouteResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseURLResponseModel?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseFileResponseModel?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseTextResponseModel?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseFolderResponseModel?>.Default.Equals(Folder, other.Folder) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateDocumentRouteResponse obj1, UpdateDocumentRouteResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateDocumentRouteResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateDocumentRouteResponse obj1, UpdateDocumentRouteResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateDocumentRouteResponse o && Equals(o);
        }
    }
}
