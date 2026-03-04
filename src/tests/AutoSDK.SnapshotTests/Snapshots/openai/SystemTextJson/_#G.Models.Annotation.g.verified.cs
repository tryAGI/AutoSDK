//HintName: G.Models.Annotation.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Annotation : global::System.IEquatable<Annotation>
    {
        /// <summary>
        /// A citation to a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FileCitationBody? FileCitation { get; init; }
#else
        public global::G.FileCitationBody? FileCitation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileCitation))]
#endif
        public bool IsFileCitation => FileCitation != null;

        /// <summary>
        /// A citation for a web resource used to generate a model response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UrlCitationBody? UrlCitation { get; init; }
#else
        public global::G.UrlCitationBody? UrlCitation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UrlCitation))]
#endif
        public bool IsUrlCitation => UrlCitation != null;

        /// <summary>
        /// A citation for a container file used to generate a model response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContainerFileCitationBody? ContainerFileCitation { get; init; }
#else
        public global::G.ContainerFileCitationBody? ContainerFileCitation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerFileCitation))]
#endif
        public bool IsContainerFileCitation => ContainerFileCitation != null;

        /// <summary>
        /// A path to a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FilePath? FilePath { get; init; }
#else
        public global::G.FilePath? FilePath { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilePath))]
#endif
        public bool IsFilePath => FilePath != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::G.FileCitationBody value) => new Annotation((global::G.FileCitationBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileCitationBody?(Annotation @this) => @this.FileCitation;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::G.FileCitationBody? value)
        {
            FileCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::G.UrlCitationBody value) => new Annotation((global::G.UrlCitationBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UrlCitationBody?(Annotation @this) => @this.UrlCitation;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::G.UrlCitationBody? value)
        {
            UrlCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::G.ContainerFileCitationBody value) => new Annotation((global::G.ContainerFileCitationBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContainerFileCitationBody?(Annotation @this) => @this.ContainerFileCitation;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::G.ContainerFileCitationBody? value)
        {
            ContainerFileCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::G.FilePath value) => new Annotation((global::G.FilePath?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FilePath?(Annotation @this) => @this.FilePath;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::G.FilePath? value)
        {
            FilePath = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Annotation(
            global::G.FileCitationBody? fileCitation,
            global::G.UrlCitationBody? urlCitation,
            global::G.ContainerFileCitationBody? containerFileCitation,
            global::G.FilePath? filePath
            )
        {
            FileCitation = fileCitation;
            UrlCitation = urlCitation;
            ContainerFileCitation = containerFileCitation;
            FilePath = filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FilePath as object ??
            ContainerFileCitation as object ??
            UrlCitation as object ??
            FileCitation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileCitation?.ToString() ??
            UrlCitation?.ToString() ??
            ContainerFileCitation?.ToString() ??
            FilePath?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitation && !IsUrlCitation && !IsContainerFileCitation && !IsFilePath || !IsFileCitation && IsUrlCitation && !IsContainerFileCitation && !IsFilePath || !IsFileCitation && !IsUrlCitation && IsContainerFileCitation && !IsFilePath || !IsFileCitation && !IsUrlCitation && !IsContainerFileCitation && IsFilePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FileCitationBody?, TResult>? fileCitation = null,
            global::System.Func<global::G.UrlCitationBody?, TResult>? urlCitation = null,
            global::System.Func<global::G.ContainerFileCitationBody?, TResult>? containerFileCitation = null,
            global::System.Func<global::G.FilePath?, TResult>? filePath = null,
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
            else if (IsContainerFileCitation && containerFileCitation != null)
            {
                return containerFileCitation(ContainerFileCitation!);
            }
            else if (IsFilePath && filePath != null)
            {
                return filePath(FilePath!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FileCitationBody?>? fileCitation = null,
            global::System.Action<global::G.UrlCitationBody?>? urlCitation = null,
            global::System.Action<global::G.ContainerFileCitationBody?>? containerFileCitation = null,
            global::System.Action<global::G.FilePath?>? filePath = null,
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
            else if (IsContainerFileCitation)
            {
                containerFileCitation?.Invoke(ContainerFileCitation!);
            }
            else if (IsFilePath)
            {
                filePath?.Invoke(FilePath!);
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
                typeof(global::G.FileCitationBody),
                UrlCitation,
                typeof(global::G.UrlCitationBody),
                ContainerFileCitation,
                typeof(global::G.ContainerFileCitationBody),
                FilePath,
                typeof(global::G.FilePath),
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
        public bool Equals(Annotation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FileCitationBody?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UrlCitationBody?>.Default.Equals(UrlCitation, other.UrlCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContainerFileCitationBody?>.Default.Equals(ContainerFileCitation, other.ContainerFileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FilePath?>.Default.Equals(FilePath, other.FilePath) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Annotation obj1, Annotation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Annotation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Annotation obj1, Annotation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Annotation o && Equals(o);
        }
    }
}
