//HintName: G.Models.FallbackGoogleTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    public enum FallbackGoogleTranscriberModel
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
    public static class FallbackGoogleTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackGoogleTranscriberModel value)
        {
            return value switch
            {
                FallbackGoogleTranscriberModel.Gemini10Pro => "gemini-1.0-pro",
                FallbackGoogleTranscriberModel.Gemini15Flash => "gemini-1.5-flash",
                FallbackGoogleTranscriberModel.Gemini15Flash002 => "gemini-1.5-flash-002",
                FallbackGoogleTranscriberModel.Gemini15Pro => "gemini-1.5-pro",
                FallbackGoogleTranscriberModel.Gemini15Pro002 => "gemini-1.5-pro-002",
                FallbackGoogleTranscriberModel.Gemini20Flash => "gemini-2.0-flash",
                FallbackGoogleTranscriberModel.Gemini20FlashExp => "gemini-2.0-flash-exp",
                FallbackGoogleTranscriberModel.Gemini20FlashLite => "gemini-2.0-flash-lite",
                FallbackGoogleTranscriberModel.Gemini20FlashRealtimeExp => "gemini-2.0-flash-realtime-exp",
                FallbackGoogleTranscriberModel.Gemini20FlashThinkingExp => "gemini-2.0-flash-thinking-exp",
                FallbackGoogleTranscriberModel.Gemini20ProExp0205 => "gemini-2.0-pro-exp-02-05",
                FallbackGoogleTranscriberModel.Gemini25Flash => "gemini-2.5-flash",
                FallbackGoogleTranscriberModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                FallbackGoogleTranscriberModel.Gemini25Pro => "gemini-2.5-pro",
                FallbackGoogleTranscriberModel.Gemini3FlashPreview => "gemini-3-flash-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackGoogleTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-1.0-pro" => FallbackGoogleTranscriberModel.Gemini10Pro,
                "gemini-1.5-flash" => FallbackGoogleTranscriberModel.Gemini15Flash,
                "gemini-1.5-flash-002" => FallbackGoogleTranscriberModel.Gemini15Flash002,
                "gemini-1.5-pro" => FallbackGoogleTranscriberModel.Gemini15Pro,
                "gemini-1.5-pro-002" => FallbackGoogleTranscriberModel.Gemini15Pro002,
                "gemini-2.0-flash" => FallbackGoogleTranscriberModel.Gemini20Flash,
                "gemini-2.0-flash-exp" => FallbackGoogleTranscriberModel.Gemini20FlashExp,
                "gemini-2.0-flash-lite" => FallbackGoogleTranscriberModel.Gemini20FlashLite,
                "gemini-2.0-flash-realtime-exp" => FallbackGoogleTranscriberModel.Gemini20FlashRealtimeExp,
                "gemini-2.0-flash-thinking-exp" => FallbackGoogleTranscriberModel.Gemini20FlashThinkingExp,
                "gemini-2.0-pro-exp-02-05" => FallbackGoogleTranscriberModel.Gemini20ProExp0205,
                "gemini-2.5-flash" => FallbackGoogleTranscriberModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => FallbackGoogleTranscriberModel.Gemini25FlashLite,
                "gemini-2.5-pro" => FallbackGoogleTranscriberModel.Gemini25Pro,
                "gemini-3-flash-preview" => FallbackGoogleTranscriberModel.Gemini3FlashPreview,
                _ => null,
            };
        }
    }
}