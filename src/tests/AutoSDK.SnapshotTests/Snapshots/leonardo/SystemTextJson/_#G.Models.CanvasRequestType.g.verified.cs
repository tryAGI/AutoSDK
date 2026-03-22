//HintName: G.Models.CanvasRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of request for the Canvas Editor.
    /// </summary>
    public enum CanvasRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Img2img,
        /// <summary>
        /// 
        /// </summary>
        Inpaint,
        /// <summary>
        /// 
        /// </summary>
        Outpaint,
        /// <summary>
        /// 
        /// </summary>
        Sketch2img,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CanvasRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CanvasRequestType value)
        {
            return value switch
            {
                CanvasRequestType.Img2img => "IMG2IMG",
                CanvasRequestType.Inpaint => "INPAINT",
                CanvasRequestType.Outpaint => "OUTPAINT",
                CanvasRequestType.Sketch2img => "SKETCH2IMG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CanvasRequestType? ToEnum(string value)
        {
            return value switch
            {
                "IMG2IMG" => CanvasRequestType.Img2img,
                "INPAINT" => CanvasRequestType.Inpaint,
                "OUTPAINT" => CanvasRequestType.Outpaint,
                "SKETCH2IMG" => CanvasRequestType.Sketch2img,
                _ => null,
            };
        }
    }
}