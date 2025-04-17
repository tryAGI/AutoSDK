//HintName: G.Models.FTClassifierLossFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FTClassifierLossFunction
    {
        /// <summary>
        /// 
        /// </summary>
        SingleClass,
        /// <summary>
        /// 
        /// </summary>
        MultiClass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FTClassifierLossFunctionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FTClassifierLossFunction value)
        {
            return value switch
            {
                FTClassifierLossFunction.SingleClass => "single_class",
                FTClassifierLossFunction.MultiClass => "multi_class",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FTClassifierLossFunction? ToEnum(string value)
        {
            return value switch
            {
                "single_class" => FTClassifierLossFunction.SingleClass,
                "multi_class" => FTClassifierLossFunction.MultiClass,
                _ => null,
            };
        }
    }
}