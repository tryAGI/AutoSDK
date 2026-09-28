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
        public global::G.FileCitation? FileCitation { get; init; }
#else
        public global::G.FileCitation? FileCitation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileCitation))]
#endif
        public bool IsFileCitation => FileCitation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileCitation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.FileCitation? value)
        {
            value = FileCitation;
            return IsFileCitation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.FileCitation PickFileCitation() => FileCitation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileCitation' but the value was {ToString()}.");

        /// <summary>
        /// A citation for a web resource used to generate a model response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UrlCitation? UrlCitation { get; init; }
#else
        public global::G.UrlCitation? UrlCitation { get; }
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
        public bool TryPickUrlCitation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.UrlCitation? value)
        {
            value = UrlCitation;
            return IsUrlCitation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.UrlCitation PickUrlCitation() => UrlCitation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UrlCitation' but the value was {ToString()}.");

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
        public bool TryPickFilePath(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.FilePath? value)
        {
            value = FilePath;
            return IsFilePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.FilePath PickFilePath() => FilePath is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FilePath' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::G.FileCitation value) => new Annotation((global::G.FileCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileCitation?(Annotation @this) => @this.FileCitation;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::G.FileCitation? value)
        {
            FileCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Annotation FromFileCitation(global::G.FileCitation? value) => new Annotation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::G.UrlCitation value) => new Annotation((global::G.UrlCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UrlCitation?(Annotation @this) => @this.UrlCitation;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::G.UrlCitation? value)
        {
            UrlCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Annotation FromUrlCitation(global::G.UrlCitation? value) => new Annotation(value);

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
        public static Annotation FromFilePath(global::G.FilePath? value) => new Annotation(value);

        /// <summary>
        /// 
        /// </summary>
        public Annotation(
            global::G.FileCitation? fileCitation,
            global::G.UrlCitation? urlCitation,
            global::G.FilePath? filePath
            )
        {
            FileCitation = fileCitation;
            UrlCitation = urlCitation;
            FilePath = filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FilePath as object ??
            UrlCitation as object ??
            FileCitation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileCitation?.ToString() ??
            UrlCitation?.ToString() ??
            FilePath?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitation && !IsUrlCitation && !IsFilePath || !IsFileCitation && IsUrlCitation && !IsFilePath || !IsFileCitation && !IsUrlCitation && IsFilePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FileCitation, TResult>? fileCitation = null,
            global::System.Func<global::G.UrlCitation, TResult>? urlCitation = null,
            global::System.Func<global::G.FilePath, TResult>? filePath = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (FileCitation is { } __value0 && fileCitation != null)
            {
                return fileCitation(__value0);
            }
            else if (UrlCitation is { } __value1 && urlCitation != null)
            {
                return urlCitation(__value1);
            }
            else if (FilePath is { } __value2 && filePath != null)
            {
                return filePath(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FileCitation>? fileCitation = null,

            global::System.Action<global::G.UrlCitation>? urlCitation = null,

            global::System.Action<global::G.FilePath>? filePath = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (FileCitation is { } __value0)
            {
                fileCitation?.Invoke(__value0);
            }
            else if (UrlCitation is { } __value1)
            {
                urlCitation?.Invoke(__value1);
            }
            else if (FilePath is { } __value2)
            {
                filePath?.Invoke(__value2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.FileCitation>? fileCitation = null,
            global::System.Action<global::G.UrlCitation>? urlCitation = null,
            global::System.Action<global::G.FilePath>? filePath = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (FileCitation is { } __value0)
            {
                fileCitation?.Invoke(__value0);
            }
            else if (UrlCitation is { } __value1)
            {
                urlCitation?.Invoke(__value1);
            }
            else if (FilePath is { } __value2)
            {
                filePath?.Invoke(__value2);
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
                typeof(global::G.FileCitation),
                UrlCitation,
                typeof(global::G.UrlCitation),
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
                global::System.Collections.Generic.EqualityComparer<global::G.FileCitation?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UrlCitation?>.Default.Equals(UrlCitation, other.UrlCitation) &&
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
