//HintName: G.Models.UpdateResponseVariant1LlmOpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum UpdateResponseVariant1LlmOpenAIModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oGlobal,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResponseVariant1LlmOpenAIModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1LlmOpenAIModel value)
        {
            return value switch
            {
                UpdateResponseVariant1LlmOpenAIModel.Gpt41 => "gpt-4.1",
                UpdateResponseVariant1LlmOpenAIModel.Gpt41Mini => "gpt-4.1-mini",
                UpdateResponseVariant1LlmOpenAIModel.Gpt41Nano => "gpt-4.1-nano",
                UpdateResponseVariant1LlmOpenAIModel.Gpt4oGlobal => "gpt-4o-global",
                UpdateResponseVariant1LlmOpenAIModel.Gpt4oMini => "gpt-4o-mini",
                UpdateResponseVariant1LlmOpenAIModel.Gpt5Mini => "gpt-5-mini",
                UpdateResponseVariant1LlmOpenAIModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1LlmOpenAIModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => UpdateResponseVariant1LlmOpenAIModel.Gpt41,
                "gpt-4.1-mini" => UpdateResponseVariant1LlmOpenAIModel.Gpt41Mini,
                "gpt-4.1-nano" => UpdateResponseVariant1LlmOpenAIModel.Gpt41Nano,
                "gpt-4o-global" => UpdateResponseVariant1LlmOpenAIModel.Gpt4oGlobal,
                "gpt-4o-mini" => UpdateResponseVariant1LlmOpenAIModel.Gpt4oMini,
                "gpt-5-mini" => UpdateResponseVariant1LlmOpenAIModel.Gpt5Mini,
                "gpt-5-nano" => UpdateResponseVariant1LlmOpenAIModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}