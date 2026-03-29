//HintName: G.Models.OpenAIModelToolStrictCompatibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Azure OpenAI doesn't support `maxLength` right now https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/structured-outputs?tabs=python-secure%2Cdotnet-entra-id&amp;pivots=programming-language-csharp#unsupported-type-specific-keywords. Need to strip.<br/>
    /// - `strip-parameters-with-unsupported-validation` will strip parameters with unsupported validation.<br/>
    /// - `strip-unsupported-validation` will keep the parameters but strip unsupported validation.<br/>
    /// @default `strip-unsupported-validation`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIModelToolStrictCompatibilityMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="strip-parameters-with-unsupported-validation")]
        StripParametersWithUnsupportedValidation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="strip-unsupported-validation")]
        StripUnsupportedValidation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIModelToolStrictCompatibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIModelToolStrictCompatibilityMode value)
        {
            return value switch
            {
                OpenAIModelToolStrictCompatibilityMode.StripParametersWithUnsupportedValidation => "strip-parameters-with-unsupported-validation",
                OpenAIModelToolStrictCompatibilityMode.StripUnsupportedValidation => "strip-unsupported-validation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIModelToolStrictCompatibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "strip-parameters-with-unsupported-validation" => OpenAIModelToolStrictCompatibilityMode.StripParametersWithUnsupportedValidation,
                "strip-unsupported-validation" => OpenAIModelToolStrictCompatibilityMode.StripUnsupportedValidation,
                _ => null,
            };
        }
    }
}