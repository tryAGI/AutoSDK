﻿//HintName: G.Models.ReactionsCreateForReleaseRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the release.
    /// </summary>
    public enum ReactionsCreateForReleaseRequestContent
    {
        /// <summary>
        /// 
        /// </summary>
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        Heart,
        /// <summary>
        /// 
        /// </summary>
        Hooray,
        /// <summary>
        /// 
        /// </summary>
        Rocket,
        /// <summary>
        /// 
        /// </summary>
        Eyes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReactionsCreateForReleaseRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForReleaseRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForReleaseRequestContent.Plus1 => "+1",
                ReactionsCreateForReleaseRequestContent.Laugh => "laugh",
                ReactionsCreateForReleaseRequestContent.Heart => "heart",
                ReactionsCreateForReleaseRequestContent.Hooray => "hooray",
                ReactionsCreateForReleaseRequestContent.Rocket => "rocket",
                ReactionsCreateForReleaseRequestContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForReleaseRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForReleaseRequestContent.Plus1,
                "laugh" => ReactionsCreateForReleaseRequestContent.Laugh,
                "heart" => ReactionsCreateForReleaseRequestContent.Heart,
                "hooray" => ReactionsCreateForReleaseRequestContent.Hooray,
                "rocket" => ReactionsCreateForReleaseRequestContent.Rocket,
                "eyes" => ReactionsCreateForReleaseRequestContent.Eyes,
                _ => null,
            };
        }
    }
}