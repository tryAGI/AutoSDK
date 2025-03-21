//HintName: G.Models.FineTuneDPOMethodHyperparametersBeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneDPOMethodHyperparametersBeta
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneDPOMethodHyperparametersBetaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneDPOMethodHyperparametersBeta value)
        {
            return value switch
            {
                FineTuneDPOMethodHyperparametersBeta.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneDPOMethodHyperparametersBeta? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneDPOMethodHyperparametersBeta.Auto,
                _ => null,
            };
        }
    }
}