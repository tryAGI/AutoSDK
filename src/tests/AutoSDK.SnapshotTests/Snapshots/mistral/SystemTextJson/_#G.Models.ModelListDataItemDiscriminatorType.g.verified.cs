//HintName: G.Models.ModelListDataItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelListDataItemDiscriminatorType
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
    public static class ModelListDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelListDataItemDiscriminatorType value)
        {
            return value switch
            {
                ModelListDataItemDiscriminatorType.Base => "base",
                ModelListDataItemDiscriminatorType.FineTuned => "fine-tuned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelListDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base" => ModelListDataItemDiscriminatorType.Base,
                "fine-tuned" => ModelListDataItemDiscriminatorType.FineTuned,
                _ => null,
            };
        }
    }
}