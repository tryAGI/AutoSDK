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
        public global::G.FileCitationBody? FileCitationBody { get; init; }
#else
        public global::G.FileCitationBody? FileCitationBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileCitationBody))]
#endif
        public bool IsFileCitationBody => FileCitationBody != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::G.FileCitationBody value) => new Annotation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileCitationBody?(Annotation @this) => @this.FileCitationBody;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::G.FileCitationBody? value)
        {
            FileCitationBody = value;
        }

        /// <summary>
        /// A citation for a web resource used to generate a model response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UrlCitationBody? UrlCitationBody { get; init; }
#else
        public global::G.UrlCitationBody? UrlCitationBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UrlCitationBody))]
#endif
        public bool IsUrlCitationBody => UrlCitationBody != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::G.UrlCitationBody value) => new Annotation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UrlCitationBody?(Annotation @this) => @this.UrlCitationBody;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::G.UrlCitationBody? value)
        {
            UrlCitationBody = value;
        }

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
        public static implicit operator Annotation(global::G.FilePath value) => new Annotation(value);

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
            global::G.FileCitationBody? fileCitationBody,
            global::G.UrlCitationBody? urlCitationBody,
            global::G.FilePath? filePath
            )
        {
            FileCitationBody = fileCitationBody;
            UrlCitationBody = urlCitationBody;
            FilePath = filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FilePath as object ??
            UrlCitationBody as object ??
            FileCitationBody as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileCitationBody?.ToString() ??
            UrlCitationBody?.ToString() ??
            FilePath?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitationBody && !IsUrlCitationBody && !IsFilePath || !IsFileCitationBody && IsUrlCitationBody && !IsFilePath || !IsFileCitationBody && !IsUrlCitationBody && IsFilePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FileCitationBody?, TResult>? fileCitationBody = null,
            global::System.Func<global::G.UrlCitationBody?, TResult>? urlCitationBody = null,
            global::System.Func<global::G.FilePath?, TResult>? filePath = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitationBody && fileCitationBody != null)
            {
                return fileCitationBody(FileCitationBody!);
            }
            else if (IsUrlCitationBody && urlCitationBody != null)
            {
                return urlCitationBody(UrlCitationBody!);
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
            global::System.Action<global::G.FileCitationBody?>? fileCitationBody = null,
            global::System.Action<global::G.UrlCitationBody?>? urlCitationBody = null,
            global::System.Action<global::G.FilePath?>? filePath = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitationBody)
            {
                fileCitationBody?.Invoke(FileCitationBody!);
            }
            else if (IsUrlCitationBody)
            {
                urlCitationBody?.Invoke(UrlCitationBody!);
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
                FileCitationBody,
                typeof(global::G.FileCitationBody),
                UrlCitationBody,
                typeof(global::G.UrlCitationBody),
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
                global::System.Collections.Generic.EqualityComparer<global::G.FileCitationBody?>.Default.Equals(FileCitationBody, other.FileCitationBody) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UrlCitationBody?>.Default.Equals(UrlCitationBody, other.UrlCitationBody) &&
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
