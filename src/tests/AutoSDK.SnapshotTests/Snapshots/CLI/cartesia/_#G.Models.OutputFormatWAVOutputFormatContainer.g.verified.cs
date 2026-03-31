//HintName: G.Models.OutputFormatWAVOutputFormatContainer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormatWAVOutputFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatWAVOutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormatWAVOutputFormatContainer value)
        {
            return value switch
            {
                OutputFormatWAVOutputFormatContainer.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormatWAVOutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "wav" => OutputFormatWAVOutputFormatContainer.Wav,
                _ => null,
            };
        }
    }
}