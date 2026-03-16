//HintName: G.Models.Character.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The character to control. You can either provide a video or an image. A visually recognizable face must be visible and stay within the frame.
    /// </summary>
    public readonly partial struct Character : global::System.IEquatable<Character>
    {
        /// <summary>
        /// An image of your character. In the output, the character will use the reference video performance in its original static environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestActTwoCharacterCharacterImage? Image { get; init; }
#else
        public global::G.RequestActTwoCharacterCharacterImage? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// A video of your character. In the output, the character will use the reference video performance in its original animated environment and some of the character's own movements.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequestActTwoCharacterCharacterVideo? Video { get; init; }
#else
        public global::G.RequestActTwoCharacterCharacterVideo? Video { get; }
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
        public static implicit operator Character(global::G.RequestActTwoCharacterCharacterImage value) => new Character((global::G.RequestActTwoCharacterCharacterImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestActTwoCharacterCharacterImage?(Character @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Character(global::G.RequestActTwoCharacterCharacterImage? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Character(global::G.RequestActTwoCharacterCharacterVideo value) => new Character((global::G.RequestActTwoCharacterCharacterVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequestActTwoCharacterCharacterVideo?(Character @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public Character(global::G.RequestActTwoCharacterCharacterVideo? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Character(
            global::G.RequestActTwoCharacterCharacterImage? image,
            global::G.RequestActTwoCharacterCharacterVideo? video
            )
        {
            Image = image;
            Video = video;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Video as object ??
            Image as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Image?.ToString() ??
            Video?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImage && !IsVideo || !IsImage && IsVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RequestActTwoCharacterCharacterImage?, TResult>? image = null,
            global::System.Func<global::G.RequestActTwoCharacterCharacterVideo?, TResult>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage && image != null)
            {
                return image(Image!);
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
            global::System.Action<global::G.RequestActTwoCharacterCharacterImage?>? image = null,
            global::System.Action<global::G.RequestActTwoCharacterCharacterVideo?>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage)
            {
                image?.Invoke(Image!);
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
                Image,
                typeof(global::G.RequestActTwoCharacterCharacterImage),
                Video,
                typeof(global::G.RequestActTwoCharacterCharacterVideo),
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
        public bool Equals(Character other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RequestActTwoCharacterCharacterImage?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequestActTwoCharacterCharacterVideo?>.Default.Equals(Video, other.Video) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Character obj1, Character obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Character>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Character obj1, Character obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Character o && Equals(o);
        }
    }
}
