//HintName: G.Models.LLMModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Available LLM models for agents.
    /// </summary>
    public enum LLMModel
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMModel value)
        {
            return value switch
            {
                LLMModel.Claude45Haiku => "claude-4.5-haiku",
                LLMModel.Claude45Sonnet => "claude-4.5-sonnet",
                LLMModel.Claude46Sonnet => "claude-4.6-sonnet",
                LLMModel.Gemini25Flash => "gemini-2.5-flash",
                LLMModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                LLMModel.Gemini30Flash => "gemini-3.0-flash",
                LLMModel.Gpt41 => "gpt-4.1",
                LLMModel.Gpt41Mini => "gpt-4.1-mini",
                LLMModel.Gpt41Nano => "gpt-4.1-nano",
                LLMModel.Gpt5 => "gpt-5",
                LLMModel.Gpt5Mini => "gpt-5-mini",
                LLMModel.Gpt5Nano => "gpt-5-nano",
                LLMModel.Gpt51 => "gpt-5.1",
                LLMModel.Gpt52 => "gpt-5.2",
                LLMModel.Gpt54 => "gpt-5.4",
                LLMModel.Gpt54Mini => "gpt-5.4-mini",
                LLMModel.Gpt54Nano => "gpt-5.4-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-4.5-haiku" => LLMModel.Claude45Haiku,
                "claude-4.5-sonnet" => LLMModel.Claude45Sonnet,
                "claude-4.6-sonnet" => LLMModel.Claude46Sonnet,
                "gemini-2.5-flash" => LLMModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => LLMModel.Gemini25FlashLite,
                "gemini-3.0-flash" => LLMModel.Gemini30Flash,
                "gpt-4.1" => LLMModel.Gpt41,
                "gpt-4.1-mini" => LLMModel.Gpt41Mini,
                "gpt-4.1-nano" => LLMModel.Gpt41Nano,
                "gpt-5" => LLMModel.Gpt5,
                "gpt-5-mini" => LLMModel.Gpt5Mini,
                "gpt-5-nano" => LLMModel.Gpt5Nano,
                "gpt-5.1" => LLMModel.Gpt51,
                "gpt-5.2" => LLMModel.Gpt52,
                "gpt-5.4" => LLMModel.Gpt54,
                "gpt-5.4-mini" => LLMModel.Gpt54Mini,
                "gpt-5.4-nano" => LLMModel.Gpt54Nano,
                _ => null,
            };
        }
    }
}