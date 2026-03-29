//HintName: G.Models.EditImageGetGhostMannequinSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: SQUARE_HD
    /// </summary>
    public enum EditImageGetGhostMannequinSize
    {
        /// <summary>
        /// 
        /// </summary>
        LandscapeHd169,
        /// <summary>
        /// 
        /// </summary>
        LandscapeHd32,
        /// <summary>
        /// 
        /// </summary>
        LandscapeHd43,
        /// <summary>
        /// 
        /// </summary>
        PortraitHd169,
        /// <summary>
        /// 
        /// </summary>
        PortraitHd32,
        /// <summary>
        /// 
        /// </summary>
        PortraitHd43,
        /// <summary>
        /// 
        /// </summary>
        SquareHd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetGhostMannequinSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetGhostMannequinSize value)
        {
            return value switch
            {
                EditImageGetGhostMannequinSize.LandscapeHd169 => "LANDSCAPE_HD_16_9",
                EditImageGetGhostMannequinSize.LandscapeHd32 => "LANDSCAPE_HD_3_2",
                EditImageGetGhostMannequinSize.LandscapeHd43 => "LANDSCAPE_HD_4_3",
                EditImageGetGhostMannequinSize.PortraitHd169 => "PORTRAIT_HD_16_9",
                EditImageGetGhostMannequinSize.PortraitHd32 => "PORTRAIT_HD_3_2",
                EditImageGetGhostMannequinSize.PortraitHd43 => "PORTRAIT_HD_4_3",
                EditImageGetGhostMannequinSize.SquareHd => "SQUARE_HD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetGhostMannequinSize? ToEnum(string value)
        {
            return value switch
            {
                "LANDSCAPE_HD_16_9" => EditImageGetGhostMannequinSize.LandscapeHd169,
                "LANDSCAPE_HD_3_2" => EditImageGetGhostMannequinSize.LandscapeHd32,
                "LANDSCAPE_HD_4_3" => EditImageGetGhostMannequinSize.LandscapeHd43,
                "PORTRAIT_HD_16_9" => EditImageGetGhostMannequinSize.PortraitHd169,
                "PORTRAIT_HD_3_2" => EditImageGetGhostMannequinSize.PortraitHd32,
                "PORTRAIT_HD_4_3" => EditImageGetGhostMannequinSize.PortraitHd43,
                "SQUARE_HD" => EditImageGetGhostMannequinSize.SquareHd,
                _ => null,
            };
        }
    }
}