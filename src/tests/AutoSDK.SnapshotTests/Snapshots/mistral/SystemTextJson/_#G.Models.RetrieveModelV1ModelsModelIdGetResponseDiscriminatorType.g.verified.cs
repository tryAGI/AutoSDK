//HintName: G.Models.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Base,
        /// <summary>
        /// 
        /// </summary>
        FineTuned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType value)
        {
            return value switch
            {
                RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.Base => "base",
                RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.FineTuned => "fine-tuned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base" => RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.Base,
                "fine-tuned" => RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.FineTuned,
                _ => null,
            };
        }
    }
}