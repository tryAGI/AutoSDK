//HintName: G.Models.ToolCallSoundBehavior.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Determines how the tool call sound should be played.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolCallSoundBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always")]
        Always,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallSoundBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallSoundBehavior value)
        {
            return value switch
            {
                ToolCallSoundBehavior.Auto => "auto",
                ToolCallSoundBehavior.Always => "always",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallSoundBehavior? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolCallSoundBehavior.Auto,
                "always" => ToolCallSoundBehavior.Always,
                _ => null,
            };
        }
    }
}