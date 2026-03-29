//HintName: G.Models.KnowledgeBaseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for the knowledge base
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeBaseModel
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
    public static class KnowledgeBaseModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseModel value)
        {
            return value switch
            {
                KnowledgeBaseModel.Gemini10Pro => "gemini-1.0-pro",
                KnowledgeBaseModel.Gemini15Flash => "gemini-1.5-flash",
                KnowledgeBaseModel.Gemini15Flash002 => "gemini-1.5-flash-002",
                KnowledgeBaseModel.Gemini15Pro => "gemini-1.5-pro",
                KnowledgeBaseModel.Gemini15Pro002 => "gemini-1.5-pro-002",
                KnowledgeBaseModel.Gemini20Flash => "gemini-2.0-flash",
                KnowledgeBaseModel.Gemini20FlashExp => "gemini-2.0-flash-exp",
                KnowledgeBaseModel.Gemini20FlashLite => "gemini-2.0-flash-lite",
                KnowledgeBaseModel.Gemini20FlashRealtimeExp => "gemini-2.0-flash-realtime-exp",
                KnowledgeBaseModel.Gemini20FlashThinkingExp => "gemini-2.0-flash-thinking-exp",
                KnowledgeBaseModel.Gemini20ProExp0205 => "gemini-2.0-pro-exp-02-05",
                KnowledgeBaseModel.Gemini25Flash => "gemini-2.5-flash",
                KnowledgeBaseModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                KnowledgeBaseModel.Gemini25Pro => "gemini-2.5-pro",
                KnowledgeBaseModel.Gemini3FlashPreview => "gemini-3-flash-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-1.0-pro" => KnowledgeBaseModel.Gemini10Pro,
                "gemini-1.5-flash" => KnowledgeBaseModel.Gemini15Flash,
                "gemini-1.5-flash-002" => KnowledgeBaseModel.Gemini15Flash002,
                "gemini-1.5-pro" => KnowledgeBaseModel.Gemini15Pro,
                "gemini-1.5-pro-002" => KnowledgeBaseModel.Gemini15Pro002,
                "gemini-2.0-flash" => KnowledgeBaseModel.Gemini20Flash,
                "gemini-2.0-flash-exp" => KnowledgeBaseModel.Gemini20FlashExp,
                "gemini-2.0-flash-lite" => KnowledgeBaseModel.Gemini20FlashLite,
                "gemini-2.0-flash-realtime-exp" => KnowledgeBaseModel.Gemini20FlashRealtimeExp,
                "gemini-2.0-flash-thinking-exp" => KnowledgeBaseModel.Gemini20FlashThinkingExp,
                "gemini-2.0-pro-exp-02-05" => KnowledgeBaseModel.Gemini20ProExp0205,
                "gemini-2.5-flash" => KnowledgeBaseModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => KnowledgeBaseModel.Gemini25FlashLite,
                "gemini-2.5-pro" => KnowledgeBaseModel.Gemini25Pro,
                "gemini-3-flash-preview" => KnowledgeBaseModel.Gemini3FlashPreview,
                _ => null,
            };
        }
    }
}