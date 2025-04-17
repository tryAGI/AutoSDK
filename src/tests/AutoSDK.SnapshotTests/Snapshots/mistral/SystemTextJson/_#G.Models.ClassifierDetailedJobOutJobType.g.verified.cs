//HintName: G.Models.ClassifierDetailedJobOutJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: classifier
    /// </summary>
    public enum ClassifierDetailedJobOutJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Classifier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierDetailedJobOutJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierDetailedJobOutJobType value)
        {
            return value switch
            {
                ClassifierDetailedJobOutJobType.Classifier => "classifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierDetailedJobOutJobType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => ClassifierDetailedJobOutJobType.Classifier,
                _ => null,
            };
        }
    }
}