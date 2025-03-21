//HintName: G.Models.RealtimeResponseCreateParamsVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice the model uses to respond. Voice cannot be changed during the <br/>
    /// session once the model has responded with audio at least once. Current <br/>
    /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
    /// `shimmer` and `verse`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeResponseCreateParamsVoice
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
    public static class RealtimeResponseCreateParamsVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateParamsVoice value)
        {
            return value switch
            {
                RealtimeResponseCreateParamsVoice.Alloy => "alloy",
                RealtimeResponseCreateParamsVoice.Ash => "ash",
                RealtimeResponseCreateParamsVoice.Ballad => "ballad",
                RealtimeResponseCreateParamsVoice.Coral => "coral",
                RealtimeResponseCreateParamsVoice.Echo => "echo",
                RealtimeResponseCreateParamsVoice.Sage => "sage",
                RealtimeResponseCreateParamsVoice.Shimmer => "shimmer",
                RealtimeResponseCreateParamsVoice.Verse => "verse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateParamsVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => RealtimeResponseCreateParamsVoice.Alloy,
                "ash" => RealtimeResponseCreateParamsVoice.Ash,
                "ballad" => RealtimeResponseCreateParamsVoice.Ballad,
                "coral" => RealtimeResponseCreateParamsVoice.Coral,
                "echo" => RealtimeResponseCreateParamsVoice.Echo,
                "sage" => RealtimeResponseCreateParamsVoice.Sage,
                "shimmer" => RealtimeResponseCreateParamsVoice.Shimmer,
                "verse" => RealtimeResponseCreateParamsVoice.Verse,
                _ => null,
            };
        }
    }
}