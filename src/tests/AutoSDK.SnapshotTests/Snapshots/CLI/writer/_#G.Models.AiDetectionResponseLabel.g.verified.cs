//HintName: G.Models.AiDetectionResponseLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: fake
    /// </summary>
    public enum AiDetectionResponseLabel
    {
        /// <summary>
        /// 
        /// </summary>
        Fake,
        /// <summary>
        /// 
        /// </summary>
        Real,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiDetectionResponseLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiDetectionResponseLabel value)
        {
            return value switch
            {
                AiDetectionResponseLabel.Fake => "fake",
                AiDetectionResponseLabel.Real => "real",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiDetectionResponseLabel? ToEnum(string value)
        {
            return value switch
            {
                "fake" => AiDetectionResponseLabel.Fake,
                "real" => AiDetectionResponseLabel.Real,
                _ => null,
            };
        }
    }
}