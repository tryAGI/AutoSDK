//HintName: G.Models.TranslationFunctionModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for translation.
    /// </summary>
    public enum TranslationFunctionModel
    {
        /// <summary>
        /// 
        /// </summary>
        PalmyraTranslate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationFunctionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationFunctionModel value)
        {
            return value switch
            {
                TranslationFunctionModel.PalmyraTranslate => "palmyra-translate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationFunctionModel? ToEnum(string value)
        {
            return value switch
            {
                "palmyra-translate" => TranslationFunctionModel.PalmyraTranslate,
                _ => null,
            };
        }
    }
}