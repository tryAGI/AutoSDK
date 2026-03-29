//HintName: G.Models.EmbeddingTaskMediaMetadata.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for the media input.
    /// </summary>
    public readonly partial struct EmbeddingTaskMediaMetadata : global::System.IEquatable<EmbeddingTaskMediaMetadata>
    {
        /// <summary>
        /// Metadata for audio embeddings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EmbeddingAudioMetadata? EmbeddingAudioMetadata { get; init; }
#else
        public global::G.EmbeddingAudioMetadata? EmbeddingAudioMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingAudioMetadata))]
#endif
        public bool IsEmbeddingAudioMetadata => EmbeddingAudioMetadata != null;

        /// <summary>
        /// Metadata for video embeddings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EmbeddingVideoMetadata? EmbeddingVideoMetadata { get; init; }
#else
        public global::G.EmbeddingVideoMetadata? EmbeddingVideoMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingVideoMetadata))]
#endif
        public bool IsEmbeddingVideoMetadata => EmbeddingVideoMetadata != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingTaskMediaMetadata(global::G.EmbeddingAudioMetadata value) => new EmbeddingTaskMediaMetadata((global::G.EmbeddingAudioMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EmbeddingAudioMetadata?(EmbeddingTaskMediaMetadata @this) => @this.EmbeddingAudioMetadata;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingTaskMediaMetadata(global::G.EmbeddingAudioMetadata? value)
        {
            EmbeddingAudioMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingTaskMediaMetadata(global::G.EmbeddingVideoMetadata value) => new EmbeddingTaskMediaMetadata((global::G.EmbeddingVideoMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EmbeddingVideoMetadata?(EmbeddingTaskMediaMetadata @this) => @this.EmbeddingVideoMetadata;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingTaskMediaMetadata(global::G.EmbeddingVideoMetadata? value)
        {
            EmbeddingVideoMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingTaskMediaMetadata(
            global::G.EmbeddingAudioMetadata? embeddingAudioMetadata,
            global::G.EmbeddingVideoMetadata? embeddingVideoMetadata
            )
        {
            EmbeddingAudioMetadata = embeddingAudioMetadata;
            EmbeddingVideoMetadata = embeddingVideoMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingVideoMetadata as object ??
            EmbeddingAudioMetadata as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingAudioMetadata?.ToString() ??
            EmbeddingVideoMetadata?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingAudioMetadata && !IsEmbeddingVideoMetadata || !IsEmbeddingAudioMetadata && IsEmbeddingVideoMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.EmbeddingAudioMetadata?, TResult>? embeddingAudioMetadata = null,
            global::System.Func<global::G.EmbeddingVideoMetadata?, TResult>? embeddingVideoMetadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingAudioMetadata && embeddingAudioMetadata != null)
            {
                return embeddingAudioMetadata(EmbeddingAudioMetadata!);
            }
            else if (IsEmbeddingVideoMetadata && embeddingVideoMetadata != null)
            {
                return embeddingVideoMetadata(EmbeddingVideoMetadata!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.EmbeddingAudioMetadata?>? embeddingAudioMetadata = null,
            global::System.Action<global::G.EmbeddingVideoMetadata?>? embeddingVideoMetadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingAudioMetadata)
            {
                embeddingAudioMetadata?.Invoke(EmbeddingAudioMetadata!);
            }
            else if (IsEmbeddingVideoMetadata)
            {
                embeddingVideoMetadata?.Invoke(EmbeddingVideoMetadata!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingAudioMetadata,
                typeof(global::G.EmbeddingAudioMetadata),
                EmbeddingVideoMetadata,
                typeof(global::G.EmbeddingVideoMetadata),
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
        public bool Equals(EmbeddingTaskMediaMetadata other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.EmbeddingAudioMetadata?>.Default.Equals(EmbeddingAudioMetadata, other.EmbeddingAudioMetadata) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EmbeddingVideoMetadata?>.Default.Equals(EmbeddingVideoMetadata, other.EmbeddingVideoMetadata) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingTaskMediaMetadata obj1, EmbeddingTaskMediaMetadata obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingTaskMediaMetadata>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingTaskMediaMetadata obj1, EmbeddingTaskMediaMetadata obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingTaskMediaMetadata o && Equals(o);
        }
    }
}
