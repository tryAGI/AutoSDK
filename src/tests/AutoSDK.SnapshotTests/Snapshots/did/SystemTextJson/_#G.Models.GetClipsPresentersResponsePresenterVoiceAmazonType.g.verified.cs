//HintName: G.Models.GetClipsPresentersResponsePresenterVoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetClipsPresentersResponsePresenterVoiceAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetClipsPresentersResponsePresenterVoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipsPresentersResponsePresenterVoiceAmazonType value)
        {
            return value switch
            {
                GetClipsPresentersResponsePresenterVoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipsPresentersResponsePresenterVoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => GetClipsPresentersResponsePresenterVoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}