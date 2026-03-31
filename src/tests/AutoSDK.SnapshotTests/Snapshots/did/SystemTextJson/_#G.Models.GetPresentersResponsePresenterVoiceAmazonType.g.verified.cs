//HintName: G.Models.GetPresentersResponsePresenterVoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPresentersResponsePresenterVoiceAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPresentersResponsePresenterVoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresentersResponsePresenterVoiceAmazonType value)
        {
            return value switch
            {
                GetPresentersResponsePresenterVoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresentersResponsePresenterVoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => GetPresentersResponsePresenterVoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}