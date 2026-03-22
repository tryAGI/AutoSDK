//HintName: G.Models.CaptionStyleVerticalPlacementModelAlign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CaptionStyleVerticalPlacementModelAlign
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bottom")]
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="center")]
        Center,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top")]
        Top,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleVerticalPlacementModelAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleVerticalPlacementModelAlign value)
        {
            return value switch
            {
                CaptionStyleVerticalPlacementModelAlign.Bottom => "bottom",
                CaptionStyleVerticalPlacementModelAlign.Center => "center",
                CaptionStyleVerticalPlacementModelAlign.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleVerticalPlacementModelAlign? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => CaptionStyleVerticalPlacementModelAlign.Bottom,
                "center" => CaptionStyleVerticalPlacementModelAlign.Center,
                "top" => CaptionStyleVerticalPlacementModelAlign.Top,
                _ => null,
            };
        }
    }
}