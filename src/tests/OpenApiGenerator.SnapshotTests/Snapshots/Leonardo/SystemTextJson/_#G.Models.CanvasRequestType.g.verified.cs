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
        INPAINT,
        /// <summary>
        /// 
        /// </summary>
        OUTPAINT,
        /// <summary>
        /// 
        /// </summary>
        SKETCH2IMG,
        /// <summary>
        /// 
        /// </summary>
        IMG2IMG,
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
                CanvasRequestType.INPAINT => "INPAINT",
                CanvasRequestType.OUTPAINT => "OUTPAINT",
                CanvasRequestType.SKETCH2IMG => "SKETCH2IMG",
                CanvasRequestType.IMG2IMG => "IMG2IMG",
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
                "INPAINT" => CanvasRequestType.INPAINT,
                "OUTPAINT" => CanvasRequestType.OUTPAINT,
                "SKETCH2IMG" => CanvasRequestType.SKETCH2IMG,
                "IMG2IMG" => CanvasRequestType.IMG2IMG,
                _ => null,
            };
        }
    }
}