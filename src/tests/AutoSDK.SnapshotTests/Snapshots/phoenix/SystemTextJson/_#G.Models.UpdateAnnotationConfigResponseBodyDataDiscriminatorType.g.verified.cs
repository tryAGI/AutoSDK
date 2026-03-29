//HintName: G.Models.UpdateAnnotationConfigResponseBodyDataDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAnnotationConfigResponseBodyDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        Continuous,
        /// <summary>
        /// 
        /// </summary>
        Freeform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAnnotationConfigResponseBodyDataDiscriminatorType value)
        {
            return value switch
            {
                UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Categorical => "CATEGORICAL",
                UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Continuous => "CONTINUOUS",
                UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Freeform => "FREEFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAnnotationConfigResponseBodyDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Categorical,
                "CONTINUOUS" => UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Continuous,
                "FREEFORM" => UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Freeform,
                _ => null,
            };
        }
    }
}