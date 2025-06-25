//HintName: G.Models.EndCallToolConfigSystemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: end_call
    /// </summary>
    public enum EndCallToolConfigSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndCallToolConfigSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndCallToolConfigSystemToolType value)
        {
            return value switch
            {
                EndCallToolConfigSystemToolType.EndCall => "end_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndCallToolConfigSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => EndCallToolConfigSystemToolType.EndCall,
                _ => null,
            };
        }
    }
}