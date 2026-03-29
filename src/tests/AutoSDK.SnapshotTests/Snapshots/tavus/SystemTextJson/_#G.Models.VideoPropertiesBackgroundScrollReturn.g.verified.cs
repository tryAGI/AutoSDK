//HintName: G.Models.VideoPropertiesBackgroundScrollReturn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoPropertiesBackgroundScrollReturn
    {
        /// <summary>
        /// 
        /// </summary>
        Halt,
        /// <summary>
        /// 
        /// </summary>
        Return,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoPropertiesBackgroundScrollReturnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoPropertiesBackgroundScrollReturn value)
        {
            return value switch
            {
                VideoPropertiesBackgroundScrollReturn.Halt => "halt",
                VideoPropertiesBackgroundScrollReturn.Return => "return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoPropertiesBackgroundScrollReturn? ToEnum(string value)
        {
            return value switch
            {
                "halt" => VideoPropertiesBackgroundScrollReturn.Halt,
                "return" => VideoPropertiesBackgroundScrollReturn.Return,
                _ => null,
            };
        }
    }
}