//HintName: G.Models.TranscriptionFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output format of the transcription file. The following formats are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`srt` - SRT captions format&lt;/li&gt;<br/>
    ///   &lt;li&gt;`vtt` - VTT captions format&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: vtt
    /// </summary>
    public enum TranscriptionFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionFormat value)
        {
            return value switch
            {
                TranscriptionFormat.Srt => "srt",
                TranscriptionFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionFormat? ToEnum(string value)
        {
            return value switch
            {
                "srt" => TranscriptionFormat.Srt,
                "vtt" => TranscriptionFormat.Vtt,
                _ => null,
            };
        }
    }
}