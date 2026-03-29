//HintName: G.Models.VideoResponseVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Public videos will be visible to anyone with a share URL.<br/>
    /// Private videos can only be downloaded via a time-limited download link. See Retrieve a video for details.<br/>
    /// Visibility can be changed also once the video is created via Update a video.<br/>
    /// Default Value: private
    /// </summary>
    public enum VideoResponseVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResponseVisibility value)
        {
            return value switch
            {
                VideoResponseVisibility.Private => "private",
                VideoResponseVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => VideoResponseVisibility.Private,
                "public" => VideoResponseVisibility.Public,
                _ => null,
            };
        }
    }
}