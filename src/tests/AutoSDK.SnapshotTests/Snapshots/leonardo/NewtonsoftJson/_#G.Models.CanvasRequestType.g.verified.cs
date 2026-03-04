//HintName: G.Models.CanvasRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of request for the Canvas Editor.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CanvasRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INPAINT")]
        Inpaint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OUTPAINT")]
        Outpaint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SKETCH2IMG")]
        Sketch2img,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IMG2IMG")]
        Img2img,
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
                CanvasRequestType.Inpaint => "INPAINT",
                CanvasRequestType.Outpaint => "OUTPAINT",
                CanvasRequestType.Sketch2img => "SKETCH2IMG",
                CanvasRequestType.Img2img => "IMG2IMG",
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
                "INPAINT" => CanvasRequestType.Inpaint,
                "OUTPAINT" => CanvasRequestType.Outpaint,
                "SKETCH2IMG" => CanvasRequestType.Sketch2img,
                "IMG2IMG" => CanvasRequestType.Img2img,
                _ => null,
            };
        }
    }
}