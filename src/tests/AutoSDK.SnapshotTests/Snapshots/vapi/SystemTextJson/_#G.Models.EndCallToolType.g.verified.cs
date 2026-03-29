//HintName: G.Models.EndCallToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "endCall" for End Call tool.
    /// </summary>
    public enum EndCallToolType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndCallToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndCallToolType value)
        {
            return value switch
            {
                EndCallToolType.EndCall => "endCall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndCallToolType? ToEnum(string value)
        {
            return value switch
            {
                "endCall" => EndCallToolType.EndCall,
                _ => null,
            };
        }
    }
}