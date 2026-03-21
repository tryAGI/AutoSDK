//HintName: G.Models.Media.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Media : global::System.IEquatable<Media>
    {
        /// <summary>
        /// An audio file containing dialogue to be processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio? Audio { get; init; }
#else
        public global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        /// A video file containing dialogue to be processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo? Video { get; init; }
#else
        public global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Media(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio value) => new Media((global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio?(Media @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public Media(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Media(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo value) => new Media((global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo?(Media @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public Media(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Media(
            global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio? audio,
            global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo? video
            )
        {
            Audio = audio;
            Video = video;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Video as object ??
            Audio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Audio?.ToString() ??
            Video?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudio && !IsVideo || !IsAudio && IsVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio?, TResult>? audio = null,
            global::System.Func<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo?, TResult>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio?>? audio = null,
            global::System.Action<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo?>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Audio,
                typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio),
                Video,
                typeof(global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo),
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
        public bool Equals(Media other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo?>.Default.Equals(Video, other.Video) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Media obj1, Media obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Media>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Media obj1, Media obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Media o && Equals(o);
        }
    }
}
