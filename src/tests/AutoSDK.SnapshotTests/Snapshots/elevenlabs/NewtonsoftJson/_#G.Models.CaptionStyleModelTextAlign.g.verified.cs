//HintName: G.Models.CaptionStyleModelTextAlign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CaptionStyleModelTextAlign
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="center")]
        Center,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end")]
        End,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="start")]
        Start,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextAlign value)
        {
            return value switch
            {
                CaptionStyleModelTextAlign.Center => "center",
                CaptionStyleModelTextAlign.End => "end",
                CaptionStyleModelTextAlign.Start => "start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextAlign? ToEnum(string value)
        {
            return value switch
            {
                "center" => CaptionStyleModelTextAlign.Center,
                "end" => CaptionStyleModelTextAlign.End,
                "start" => CaptionStyleModelTextAlign.Start,
                _ => null,
            };
        }
    }
}