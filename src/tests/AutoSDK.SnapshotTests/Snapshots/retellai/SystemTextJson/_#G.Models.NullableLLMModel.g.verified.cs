//HintName: G.Models.NullableLLMModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Available LLM models for agents.
    /// </summary>
    public enum NullableLLMModel
    {
        /// <summary>
        /// 
        /// </summary>
        Claude45Haiku,
        /// <summary>
        /// 
        /// </summary>
        Claude45Sonnet,
        /// <summary>
        /// 
        /// </summary>
        Claude46Sonnet,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini30Flash,
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
        Gpt5,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt51,
        /// <summary>
        /// 
        /// </summary>
        Gpt52,
        /// <summary>
        /// 
        /// </summary>
        Gpt54,
        /// <summary>
        /// 
        /// </summary>
        Gpt54Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt54Nano,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableLLMModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableLLMModel value)
        {
            return value switch
            {
                NullableLLMModel.Claude45Haiku => "claude-4.5-haiku",
                NullableLLMModel.Claude45Sonnet => "claude-4.5-sonnet",
                NullableLLMModel.Claude46Sonnet => "claude-4.6-sonnet",
                NullableLLMModel.Gemini25Flash => "gemini-2.5-flash",
                NullableLLMModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                NullableLLMModel.Gemini30Flash => "gemini-3.0-flash",
                NullableLLMModel.Gpt41 => "gpt-4.1",
                NullableLLMModel.Gpt41Mini => "gpt-4.1-mini",
                NullableLLMModel.Gpt41Nano => "gpt-4.1-nano",
                NullableLLMModel.Gpt5 => "gpt-5",
                NullableLLMModel.Gpt5Mini => "gpt-5-mini",
                NullableLLMModel.Gpt5Nano => "gpt-5-nano",
                NullableLLMModel.Gpt51 => "gpt-5.1",
                NullableLLMModel.Gpt52 => "gpt-5.2",
                NullableLLMModel.Gpt54 => "gpt-5.4",
                NullableLLMModel.Gpt54Mini => "gpt-5.4-mini",
                NullableLLMModel.Gpt54Nano => "gpt-5.4-nano",
                NullableLLMModel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableLLMModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-4.5-haiku" => NullableLLMModel.Claude45Haiku,
                "claude-4.5-sonnet" => NullableLLMModel.Claude45Sonnet,
                "claude-4.6-sonnet" => NullableLLMModel.Claude46Sonnet,
                "gemini-2.5-flash" => NullableLLMModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => NullableLLMModel.Gemini25FlashLite,
                "gemini-3.0-flash" => NullableLLMModel.Gemini30Flash,
                "gpt-4.1" => NullableLLMModel.Gpt41,
                "gpt-4.1-mini" => NullableLLMModel.Gpt41Mini,
                "gpt-4.1-nano" => NullableLLMModel.Gpt41Nano,
                "gpt-5" => NullableLLMModel.Gpt5,
                "gpt-5-mini" => NullableLLMModel.Gpt5Mini,
                "gpt-5-nano" => NullableLLMModel.Gpt5Nano,
                "gpt-5.1" => NullableLLMModel.Gpt51,
                "gpt-5.2" => NullableLLMModel.Gpt52,
                "gpt-5.4" => NullableLLMModel.Gpt54,
                "gpt-5.4-mini" => NullableLLMModel.Gpt54Mini,
                "gpt-5.4-nano" => NullableLLMModel.Gpt54Nano,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => NullableLLMModel.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}