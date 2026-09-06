//HintName: G.Models.DirectPublishingReadResponseModelTargetAudience.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DirectPublishingReadResponseModelTargetAudience
    {
        /// <summary>
        /// 
        /// </summary>
        Adult,
        /// <summary>
        /// 
        /// </summary>
        AllAges,
        /// <summary>
        /// 
        /// </summary>
        Children,
        /// <summary>
        /// 
        /// </summary>
        YoungAdult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectPublishingReadResponseModelTargetAudienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectPublishingReadResponseModelTargetAudience value)
        {
            return value switch
            {
                DirectPublishingReadResponseModelTargetAudience.Adult => "adult",
                DirectPublishingReadResponseModelTargetAudience.AllAges => "all ages",
                DirectPublishingReadResponseModelTargetAudience.Children => "children",
                DirectPublishingReadResponseModelTargetAudience.YoungAdult => "young adult",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectPublishingReadResponseModelTargetAudience? ToEnum(string value)
        {
            return value switch
            {
                "adult" => DirectPublishingReadResponseModelTargetAudience.Adult,
                "all ages" => DirectPublishingReadResponseModelTargetAudience.AllAges,
                "children" => DirectPublishingReadResponseModelTargetAudience.Children,
                "young adult" => DirectPublishingReadResponseModelTargetAudience.YoungAdult,
                _ => null,
            };
        }
    }
}