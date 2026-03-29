//HintName: G.Models.VideoFromTemplateApiVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes the private settings of the video. - If public, the video's share page is active. - If private, the video's share page is not active; visitors will receive a 404 Not Found response.<br/>
    /// Default Value: private
    /// </summary>
    public enum VideoFromTemplateApiVisibility
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
    public static class VideoFromTemplateApiVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoFromTemplateApiVisibility value)
        {
            return value switch
            {
                VideoFromTemplateApiVisibility.Private => "private",
                VideoFromTemplateApiVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoFromTemplateApiVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => VideoFromTemplateApiVisibility.Private,
                "public" => VideoFromTemplateApiVisibility.Public,
                _ => null,
            };
        }
    }
}