//HintName: G.Models.Data.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Data : global::System.IEquatable<Data>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType? Type { get; }

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
#if NET6_0_OR_GREATER
        public global::G.GetKnowledgeBaseSummaryTextResponseModel? Text { get; init; }
#else
        public global::G.GetKnowledgeBaseSummaryTextResponseModel? Text { get; }
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
        public global::G.GetKnowledgeBaseSummaryFolderResponseModel? Folder { get; init; }
#else
        public global::G.GetKnowledgeBaseSummaryFolderResponseModel? Folder { get; }
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
        public static implicit operator Data(global::G.GetKnowledgeBaseSummaryURLResponseModel value) => new Data((global::G.GetKnowledgeBaseSummaryURLResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseSummaryURLResponseModel?(Data @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::G.GetKnowledgeBaseSummaryURLResponseModel? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::G.GetKnowledgeBaseSummaryFileResponseModel value) => new Data((global::G.GetKnowledgeBaseSummaryFileResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseSummaryFileResponseModel?(Data @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::G.GetKnowledgeBaseSummaryFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::G.GetKnowledgeBaseSummaryTextResponseModel value) => new Data((global::G.GetKnowledgeBaseSummaryTextResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseSummaryTextResponseModel?(Data @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::G.GetKnowledgeBaseSummaryTextResponseModel? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::G.GetKnowledgeBaseSummaryFolderResponseModel value) => new Data((global::G.GetKnowledgeBaseSummaryFolderResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetKnowledgeBaseSummaryFolderResponseModel?(Data @this) => @this.Folder;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::G.GetKnowledgeBaseSummaryFolderResponseModel? value)
        {
            Folder = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Data(
            global::G.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType? type,
            global::G.GetKnowledgeBaseSummaryURLResponseModel? url,
            global::G.GetKnowledgeBaseSummaryFileResponseModel? file,
            global::G.GetKnowledgeBaseSummaryTextResponseModel? text,
            global::G.GetKnowledgeBaseSummaryFolderResponseModel? folder
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
            global::System.Func<global::G.GetKnowledgeBaseSummaryURLResponseModel?, TResult>? url = null,
            global::System.Func<global::G.GetKnowledgeBaseSummaryFileResponseModel?, TResult>? file = null,
            global::System.Func<global::G.GetKnowledgeBaseSummaryTextResponseModel?, TResult>? text = null,
            global::System.Func<global::G.GetKnowledgeBaseSummaryFolderResponseModel?, TResult>? folder = null,
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
            global::System.Action<global::G.GetKnowledgeBaseSummaryURLResponseModel?>? url = null,
            global::System.Action<global::G.GetKnowledgeBaseSummaryFileResponseModel?>? file = null,
            global::System.Action<global::G.GetKnowledgeBaseSummaryTextResponseModel?>? text = null,
            global::System.Action<global::G.GetKnowledgeBaseSummaryFolderResponseModel?>? folder = null,
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
                typeof(global::G.GetKnowledgeBaseSummaryURLResponseModel),
                File,
                typeof(global::G.GetKnowledgeBaseSummaryFileResponseModel),
                Text,
                typeof(global::G.GetKnowledgeBaseSummaryTextResponseModel),
                Folder,
                typeof(global::G.GetKnowledgeBaseSummaryFolderResponseModel),
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
        public bool Equals(Data other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseSummaryURLResponseModel?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseSummaryFileResponseModel?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseSummaryTextResponseModel?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetKnowledgeBaseSummaryFolderResponseModel?>.Default.Equals(Folder, other.Folder) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data obj1, Data obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data obj1, Data obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data o && Equals(o);
        }
    }
}
