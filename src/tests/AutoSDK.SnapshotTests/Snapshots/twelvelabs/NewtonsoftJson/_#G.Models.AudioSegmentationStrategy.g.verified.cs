//HintName: G.Models.AudioSegmentationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AudioSegmentationStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioSegmentationStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioSegmentationStrategy value)
        {
            return value switch
            {
                AudioSegmentationStrategy.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioSegmentationStrategy? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => AudioSegmentationStrategy.Fixed,
                _ => null,
            };
        }
    }
}