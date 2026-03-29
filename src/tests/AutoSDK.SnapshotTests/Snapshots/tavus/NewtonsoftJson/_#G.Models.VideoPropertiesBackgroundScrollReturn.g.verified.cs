//HintName: G.Models.VideoPropertiesBackgroundScrollReturn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VideoPropertiesBackgroundScrollReturn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="halt")]
        Halt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="return")]
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