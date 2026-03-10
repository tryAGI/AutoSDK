//HintName: G.Models.DirectPublishingReadResponseModelTargetAudience2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DirectPublishingReadResponseModelTargetAudience2
    {
        /// <summary>
        /// 
        /// </summary>
        Children,
        /// <summary>
        /// 
        /// </summary>
        YoungAdult,
        /// <summary>
        /// 
        /// </summary>
        Adult,
        /// <summary>
        /// 
        /// </summary>
        AllAges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectPublishingReadResponseModelTargetAudience2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectPublishingReadResponseModelTargetAudience2 value)
        {
            return value switch
            {
                DirectPublishingReadResponseModelTargetAudience2.Children => "children",
                DirectPublishingReadResponseModelTargetAudience2.YoungAdult => "young adult",
                DirectPublishingReadResponseModelTargetAudience2.Adult => "adult",
                DirectPublishingReadResponseModelTargetAudience2.AllAges => "all ages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectPublishingReadResponseModelTargetAudience2? ToEnum(string value)
        {
            return value switch
            {
                "children" => DirectPublishingReadResponseModelTargetAudience2.Children,
                "young adult" => DirectPublishingReadResponseModelTargetAudience2.YoungAdult,
                "adult" => DirectPublishingReadResponseModelTargetAudience2.Adult,
                "all ages" => DirectPublishingReadResponseModelTargetAudience2.AllAges,
                _ => null,
            };
        }
    }
}