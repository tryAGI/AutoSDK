//HintName: G.Models.RealtimeSessionCreateRequestVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice the model uses to respond. Voice cannot be changed during the <br/>
    /// session once the model has responded with audio at least once. Current <br/>
    /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
    /// `shimmer` and `verse`.
    /// </summary>
    public enum RealtimeSessionCreateRequestVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        Ash,
        /// <summary>
        /// 
        /// </summary>
        Ballad,
        /// <summary>
        /// 
        /// </summary>
        Coral,
        /// <summary>
        /// 
        /// </summary>
        Echo,
        /// <summary>
        /// 
        /// </summary>
        Sage,
        /// <summary>
        /// 
        /// </summary>
        Shimmer,
        /// <summary>
        /// 
        /// </summary>
        Verse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestVoice value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestVoice.Alloy => "alloy",
                RealtimeSessionCreateRequestVoice.Ash => "ash",
                RealtimeSessionCreateRequestVoice.Ballad => "ballad",
                RealtimeSessionCreateRequestVoice.Coral => "coral",
                RealtimeSessionCreateRequestVoice.Echo => "echo",
                RealtimeSessionCreateRequestVoice.Sage => "sage",
                RealtimeSessionCreateRequestVoice.Shimmer => "shimmer",
                RealtimeSessionCreateRequestVoice.Verse => "verse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => RealtimeSessionCreateRequestVoice.Alloy,
                "ash" => RealtimeSessionCreateRequestVoice.Ash,
                "ballad" => RealtimeSessionCreateRequestVoice.Ballad,
                "coral" => RealtimeSessionCreateRequestVoice.Coral,
                "echo" => RealtimeSessionCreateRequestVoice.Echo,
                "sage" => RealtimeSessionCreateRequestVoice.Sage,
                "shimmer" => RealtimeSessionCreateRequestVoice.Shimmer,
                "verse" => RealtimeSessionCreateRequestVoice.Verse,
                _ => null,
            };
        }
    }
}