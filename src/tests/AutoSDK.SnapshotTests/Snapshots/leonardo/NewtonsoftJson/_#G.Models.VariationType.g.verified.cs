//HintName: G.Models.VariationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of variation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VariationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INPAINT")]
        Inpaint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NOBG")]
        Nobg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OUTPAINT")]
        Outpaint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNZOOM")]
        Unzoom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UPSCALE")]
        Upscale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VariationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VariationType value)
        {
            return value switch
            {
                VariationType.Inpaint => "INPAINT",
                VariationType.Nobg => "NOBG",
                VariationType.Outpaint => "OUTPAINT",
                VariationType.Unzoom => "UNZOOM",
                VariationType.Upscale => "UPSCALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VariationType? ToEnum(string value)
        {
            return value switch
            {
                "INPAINT" => VariationType.Inpaint,
                "NOBG" => VariationType.Nobg,
                "OUTPAINT" => VariationType.Outpaint,
                "UNZOOM" => VariationType.Unzoom,
                "UPSCALE" => VariationType.Upscale,
                _ => null,
            };
        }
    }
}