//HintName: G.Models.RealtimeSessionVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice the model uses to respond. Current voice options are `ash`, <br/>
    /// `ballad`, `coral`, `sage`, and `verse`. <br/>
    /// Also supported but not recommended are `alloy`, `echo`, and `shimmer`. <br/>
    /// These older voices are less expressive. <br/>
    /// Voice cannot be changed during the session once the model has <br/>
    /// responded with audio at least once.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionVoice
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
    public static class RealtimeSessionVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionVoice value)
        {
            return value switch
            {
                RealtimeSessionVoice.Alloy => "alloy",
                RealtimeSessionVoice.Ash => "ash",
                RealtimeSessionVoice.Ballad => "ballad",
                RealtimeSessionVoice.Coral => "coral",
                RealtimeSessionVoice.Echo => "echo",
                RealtimeSessionVoice.Sage => "sage",
                RealtimeSessionVoice.Shimmer => "shimmer",
                RealtimeSessionVoice.Verse => "verse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => RealtimeSessionVoice.Alloy,
                "ash" => RealtimeSessionVoice.Ash,
                "ballad" => RealtimeSessionVoice.Ballad,
                "coral" => RealtimeSessionVoice.Coral,
                "echo" => RealtimeSessionVoice.Echo,
                "sage" => RealtimeSessionVoice.Sage,
                "shimmer" => RealtimeSessionVoice.Shimmer,
                "verse" => RealtimeSessionVoice.Verse,
                _ => null,
            };
        }
    }
}