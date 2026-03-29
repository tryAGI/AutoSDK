//HintName: G.Models.CreateAnnotationConfigDataDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAnnotationConfigDataDiscriminatorType
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
    public static class CreateAnnotationConfigDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnnotationConfigDataDiscriminatorType value)
        {
            return value switch
            {
                CreateAnnotationConfigDataDiscriminatorType.Categorical => "CATEGORICAL",
                CreateAnnotationConfigDataDiscriminatorType.Continuous => "CONTINUOUS",
                CreateAnnotationConfigDataDiscriminatorType.Freeform => "FREEFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnnotationConfigDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => CreateAnnotationConfigDataDiscriminatorType.Categorical,
                "CONTINUOUS" => CreateAnnotationConfigDataDiscriminatorType.Continuous,
                "FREEFORM" => CreateAnnotationConfigDataDiscriminatorType.Freeform,
                _ => null,
            };
        }
    }
}