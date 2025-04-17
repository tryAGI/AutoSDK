//HintName: G.Models.FineTuneableModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneableModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Completion,
        /// <summary>
        /// 
        /// </summary>
        Classifier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneableModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneableModelType value)
        {
            return value switch
            {
                FineTuneableModelType.Completion => "completion",
                FineTuneableModelType.Classifier => "classifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneableModelType? ToEnum(string value)
        {
            return value switch
            {
                "completion" => FineTuneableModelType.Completion,
                "classifier" => FineTuneableModelType.Classifier,
                _ => null,
            };
        }
    }
}