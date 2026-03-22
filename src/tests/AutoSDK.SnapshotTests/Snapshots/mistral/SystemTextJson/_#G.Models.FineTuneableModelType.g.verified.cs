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
        Classifier,
        /// <summary>
        /// 
        /// </summary>
        Completion,
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
                FineTuneableModelType.Classifier => "classifier",
                FineTuneableModelType.Completion => "completion",
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
                "classifier" => FineTuneableModelType.Classifier,
                "completion" => FineTuneableModelType.Completion,
                _ => null,
            };
        }
    }
}