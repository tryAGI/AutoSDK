//HintName: G.Models.OutputFormatMP3OutputFormatContainer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputFormatMP3OutputFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatMP3OutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormatMP3OutputFormatContainer value)
        {
            return value switch
            {
                OutputFormatMP3OutputFormatContainer.Mp3 => "mp3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormatMP3OutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => OutputFormatMP3OutputFormatContainer.Mp3,
                _ => null,
            };
        }
    }
}