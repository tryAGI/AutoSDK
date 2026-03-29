//HintName: G.Models.GetVideosSourceItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVideosSourceItem
    {
        /// <summary>
        /// 
        /// </summary>
        MyVideos,
        /// <summary>
        /// 
        /// </summary>
        SharedWithMe,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVideosSourceItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideosSourceItem value)
        {
            return value switch
            {
                GetVideosSourceItem.MyVideos => "my_videos",
                GetVideosSourceItem.SharedWithMe => "shared_with_me",
                GetVideosSourceItem.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideosSourceItem? ToEnum(string value)
        {
            return value switch
            {
                "my_videos" => GetVideosSourceItem.MyVideos,
                "shared_with_me" => GetVideosSourceItem.SharedWithMe,
                "workspace" => GetVideosSourceItem.Workspace,
                _ => null,
            };
        }
    }
}