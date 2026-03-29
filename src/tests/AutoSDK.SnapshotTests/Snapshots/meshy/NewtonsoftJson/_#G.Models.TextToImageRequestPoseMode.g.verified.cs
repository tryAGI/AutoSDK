//HintName: G.Models.TextToImageRequestPoseMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextToImageRequestPoseMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="a-pose")]
        APose,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="t-pose")]
        TPose,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToImageRequestPoseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToImageRequestPoseMode value)
        {
            return value switch
            {
                TextToImageRequestPoseMode.APose => "a-pose",
                TextToImageRequestPoseMode.TPose => "t-pose",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToImageRequestPoseMode? ToEnum(string value)
        {
            return value switch
            {
                "a-pose" => TextToImageRequestPoseMode.APose,
                "t-pose" => TextToImageRequestPoseMode.TPose,
                _ => null,
            };
        }
    }
}