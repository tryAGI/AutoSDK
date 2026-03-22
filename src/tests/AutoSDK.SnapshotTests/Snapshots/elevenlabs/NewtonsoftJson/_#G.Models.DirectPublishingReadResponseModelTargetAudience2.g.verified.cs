//HintName: G.Models.DirectPublishingReadResponseModelTargetAudience2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DirectPublishingReadResponseModelTargetAudience2
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
    public static class DirectPublishingReadResponseModelTargetAudience2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectPublishingReadResponseModelTargetAudience2 value)
        {
            return value switch
            {
                DirectPublishingReadResponseModelTargetAudience2.Adult => "adult",
                DirectPublishingReadResponseModelTargetAudience2.AllAges => "all ages",
                DirectPublishingReadResponseModelTargetAudience2.Children => "children",
                DirectPublishingReadResponseModelTargetAudience2.YoungAdult => "young adult",
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
                "adult" => DirectPublishingReadResponseModelTargetAudience2.Adult,
                "all ages" => DirectPublishingReadResponseModelTargetAudience2.AllAges,
                "children" => DirectPublishingReadResponseModelTargetAudience2.Children,
                "young adult" => DirectPublishingReadResponseModelTargetAudience2.YoungAdult,
                _ => null,
            };
        }
    }
}