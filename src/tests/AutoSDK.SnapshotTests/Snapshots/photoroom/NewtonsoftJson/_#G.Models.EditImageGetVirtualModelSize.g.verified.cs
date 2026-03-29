//HintName: G.Models.EditImageGetVirtualModelSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: PORTRAIT_HD_3_2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetVirtualModelSize
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
    public static class EditImageGetVirtualModelSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetVirtualModelSize value)
        {
            return value switch
            {
                EditImageGetVirtualModelSize.LandscapeHd169 => "LANDSCAPE_HD_16_9",
                EditImageGetVirtualModelSize.LandscapeHd32 => "LANDSCAPE_HD_3_2",
                EditImageGetVirtualModelSize.LandscapeHd43 => "LANDSCAPE_HD_4_3",
                EditImageGetVirtualModelSize.PortraitHd169 => "PORTRAIT_HD_16_9",
                EditImageGetVirtualModelSize.PortraitHd32 => "PORTRAIT_HD_3_2",
                EditImageGetVirtualModelSize.PortraitHd43 => "PORTRAIT_HD_4_3",
                EditImageGetVirtualModelSize.SquareHd => "SQUARE_HD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetVirtualModelSize? ToEnum(string value)
        {
            return value switch
            {
                "LANDSCAPE_HD_16_9" => EditImageGetVirtualModelSize.LandscapeHd169,
                "LANDSCAPE_HD_3_2" => EditImageGetVirtualModelSize.LandscapeHd32,
                "LANDSCAPE_HD_4_3" => EditImageGetVirtualModelSize.LandscapeHd43,
                "PORTRAIT_HD_16_9" => EditImageGetVirtualModelSize.PortraitHd169,
                "PORTRAIT_HD_3_2" => EditImageGetVirtualModelSize.PortraitHd32,
                "PORTRAIT_HD_4_3" => EditImageGetVirtualModelSize.PortraitHd43,
                "SQUARE_HD" => EditImageGetVirtualModelSize.SquareHd,
                _ => null,
            };
        }
    }
}