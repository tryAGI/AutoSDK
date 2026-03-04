//HintName: G.Models.ReposGetContentResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ReposGetContentResponse : global::System.IEquatable<ReposGetContentResponse>
    {
        /// <summary>
        /// A list of directory items
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? ContentDirectory { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? ContentDirectory { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentDirectory))]
#endif
        public bool IsContentDirectory => ContentDirectory != null;

        /// <summary>
        /// Content File
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContentFile? File { get; init; }
#else
        public global::G.ContentFile? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// An object describing a symlink
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContentSymlink? Symlink { get; init; }
#else
        public global::G.ContentSymlink? Symlink { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Symlink))]
#endif
        public bool IsSymlink => Symlink != null;

        /// <summary>
        /// An object describing a submodule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContentSubmodule? Submodule { get; init; }
#else
        public global::G.ContentSubmodule? Submodule { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Submodule))]
#endif
        public bool IsSubmodule => Submodule != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::G.ContentFile value) => new ReposGetContentResponse((global::G.ContentFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentFile?(ReposGetContentResponse @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::G.ContentFile? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::G.ContentSymlink value) => new ReposGetContentResponse((global::G.ContentSymlink?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentSymlink?(ReposGetContentResponse @this) => @this.Symlink;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::G.ContentSymlink? value)
        {
            Symlink = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::G.ContentSubmodule value) => new ReposGetContentResponse((global::G.ContentSubmodule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContentSubmodule?(ReposGetContentResponse @this) => @this.Submodule;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::G.ContentSubmodule? value)
        {
            Submodule = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(
            global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>? contentDirectory,
            global::G.ContentFile? file,
            global::G.ContentSymlink? symlink,
            global::G.ContentSubmodule? submodule
            )
        {
            ContentDirectory = contentDirectory;
            File = file;
            Symlink = symlink;
            Submodule = submodule;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Submodule as object ??
            Symlink as object ??
            File as object ??
            ContentDirectory as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ContentDirectory?.ToString() ??
            File?.ToString() ??
            Symlink?.ToString() ??
            Submodule?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsContentDirectory && !IsFile && !IsSymlink && !IsSubmodule || !IsContentDirectory && IsFile && !IsSymlink && !IsSubmodule || !IsContentDirectory && !IsFile && IsSymlink && !IsSubmodule || !IsContentDirectory && !IsFile && !IsSymlink && IsSubmodule;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>?, TResult>? contentDirectory = null,
            global::System.Func<global::G.ContentFile?, TResult>? file = null,
            global::System.Func<global::G.ContentSymlink?, TResult>? symlink = null,
            global::System.Func<global::G.ContentSubmodule?, TResult>? submodule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentDirectory && contentDirectory != null)
            {
                return contentDirectory(ContentDirectory!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsSymlink && symlink != null)
            {
                return symlink(Symlink!);
            }
            else if (IsSubmodule && submodule != null)
            {
                return submodule(Submodule!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>?>? contentDirectory = null,
            global::System.Action<global::G.ContentFile?>? file = null,
            global::System.Action<global::G.ContentSymlink?>? symlink = null,
            global::System.Action<global::G.ContentSubmodule?>? submodule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentDirectory)
            {
                contentDirectory?.Invoke(ContentDirectory!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsSymlink)
            {
                symlink?.Invoke(Symlink!);
            }
            else if (IsSubmodule)
            {
                submodule?.Invoke(Submodule!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ContentDirectory,
                typeof(global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>),
                File,
                typeof(global::G.ContentFile),
                Symlink,
                typeof(global::G.ContentSymlink),
                Submodule,
                typeof(global::G.ContentSubmodule),
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
        public bool Equals(ReposGetContentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ContentDirectoryItem>?>.Default.Equals(ContentDirectory, other.ContentDirectory) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentFile?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentSymlink?>.Default.Equals(Symlink, other.Symlink) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContentSubmodule?>.Default.Equals(Submodule, other.Submodule) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReposGetContentResponse obj1, ReposGetContentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReposGetContentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReposGetContentResponse obj1, ReposGetContentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReposGetContentResponse o && Equals(o);
        }
    }
}
