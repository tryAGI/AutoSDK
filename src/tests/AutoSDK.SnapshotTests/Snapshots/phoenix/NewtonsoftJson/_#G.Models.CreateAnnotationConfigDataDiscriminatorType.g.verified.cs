//HintName: G.Models.CreateAnnotationConfigDataDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAnnotationConfigDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATEGORICAL")]
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTINUOUS")]
        Continuous,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FREEFORM")]
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