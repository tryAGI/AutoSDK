//HintName: G.Models.CreateChatCompletionRequestVariant2AudioVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice the model uses to respond. Supported voices are <br/>
    /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, and `shimmer`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestVariant2AudioVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alloy")]
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ash")]
        Ash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ballad")]
        Ballad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="coral")]
        Coral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="echo")]
        Echo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sage")]
        Sage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shimmer")]
        Shimmer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verse")]
        Verse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestVariant2AudioVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestVariant2AudioVoice value)
        {
            return value switch
            {
                CreateChatCompletionRequestVariant2AudioVoice.Alloy => "alloy",
                CreateChatCompletionRequestVariant2AudioVoice.Ash => "ash",
                CreateChatCompletionRequestVariant2AudioVoice.Ballad => "ballad",
                CreateChatCompletionRequestVariant2AudioVoice.Coral => "coral",
                CreateChatCompletionRequestVariant2AudioVoice.Echo => "echo",
                CreateChatCompletionRequestVariant2AudioVoice.Sage => "sage",
                CreateChatCompletionRequestVariant2AudioVoice.Shimmer => "shimmer",
                CreateChatCompletionRequestVariant2AudioVoice.Verse => "verse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestVariant2AudioVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => CreateChatCompletionRequestVariant2AudioVoice.Alloy,
                "ash" => CreateChatCompletionRequestVariant2AudioVoice.Ash,
                "ballad" => CreateChatCompletionRequestVariant2AudioVoice.Ballad,
                "coral" => CreateChatCompletionRequestVariant2AudioVoice.Coral,
                "echo" => CreateChatCompletionRequestVariant2AudioVoice.Echo,
                "sage" => CreateChatCompletionRequestVariant2AudioVoice.Sage,
                "shimmer" => CreateChatCompletionRequestVariant2AudioVoice.Shimmer,
                "verse" => CreateChatCompletionRequestVariant2AudioVoice.Verse,
                _ => null,
            };
        }
    }
}