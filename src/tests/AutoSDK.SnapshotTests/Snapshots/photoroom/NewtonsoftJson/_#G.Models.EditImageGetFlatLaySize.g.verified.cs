//HintName: G.Models.EditImageGetFlatLaySize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: SQUARE_HD
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetFlatLaySize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LANDSCAPE_HD_16_9")]
        LandscapeHd169,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LANDSCAPE_HD_3_2")]
        LandscapeHd32,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LANDSCAPE_HD_4_3")]
        LandscapeHd43,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PORTRAIT_HD_16_9")]
        PortraitHd169,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PORTRAIT_HD_3_2")]
        PortraitHd32,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PORTRAIT_HD_4_3")]
        PortraitHd43,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SQUARE_HD")]
        SquareHd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetFlatLaySizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetFlatLaySize value)
        {
            return value switch
            {
                EditImageGetFlatLaySize.LandscapeHd169 => "LANDSCAPE_HD_16_9",
                EditImageGetFlatLaySize.LandscapeHd32 => "LANDSCAPE_HD_3_2",
                EditImageGetFlatLaySize.LandscapeHd43 => "LANDSCAPE_HD_4_3",
                EditImageGetFlatLaySize.PortraitHd169 => "PORTRAIT_HD_16_9",
                EditImageGetFlatLaySize.PortraitHd32 => "PORTRAIT_HD_3_2",
                EditImageGetFlatLaySize.PortraitHd43 => "PORTRAIT_HD_4_3",
                EditImageGetFlatLaySize.SquareHd => "SQUARE_HD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetFlatLaySize? ToEnum(string value)
        {
            return value switch
            {
                "LANDSCAPE_HD_16_9" => EditImageGetFlatLaySize.LandscapeHd169,
                "LANDSCAPE_HD_3_2" => EditImageGetFlatLaySize.LandscapeHd32,
                "LANDSCAPE_HD_4_3" => EditImageGetFlatLaySize.LandscapeHd43,
                "PORTRAIT_HD_16_9" => EditImageGetFlatLaySize.PortraitHd169,
                "PORTRAIT_HD_3_2" => EditImageGetFlatLaySize.PortraitHd32,
                "PORTRAIT_HD_4_3" => EditImageGetFlatLaySize.PortraitHd43,
                "SQUARE_HD" => EditImageGetFlatLaySize.SquareHd,
                _ => null,
            };
        }
    }
}