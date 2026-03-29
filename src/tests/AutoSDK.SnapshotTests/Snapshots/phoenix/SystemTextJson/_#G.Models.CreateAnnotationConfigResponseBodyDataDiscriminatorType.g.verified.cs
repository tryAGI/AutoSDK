//HintName: G.Models.CreateAnnotationConfigResponseBodyDataDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAnnotationConfigResponseBodyDataDiscriminatorType
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
    public static class CreateAnnotationConfigResponseBodyDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnnotationConfigResponseBodyDataDiscriminatorType value)
        {
            return value switch
            {
                CreateAnnotationConfigResponseBodyDataDiscriminatorType.Categorical => "CATEGORICAL",
                CreateAnnotationConfigResponseBodyDataDiscriminatorType.Continuous => "CONTINUOUS",
                CreateAnnotationConfigResponseBodyDataDiscriminatorType.Freeform => "FREEFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnnotationConfigResponseBodyDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => CreateAnnotationConfigResponseBodyDataDiscriminatorType.Categorical,
                "CONTINUOUS" => CreateAnnotationConfigResponseBodyDataDiscriminatorType.Continuous,
                "FREEFORM" => CreateAnnotationConfigResponseBodyDataDiscriminatorType.Freeform,
                _ => null,
            };
        }
    }
}