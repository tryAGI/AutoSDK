//HintName: G.Models.OpenAIResponsesAnnotation.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OpenAIResponsesAnnotation : global::System.IEquatable<OpenAIResponsesAnnotation>
    {
        /// <summary>
        /// 
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
#if NET6_0_OR_GREATER
        public global::G.URLCitation? URLCitation { get; init; }
#else
        public global::G.URLCitation? URLCitation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(URLCitation))]
#endif
        public bool IsURLCitation => URLCitation != null;

        /// <summary>
        /// 
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
        public static implicit operator OpenAIResponsesAnnotation(global::G.FileCitation value) => new OpenAIResponsesAnnotation((global::G.FileCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileCitation?(OpenAIResponsesAnnotation @this) => @this.FileCitation;

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesAnnotation(global::G.FileCitation? value)
        {
            FileCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAIResponsesAnnotation(global::G.URLCitation value) => new OpenAIResponsesAnnotation((global::G.URLCitation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.URLCitation?(OpenAIResponsesAnnotation @this) => @this.URLCitation;

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesAnnotation(global::G.URLCitation? value)
        {
            URLCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAIResponsesAnnotation(global::G.FilePath value) => new OpenAIResponsesAnnotation((global::G.FilePath?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FilePath?(OpenAIResponsesAnnotation @this) => @this.FilePath;

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesAnnotation(global::G.FilePath? value)
        {
            FilePath = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesAnnotation(
            global::G.FileCitation? fileCitation,
            global::G.URLCitation? uRLCitation,
            global::G.FilePath? filePath
            )
        {
            FileCitation = fileCitation;
            URLCitation = uRLCitation;
            FilePath = filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FilePath as object ??
            URLCitation as object ??
            FileCitation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileCitation?.ToString() ??
            URLCitation?.ToString() ??
            FilePath?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitation && !IsURLCitation && !IsFilePath || !IsFileCitation && IsURLCitation && !IsFilePath || !IsFileCitation && !IsURLCitation && IsFilePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FileCitation?, TResult>? fileCitation = null,
            global::System.Func<global::G.URLCitation?, TResult>? uRLCitation = null,
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
            else if (IsURLCitation && uRLCitation != null)
            {
                return uRLCitation(URLCitation!);
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
            global::System.Action<global::G.FileCitation?>? fileCitation = null,
            global::System.Action<global::G.URLCitation?>? uRLCitation = null,
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
            else if (IsURLCitation)
            {
                uRLCitation?.Invoke(URLCitation!);
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
                typeof(global::G.FileCitation),
                URLCitation,
                typeof(global::G.URLCitation),
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
        public bool Equals(OpenAIResponsesAnnotation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FileCitation?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.URLCitation?>.Default.Equals(URLCitation, other.URLCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FilePath?>.Default.Equals(FilePath, other.FilePath) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OpenAIResponsesAnnotation obj1, OpenAIResponsesAnnotation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenAIResponsesAnnotation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OpenAIResponsesAnnotation obj1, OpenAIResponsesAnnotation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAIResponsesAnnotation o && Equals(o);
        }
    }
}
