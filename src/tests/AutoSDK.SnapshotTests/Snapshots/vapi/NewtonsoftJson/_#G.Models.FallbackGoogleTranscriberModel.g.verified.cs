//HintName: G.Models.FallbackGoogleTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackGoogleTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.0-pro")]
        Gemini10Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-flash")]
        Gemini15Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-flash-002")]
        Gemini15Flash002,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-pro")]
        Gemini15Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-pro-002")]
        Gemini15Pro002,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash")]
        Gemini20Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash-exp")]
        Gemini20FlashExp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash-lite")]
        Gemini20FlashLite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash-realtime-exp")]
        Gemini20FlashRealtimeExp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash-thinking-exp")]
        Gemini20FlashThinkingExp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-pro-exp-02-05")]
        Gemini20ProExp0205,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash")]
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash-lite")]
        Gemini25FlashLite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-pro")]
        Gemini25Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-3-flash-preview")]
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