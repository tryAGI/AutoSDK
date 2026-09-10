//HintName: G.Models.DirectPublishingReadResponseModelTargetAudience.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DirectPublishingReadResponseModelTargetAudience
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="adult")]
        Adult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all ages")]
        AllAges,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="children")]
        Children,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="young adult")]
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