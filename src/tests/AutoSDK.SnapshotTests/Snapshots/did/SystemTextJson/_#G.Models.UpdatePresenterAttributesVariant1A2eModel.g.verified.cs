//HintName: G.Models.UpdatePresenterAttributesVariant1A2eModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdatePresenterAttributesVariant1A2eModel
    {
        /// <summary>
        /// 
        /// </summary>
        BaselineDefault,
        /// <summary>
        /// 
        /// </summary>
        Finetuned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePresenterAttributesVariant1A2eModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePresenterAttributesVariant1A2eModel value)
        {
            return value switch
            {
                UpdatePresenterAttributesVariant1A2eModel.BaselineDefault => "Baseline (default)",
                UpdatePresenterAttributesVariant1A2eModel.Finetuned => "Finetuned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePresenterAttributesVariant1A2eModel? ToEnum(string value)
        {
            return value switch
            {
                "Baseline (default)" => UpdatePresenterAttributesVariant1A2eModel.BaselineDefault,
                "Finetuned" => UpdatePresenterAttributesVariant1A2eModel.Finetuned,
                _ => null,
            };
        }
    }
}