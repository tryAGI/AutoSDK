//HintName: G.Models.LanguageDetectionToolConfigSystemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: language_detection
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LanguageDetectionToolConfigSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language_detection")]
        LanguageDetection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageDetectionToolConfigSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageDetectionToolConfigSystemToolType value)
        {
            return value switch
            {
                LanguageDetectionToolConfigSystemToolType.LanguageDetection => "language_detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageDetectionToolConfigSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "language_detection" => LanguageDetectionToolConfigSystemToolType.LanguageDetection,
                _ => null,
            };
        }
    }
}