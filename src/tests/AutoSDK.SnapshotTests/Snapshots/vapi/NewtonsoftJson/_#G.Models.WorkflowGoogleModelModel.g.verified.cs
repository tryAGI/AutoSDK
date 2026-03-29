//HintName: G.Models.WorkflowGoogleModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowGoogleModelModel
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
    public static class WorkflowGoogleModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowGoogleModelModel value)
        {
            return value switch
            {
                WorkflowGoogleModelModel.Gemini10Pro => "gemini-1.0-pro",
                WorkflowGoogleModelModel.Gemini15Flash => "gemini-1.5-flash",
                WorkflowGoogleModelModel.Gemini15Flash002 => "gemini-1.5-flash-002",
                WorkflowGoogleModelModel.Gemini15Pro => "gemini-1.5-pro",
                WorkflowGoogleModelModel.Gemini15Pro002 => "gemini-1.5-pro-002",
                WorkflowGoogleModelModel.Gemini20Flash => "gemini-2.0-flash",
                WorkflowGoogleModelModel.Gemini20FlashExp => "gemini-2.0-flash-exp",
                WorkflowGoogleModelModel.Gemini20FlashLite => "gemini-2.0-flash-lite",
                WorkflowGoogleModelModel.Gemini20FlashRealtimeExp => "gemini-2.0-flash-realtime-exp",
                WorkflowGoogleModelModel.Gemini20FlashThinkingExp => "gemini-2.0-flash-thinking-exp",
                WorkflowGoogleModelModel.Gemini20ProExp0205 => "gemini-2.0-pro-exp-02-05",
                WorkflowGoogleModelModel.Gemini25Flash => "gemini-2.5-flash",
                WorkflowGoogleModelModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                WorkflowGoogleModelModel.Gemini25Pro => "gemini-2.5-pro",
                WorkflowGoogleModelModel.Gemini3FlashPreview => "gemini-3-flash-preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowGoogleModelModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-1.0-pro" => WorkflowGoogleModelModel.Gemini10Pro,
                "gemini-1.5-flash" => WorkflowGoogleModelModel.Gemini15Flash,
                "gemini-1.5-flash-002" => WorkflowGoogleModelModel.Gemini15Flash002,
                "gemini-1.5-pro" => WorkflowGoogleModelModel.Gemini15Pro,
                "gemini-1.5-pro-002" => WorkflowGoogleModelModel.Gemini15Pro002,
                "gemini-2.0-flash" => WorkflowGoogleModelModel.Gemini20Flash,
                "gemini-2.0-flash-exp" => WorkflowGoogleModelModel.Gemini20FlashExp,
                "gemini-2.0-flash-lite" => WorkflowGoogleModelModel.Gemini20FlashLite,
                "gemini-2.0-flash-realtime-exp" => WorkflowGoogleModelModel.Gemini20FlashRealtimeExp,
                "gemini-2.0-flash-thinking-exp" => WorkflowGoogleModelModel.Gemini20FlashThinkingExp,
                "gemini-2.0-pro-exp-02-05" => WorkflowGoogleModelModel.Gemini20ProExp0205,
                "gemini-2.5-flash" => WorkflowGoogleModelModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => WorkflowGoogleModelModel.Gemini25FlashLite,
                "gemini-2.5-pro" => WorkflowGoogleModelModel.Gemini25Pro,
                "gemini-3-flash-preview" => WorkflowGoogleModelModel.Gemini3FlashPreview,
                _ => null,
            };
        }
    }
}