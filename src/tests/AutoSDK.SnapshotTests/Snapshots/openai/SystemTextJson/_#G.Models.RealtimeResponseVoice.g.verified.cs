//HintName: G.Models.RealtimeResponseVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voice the model used to respond.<br/>
    /// Current voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
    /// `shimmer` and `verse`.
    /// </summary>
    public enum RealtimeResponseVoice
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
    public static class RealtimeResponseVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseVoice value)
        {
            return value switch
            {
                RealtimeResponseVoice.Alloy => "alloy",
                RealtimeResponseVoice.Ash => "ash",
                RealtimeResponseVoice.Ballad => "ballad",
                RealtimeResponseVoice.Coral => "coral",
                RealtimeResponseVoice.Echo => "echo",
                RealtimeResponseVoice.Sage => "sage",
                RealtimeResponseVoice.Shimmer => "shimmer",
                RealtimeResponseVoice.Verse => "verse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => RealtimeResponseVoice.Alloy,
                "ash" => RealtimeResponseVoice.Ash,
                "ballad" => RealtimeResponseVoice.Ballad,
                "coral" => RealtimeResponseVoice.Coral,
                "echo" => RealtimeResponseVoice.Echo,
                "sage" => RealtimeResponseVoice.Sage,
                "shimmer" => RealtimeResponseVoice.Shimmer,
                "verse" => RealtimeResponseVoice.Verse,
                _ => null,
            };
        }
    }
}