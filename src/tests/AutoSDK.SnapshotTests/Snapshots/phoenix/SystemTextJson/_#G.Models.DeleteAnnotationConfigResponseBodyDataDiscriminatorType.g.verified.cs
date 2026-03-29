//HintName: G.Models.DeleteAnnotationConfigResponseBodyDataDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteAnnotationConfigResponseBodyDataDiscriminatorType
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
    public static class DeleteAnnotationConfigResponseBodyDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAnnotationConfigResponseBodyDataDiscriminatorType value)
        {
            return value switch
            {
                DeleteAnnotationConfigResponseBodyDataDiscriminatorType.Categorical => "CATEGORICAL",
                DeleteAnnotationConfigResponseBodyDataDiscriminatorType.Continuous => "CONTINUOUS",
                DeleteAnnotationConfigResponseBodyDataDiscriminatorType.Freeform => "FREEFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAnnotationConfigResponseBodyDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => DeleteAnnotationConfigResponseBodyDataDiscriminatorType.Categorical,
                "CONTINUOUS" => DeleteAnnotationConfigResponseBodyDataDiscriminatorType.Continuous,
                "FREEFORM" => DeleteAnnotationConfigResponseBodyDataDiscriminatorType.Freeform,
                _ => null,
            };
        }
    }
}