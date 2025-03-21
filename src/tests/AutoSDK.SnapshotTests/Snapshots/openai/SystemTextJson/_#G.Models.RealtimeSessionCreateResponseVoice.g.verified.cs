//HintName: G.Models.RealtimeSessionCreateResponseVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice the model uses to respond. Voice cannot be changed during the <br/>
    /// session once the model has responded with audio at least once. Current <br/>
    /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
    /// `shimmer` and `verse`.
    /// </summary>
    public enum RealtimeSessionCreateResponseVoice
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
    public static class RealtimeSessionCreateResponseVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseVoice value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseVoice.Alloy => "alloy",
                RealtimeSessionCreateResponseVoice.Ash => "ash",
                RealtimeSessionCreateResponseVoice.Ballad => "ballad",
                RealtimeSessionCreateResponseVoice.Coral => "coral",
                RealtimeSessionCreateResponseVoice.Echo => "echo",
                RealtimeSessionCreateResponseVoice.Sage => "sage",
                RealtimeSessionCreateResponseVoice.Shimmer => "shimmer",
                RealtimeSessionCreateResponseVoice.Verse => "verse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => RealtimeSessionCreateResponseVoice.Alloy,
                "ash" => RealtimeSessionCreateResponseVoice.Ash,
                "ballad" => RealtimeSessionCreateResponseVoice.Ballad,
                "coral" => RealtimeSessionCreateResponseVoice.Coral,
                "echo" => RealtimeSessionCreateResponseVoice.Echo,
                "sage" => RealtimeSessionCreateResponseVoice.Sage,
                "shimmer" => RealtimeSessionCreateResponseVoice.Shimmer,
                "verse" => RealtimeSessionCreateResponseVoice.Verse,
                _ => null,
            };
        }
    }
}