//HintName: G.Models.UpdateRequestLlmOpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum UpdateRequestLlmOpenAIModel
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
    public static class UpdateRequestLlmOpenAIModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestLlmOpenAIModel value)
        {
            return value switch
            {
                UpdateRequestLlmOpenAIModel.Gpt41 => "gpt-4.1",
                UpdateRequestLlmOpenAIModel.Gpt41Mini => "gpt-4.1-mini",
                UpdateRequestLlmOpenAIModel.Gpt41Nano => "gpt-4.1-nano",
                UpdateRequestLlmOpenAIModel.Gpt4oGlobal => "gpt-4o-global",
                UpdateRequestLlmOpenAIModel.Gpt4oMini => "gpt-4o-mini",
                UpdateRequestLlmOpenAIModel.Gpt5Mini => "gpt-5-mini",
                UpdateRequestLlmOpenAIModel.Gpt5Nano => "gpt-5-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestLlmOpenAIModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => UpdateRequestLlmOpenAIModel.Gpt41,
                "gpt-4.1-mini" => UpdateRequestLlmOpenAIModel.Gpt41Mini,
                "gpt-4.1-nano" => UpdateRequestLlmOpenAIModel.Gpt41Nano,
                "gpt-4o-global" => UpdateRequestLlmOpenAIModel.Gpt4oGlobal,
                "gpt-4o-mini" => UpdateRequestLlmOpenAIModel.Gpt4oMini,
                "gpt-5-mini" => UpdateRequestLlmOpenAIModel.Gpt5Mini,
                "gpt-5-nano" => UpdateRequestLlmOpenAIModel.Gpt5Nano,
                _ => null,
            };
        }
    }
}