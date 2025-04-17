//HintName: G.Models.ClassifierJobOutJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of job (`FT` for fine-tuning).<br/>
    /// Default Value: classifier
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClassifierJobOutJobType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classifier")]
        Classifier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierJobOutJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierJobOutJobType value)
        {
            return value switch
            {
                ClassifierJobOutJobType.Classifier => "classifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierJobOutJobType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => ClassifierJobOutJobType.Classifier,
                _ => null,
            };
        }
    }
}