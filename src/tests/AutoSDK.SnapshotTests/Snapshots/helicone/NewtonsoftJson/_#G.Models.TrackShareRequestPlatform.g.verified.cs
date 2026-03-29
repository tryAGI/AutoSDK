//HintName: G.Models.TrackShareRequestPlatform.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TrackShareRequestPlatform
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="linkedin")]
        Linkedin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twitter")]
        Twitter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackShareRequestPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackShareRequestPlatform value)
        {
            return value switch
            {
                TrackShareRequestPlatform.Linkedin => "linkedin",
                TrackShareRequestPlatform.Twitter => "twitter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackShareRequestPlatform? ToEnum(string value)
        {
            return value switch
            {
                "linkedin" => TrackShareRequestPlatform.Linkedin,
                "twitter" => TrackShareRequestPlatform.Twitter,
                _ => null,
            };
        }
    }
}