//HintName: G.Models.EditImageGetLayersVariant2ImageImageFromPromptSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Supported sizes for AI image generation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetLayersVariant2ImageImageFromPromptSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LANDSCAPE_16_9")]
        Landscape169,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LANDSCAPE_4_3")]
        Landscape43,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PORTRAIT_16_9")]
        Portrait169,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PORTRAIT_4_3")]
        Portrait43,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SQUARE_HD")]
        SquareHd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetLayersVariant2ImageImageFromPromptSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetLayersVariant2ImageImageFromPromptSize value)
        {
            return value switch
            {
                EditImageGetLayersVariant2ImageImageFromPromptSize.Landscape169 => "LANDSCAPE_16_9",
                EditImageGetLayersVariant2ImageImageFromPromptSize.Landscape43 => "LANDSCAPE_4_3",
                EditImageGetLayersVariant2ImageImageFromPromptSize.Portrait169 => "PORTRAIT_16_9",
                EditImageGetLayersVariant2ImageImageFromPromptSize.Portrait43 => "PORTRAIT_4_3",
                EditImageGetLayersVariant2ImageImageFromPromptSize.SquareHd => "SQUARE_HD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetLayersVariant2ImageImageFromPromptSize? ToEnum(string value)
        {
            return value switch
            {
                "LANDSCAPE_16_9" => EditImageGetLayersVariant2ImageImageFromPromptSize.Landscape169,
                "LANDSCAPE_4_3" => EditImageGetLayersVariant2ImageImageFromPromptSize.Landscape43,
                "PORTRAIT_16_9" => EditImageGetLayersVariant2ImageImageFromPromptSize.Portrait169,
                "PORTRAIT_4_3" => EditImageGetLayersVariant2ImageImageFromPromptSize.Portrait43,
                "SQUARE_HD" => EditImageGetLayersVariant2ImageImageFromPromptSize.SquareHd,
                _ => null,
            };
        }
    }
}