//HintName: G.Models.ToolCallSoundType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Predefined tool call sound types.
    /// </summary>
    public enum ToolCallSoundType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevator1,
        /// <summary>
        /// 
        /// </summary>
        Elevator2,
        /// <summary>
        /// 
        /// </summary>
        Elevator3,
        /// <summary>
        /// 
        /// </summary>
        Elevator4,
        /// <summary>
        /// 
        /// </summary>
        Typing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallSoundTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallSoundType value)
        {
            return value switch
            {
                ToolCallSoundType.Elevator1 => "elevator1",
                ToolCallSoundType.Elevator2 => "elevator2",
                ToolCallSoundType.Elevator3 => "elevator3",
                ToolCallSoundType.Elevator4 => "elevator4",
                ToolCallSoundType.Typing => "typing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallSoundType? ToEnum(string value)
        {
            return value switch
            {
                "elevator1" => ToolCallSoundType.Elevator1,
                "elevator2" => ToolCallSoundType.Elevator2,
                "elevator3" => ToolCallSoundType.Elevator3,
                "elevator4" => ToolCallSoundType.Elevator4,
                "typing" => ToolCallSoundType.Typing,
                _ => null,
            };
        }
    }
}