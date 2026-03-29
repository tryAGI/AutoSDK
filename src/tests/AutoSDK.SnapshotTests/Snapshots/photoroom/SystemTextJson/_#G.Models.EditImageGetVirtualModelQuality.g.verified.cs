//HintName: G.Models.EditImageGetVirtualModelQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: standard
    /// </summary>
    public enum EditImageGetVirtualModelQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        Premium,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetVirtualModelQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetVirtualModelQuality value)
        {
            return value switch
            {
                EditImageGetVirtualModelQuality.Advanced => "advanced",
                EditImageGetVirtualModelQuality.Premium => "premium",
                EditImageGetVirtualModelQuality.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetVirtualModelQuality? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => EditImageGetVirtualModelQuality.Advanced,
                "premium" => EditImageGetVirtualModelQuality.Premium,
                "standard" => EditImageGetVirtualModelQuality.Standard,
                _ => null,
            };
        }
    }
}