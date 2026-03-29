//HintName: G.Models.VideoSegmentation.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies how the platform divides the video into segments.
    /// </summary>
    public readonly partial struct VideoSegmentation : global::System.IEquatable<VideoSegmentation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VideoSegmentation0? VideoSegmentation0 { get; init; }
#else
        public global::G.VideoSegmentation0? VideoSegmentation0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoSegmentation0))]
#endif
        public bool IsVideoSegmentation0 => VideoSegmentation0 != null;

        /// <summary>
        /// Configuration for fixed segmentation. This field is required when `strategy` is `fixed`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VideoSegmentation1? VideoSegmentation1 { get; init; }
#else
        public global::G.VideoSegmentation1? VideoSegmentation1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoSegmentation1))]
#endif
        public bool IsVideoSegmentation1 => VideoSegmentation1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoSegmentation(global::G.VideoSegmentation0 value) => new VideoSegmentation((global::G.VideoSegmentation0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VideoSegmentation0?(VideoSegmentation @this) => @this.VideoSegmentation0;

        /// <summary>
        /// 
        /// </summary>
        public VideoSegmentation(global::G.VideoSegmentation0? value)
        {
            VideoSegmentation0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoSegmentation(global::G.VideoSegmentation1 value) => new VideoSegmentation((global::G.VideoSegmentation1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VideoSegmentation1?(VideoSegmentation @this) => @this.VideoSegmentation1;

        /// <summary>
        /// 
        /// </summary>
        public VideoSegmentation(global::G.VideoSegmentation1? value)
        {
            VideoSegmentation1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VideoSegmentation(
            global::G.VideoSegmentation0? videoSegmentation0,
            global::G.VideoSegmentation1? videoSegmentation1
            )
        {
            VideoSegmentation0 = videoSegmentation0;
            VideoSegmentation1 = videoSegmentation1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoSegmentation1 as object ??
            VideoSegmentation0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VideoSegmentation0?.ToString() ??
            VideoSegmentation1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideoSegmentation0 && !IsVideoSegmentation1 || !IsVideoSegmentation0 && IsVideoSegmentation1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.VideoSegmentation0?, TResult>? videoSegmentation0 = null,
            global::System.Func<global::G.VideoSegmentation1?, TResult>? videoSegmentation1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoSegmentation0 && videoSegmentation0 != null)
            {
                return videoSegmentation0(VideoSegmentation0!);
            }
            else if (IsVideoSegmentation1 && videoSegmentation1 != null)
            {
                return videoSegmentation1(VideoSegmentation1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.VideoSegmentation0?>? videoSegmentation0 = null,
            global::System.Action<global::G.VideoSegmentation1?>? videoSegmentation1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoSegmentation0)
            {
                videoSegmentation0?.Invoke(VideoSegmentation0!);
            }
            else if (IsVideoSegmentation1)
            {
                videoSegmentation1?.Invoke(VideoSegmentation1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VideoSegmentation0,
                typeof(global::G.VideoSegmentation0),
                VideoSegmentation1,
                typeof(global::G.VideoSegmentation1),
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
        public bool Equals(VideoSegmentation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.VideoSegmentation0?>.Default.Equals(VideoSegmentation0, other.VideoSegmentation0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VideoSegmentation1?>.Default.Equals(VideoSegmentation1, other.VideoSegmentation1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VideoSegmentation obj1, VideoSegmentation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoSegmentation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VideoSegmentation obj1, VideoSegmentation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoSegmentation o && Equals(o);
        }
    }
}
