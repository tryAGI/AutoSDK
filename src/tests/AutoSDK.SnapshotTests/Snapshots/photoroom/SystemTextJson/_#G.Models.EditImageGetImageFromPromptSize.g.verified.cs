//HintName: G.Models.EditImageGetImageFromPromptSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetImageFromPromptSize
    {
        /// <summary>
        /// 
        /// </summary>
        Landscape169,
        /// <summary>
        /// 
        /// </summary>
        Landscape43,
        /// <summary>
        /// 
        /// </summary>
        Portrait169,
        /// <summary>
        /// 
        /// </summary>
        Portrait43,
        /// <summary>
        /// 
        /// </summary>
        SquareHd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetImageFromPromptSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetImageFromPromptSize value)
        {
            return value switch
            {
                EditImageGetImageFromPromptSize.Landscape169 => "LANDSCAPE_16_9",
                EditImageGetImageFromPromptSize.Landscape43 => "LANDSCAPE_4_3",
                EditImageGetImageFromPromptSize.Portrait169 => "PORTRAIT_16_9",
                EditImageGetImageFromPromptSize.Portrait43 => "PORTRAIT_4_3",
                EditImageGetImageFromPromptSize.SquareHd => "SQUARE_HD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetImageFromPromptSize? ToEnum(string value)
        {
            return value switch
            {
                "LANDSCAPE_16_9" => EditImageGetImageFromPromptSize.Landscape169,
                "LANDSCAPE_4_3" => EditImageGetImageFromPromptSize.Landscape43,
                "PORTRAIT_16_9" => EditImageGetImageFromPromptSize.Portrait169,
                "PORTRAIT_4_3" => EditImageGetImageFromPromptSize.Portrait43,
                "SQUARE_HD" => EditImageGetImageFromPromptSize.SquareHd,
                _ => null,
            };
        }
    }
}