//HintName: G.Models.ClassifierFTModelOutModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: classifier
    /// </summary>
    public enum ClassifierFTModelOutModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Classifier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierFTModelOutModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierFTModelOutModelType value)
        {
            return value switch
            {
                ClassifierFTModelOutModelType.Classifier => "classifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierFTModelOutModelType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => ClassifierFTModelOutModelType.Classifier,
                _ => null,
            };
        }
    }
}