//HintName: G.Models.GetPresenterByIdResponsePresenterVoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPresenterByIdResponsePresenterVoiceAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amazon")]
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPresenterByIdResponsePresenterVoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresenterByIdResponsePresenterVoiceAmazonType value)
        {
            return value switch
            {
                GetPresenterByIdResponsePresenterVoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresenterByIdResponsePresenterVoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => GetPresenterByIdResponsePresenterVoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}