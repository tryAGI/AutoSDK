//HintName: G.Models.LastMileConfigFormVariant2Variant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LastMileConfigFormVariant2Variant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Faithfulness,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LastMileConfigFormVariant2Variant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LastMileConfigFormVariant2Variant2Type value)
        {
            return value switch
            {
                LastMileConfigFormVariant2Variant2Type.Faithfulness => "faithfulness",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LastMileConfigFormVariant2Variant2Type? ToEnum(string value)
        {
            return value switch
            {
                "faithfulness" => LastMileConfigFormVariant2Variant2Type.Faithfulness,
                _ => null,
            };
        }
    }
}