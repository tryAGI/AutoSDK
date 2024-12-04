//HintName: G.Models.CreateChatCompletionRequestAudioVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice the model uses to respond. Supported voices are `ash`, `ballad`, `coral`, `sage`, and `verse` (also supported but not recommended are `alloy`, `echo`, and `shimmer`; these voices are less expressive).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestAudioVoice
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
    public static class CreateChatCompletionRequestAudioVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestAudioVoice value)
        {
            return value switch
            {
                CreateChatCompletionRequestAudioVoice.Alloy => "alloy",
                CreateChatCompletionRequestAudioVoice.Ash => "ash",
                CreateChatCompletionRequestAudioVoice.Ballad => "ballad",
                CreateChatCompletionRequestAudioVoice.Coral => "coral",
                CreateChatCompletionRequestAudioVoice.Echo => "echo",
                CreateChatCompletionRequestAudioVoice.Sage => "sage",
                CreateChatCompletionRequestAudioVoice.Shimmer => "shimmer",
                CreateChatCompletionRequestAudioVoice.Verse => "verse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestAudioVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => CreateChatCompletionRequestAudioVoice.Alloy,
                "ash" => CreateChatCompletionRequestAudioVoice.Ash,
                "ballad" => CreateChatCompletionRequestAudioVoice.Ballad,
                "coral" => CreateChatCompletionRequestAudioVoice.Coral,
                "echo" => CreateChatCompletionRequestAudioVoice.Echo,
                "sage" => CreateChatCompletionRequestAudioVoice.Sage,
                "shimmer" => CreateChatCompletionRequestAudioVoice.Shimmer,
                "verse" => CreateChatCompletionRequestAudioVoice.Verse,
                _ => null,
            };
        }
    }
}