//HintName: G.Models.GoogleTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    public enum GoogleTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gemini10Pro,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Flash002,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Pro,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Pro002,
        /// <summary>
        /// 
        /// </summary>
        Gemini20Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini20FlashExp,
        /// <summary>
        /// 
        /// </summary>
        Gemini20FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini20FlashRealtimeExp,
        /// <summary>
        /// 
        /// </summary>
        Gemini20FlashThinkingExp,
        /// <summary>
        /// 
        /// </summary>
        Gemini20ProExp0205,
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
        Gemini25Pro,
        /// <summary>
        /// 
        /// </summary>
        Gemini3FlashPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleTranscriberModel value)
        {
            return value switch
            {
                GoogleTranscriberModel.Gemini10Pro => "gemini-1.0-pro",
                GoogleTranscriberModel.Gemini15Flash => "gemini-1.5-flash",
                GoogleTranscriberModel.Gemini15Flash002 => "gemini-1.5-flash-002",
                GoogleTranscriberModel.Gemini15Pro => "gemini-1.5-pro",
                GoogleTranscriberModel.Gemini15Pro002 => "gemini-1.5-pro-002",
                GoogleTranscriberModel.Gemini20Flash => "gemini-2.0-flash",
                GoogleTranscriberModel.Gemini20FlashExp => "gemini-2.0-flash-exp",
                GoogleTranscriberModel.Gemini20FlashLite => "gemini-2.0-flash-lite",
                GoogleTranscriberModel.Gemini20FlashRealtimeExp => "gemini-2.0-flash-realtime-exp",
                GoogleTranscriberModel.Gemini20FlashThinkingExp => "gemini-2.0-flash-thinking-exp",
                GoogleTranscriberModel.Gemini20ProExp0205 => "gemini-2.0-pro-exp-02-05",
                GoogleTranscriberModel.Gemini25Flash => "gemini-2.5-flash",
                GoogleTranscriberModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                GoogleTranscriberModel.Gemini25Pro => "gemini-2.5-pro",
                GoogleTranscriberModel.Gemini3FlashPreview => "gemini-3-flash-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-1.0-pro" => GoogleTranscriberModel.Gemini10Pro,
                "gemini-1.5-flash" => GoogleTranscriberModel.Gemini15Flash,
                "gemini-1.5-flash-002" => GoogleTranscriberModel.Gemini15Flash002,
                "gemini-1.5-pro" => GoogleTranscriberModel.Gemini15Pro,
                "gemini-1.5-pro-002" => GoogleTranscriberModel.Gemini15Pro002,
                "gemini-2.0-flash" => GoogleTranscriberModel.Gemini20Flash,
                "gemini-2.0-flash-exp" => GoogleTranscriberModel.Gemini20FlashExp,
                "gemini-2.0-flash-lite" => GoogleTranscriberModel.Gemini20FlashLite,
                "gemini-2.0-flash-realtime-exp" => GoogleTranscriberModel.Gemini20FlashRealtimeExp,
                "gemini-2.0-flash-thinking-exp" => GoogleTranscriberModel.Gemini20FlashThinkingExp,
                "gemini-2.0-pro-exp-02-05" => GoogleTranscriberModel.Gemini20ProExp0205,
                "gemini-2.5-flash" => GoogleTranscriberModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => GoogleTranscriberModel.Gemini25FlashLite,
                "gemini-2.5-pro" => GoogleTranscriberModel.Gemini25Pro,
                "gemini-3-flash-preview" => GoogleTranscriberModel.Gemini3FlashPreview,
                _ => null,
            };
        }
    }
}