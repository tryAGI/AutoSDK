//HintName: G.Models.CreateVideoFromImageRequestRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aspect ratio of the video.<br/>
    /// Default Value: 16:9
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoFromImageRequestRatio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="16:9")]
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="9:16")]
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoFromImageRequestRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoFromImageRequestRatio value)
        {
            return value switch
            {
                CreateVideoFromImageRequestRatio.x16_9 => "16:9",
                CreateVideoFromImageRequestRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoFromImageRequestRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateVideoFromImageRequestRatio.x16_9,
                "9:16" => CreateVideoFromImageRequestRatio.x9_16,
                _ => null,
            };
        }
    }
}