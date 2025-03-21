//HintName: G.Models.FineTuneSupervisedMethodHyperparametersBatchSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneSupervisedMethodHyperparametersBatchSize
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneSupervisedMethodHyperparametersBatchSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneSupervisedMethodHyperparametersBatchSize value)
        {
            return value switch
            {
                FineTuneSupervisedMethodHyperparametersBatchSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneSupervisedMethodHyperparametersBatchSize? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneSupervisedMethodHyperparametersBatchSize.Auto,
                _ => null,
            };
        }
    }
}