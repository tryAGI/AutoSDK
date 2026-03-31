//HintName: G.Models.PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    public enum PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat value)
        {
            return value switch
            {
                PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat.Mov => "mov",
                PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat.Mov,
                "mp4" => PickTalksConfigExcludeKeyofTalksConfigLogoOrDriverExpressionsResultFormat.Mp4,
                _ => null,
            };
        }
    }
}