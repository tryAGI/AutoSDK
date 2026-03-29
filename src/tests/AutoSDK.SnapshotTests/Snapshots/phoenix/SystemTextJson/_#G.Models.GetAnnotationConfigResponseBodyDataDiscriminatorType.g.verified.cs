//HintName: G.Models.GetAnnotationConfigResponseBodyDataDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAnnotationConfigResponseBodyDataDiscriminatorType
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
    public static class GetAnnotationConfigResponseBodyDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnnotationConfigResponseBodyDataDiscriminatorType value)
        {
            return value switch
            {
                GetAnnotationConfigResponseBodyDataDiscriminatorType.Categorical => "CATEGORICAL",
                GetAnnotationConfigResponseBodyDataDiscriminatorType.Continuous => "CONTINUOUS",
                GetAnnotationConfigResponseBodyDataDiscriminatorType.Freeform => "FREEFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnnotationConfigResponseBodyDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => GetAnnotationConfigResponseBodyDataDiscriminatorType.Categorical,
                "CONTINUOUS" => GetAnnotationConfigResponseBodyDataDiscriminatorType.Continuous,
                "FREEFORM" => GetAnnotationConfigResponseBodyDataDiscriminatorType.Freeform,
                _ => null,
            };
        }
    }
}