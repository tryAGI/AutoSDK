//HintName: G.Models.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAnnotationConfigsResponseBodyDataItemDiscriminatorType
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
    public static class GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnnotationConfigsResponseBodyDataItemDiscriminatorType value)
        {
            return value switch
            {
                GetAnnotationConfigsResponseBodyDataItemDiscriminatorType.Categorical => "CATEGORICAL",
                GetAnnotationConfigsResponseBodyDataItemDiscriminatorType.Continuous => "CONTINUOUS",
                GetAnnotationConfigsResponseBodyDataItemDiscriminatorType.Freeform => "FREEFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnnotationConfigsResponseBodyDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CATEGORICAL" => GetAnnotationConfigsResponseBodyDataItemDiscriminatorType.Categorical,
                "CONTINUOUS" => GetAnnotationConfigsResponseBodyDataItemDiscriminatorType.Continuous,
                "FREEFORM" => GetAnnotationConfigsResponseBodyDataItemDiscriminatorType.Freeform,
                _ => null,
            };
        }
    }
}