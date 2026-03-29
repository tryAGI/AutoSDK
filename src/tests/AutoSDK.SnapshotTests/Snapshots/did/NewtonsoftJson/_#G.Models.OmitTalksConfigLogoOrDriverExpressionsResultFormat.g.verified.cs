//HintName: G.Models.OmitTalksConfigLogoOrDriverExpressionsResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OmitTalksConfigLogoOrDriverExpressionsResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mov")]
        Mov,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp4")]
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OmitTalksConfigLogoOrDriverExpressionsResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OmitTalksConfigLogoOrDriverExpressionsResultFormat value)
        {
            return value switch
            {
                OmitTalksConfigLogoOrDriverExpressionsResultFormat.Mov => "mov",
                OmitTalksConfigLogoOrDriverExpressionsResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OmitTalksConfigLogoOrDriverExpressionsResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => OmitTalksConfigLogoOrDriverExpressionsResultFormat.Mov,
                "mp4" => OmitTalksConfigLogoOrDriverExpressionsResultFormat.Mp4,
                _ => null,
            };
        }
    }
}