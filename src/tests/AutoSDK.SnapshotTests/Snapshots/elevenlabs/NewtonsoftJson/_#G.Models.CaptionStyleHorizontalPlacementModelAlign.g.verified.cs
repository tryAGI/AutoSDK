//HintName: G.Models.CaptionStyleHorizontalPlacementModelAlign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CaptionStyleHorizontalPlacementModelAlign
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="left")]
        Left,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="center")]
        Center,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="right")]
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleHorizontalPlacementModelAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleHorizontalPlacementModelAlign value)
        {
            return value switch
            {
                CaptionStyleHorizontalPlacementModelAlign.Left => "left",
                CaptionStyleHorizontalPlacementModelAlign.Center => "center",
                CaptionStyleHorizontalPlacementModelAlign.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleHorizontalPlacementModelAlign? ToEnum(string value)
        {
            return value switch
            {
                "left" => CaptionStyleHorizontalPlacementModelAlign.Left,
                "center" => CaptionStyleHorizontalPlacementModelAlign.Center,
                "right" => CaptionStyleHorizontalPlacementModelAlign.Right,
                _ => null,
            };
        }
    }
}