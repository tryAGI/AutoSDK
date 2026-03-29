//HintName: G.Models.MaskingRequestBodyDiscriminatorMaskSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MaskingRequestBodyDiscriminatorMaskSource
    {
        /// <summary>
        /// 
        /// </summary>
        InitImageAlpha,
        /// <summary>
        /// 
        /// </summary>
        MaskImageBlack,
        /// <summary>
        /// 
        /// </summary>
        MaskImageWhite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MaskingRequestBodyDiscriminatorMaskSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MaskingRequestBodyDiscriminatorMaskSource value)
        {
            return value switch
            {
                MaskingRequestBodyDiscriminatorMaskSource.InitImageAlpha => "INIT_IMAGE_ALPHA",
                MaskingRequestBodyDiscriminatorMaskSource.MaskImageBlack => "MASK_IMAGE_BLACK",
                MaskingRequestBodyDiscriminatorMaskSource.MaskImageWhite => "MASK_IMAGE_WHITE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MaskingRequestBodyDiscriminatorMaskSource? ToEnum(string value)
        {
            return value switch
            {
                "INIT_IMAGE_ALPHA" => MaskingRequestBodyDiscriminatorMaskSource.InitImageAlpha,
                "MASK_IMAGE_BLACK" => MaskingRequestBodyDiscriminatorMaskSource.MaskImageBlack,
                "MASK_IMAGE_WHITE" => MaskingRequestBodyDiscriminatorMaskSource.MaskImageWhite,
                _ => null,
            };
        }
    }
}