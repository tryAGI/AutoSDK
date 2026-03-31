//HintName: G.Models.OutputFormatContainer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Raw,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormatContainer value)
        {
            return value switch
            {
                OutputFormatContainer.Mp3 => "mp3",
                OutputFormatContainer.Raw => "raw",
                OutputFormatContainer.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => OutputFormatContainer.Mp3,
                "raw" => OutputFormatContainer.Raw,
                "wav" => OutputFormatContainer.Wav,
                _ => null,
            };
        }
    }
}