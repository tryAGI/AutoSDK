//HintName: G.Models.TranscriptionConfigDiarization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify whether speaker or channel labels are added to the transcript.<br/>
    /// The default is `none`.<br/>
    ///   - **none**: no speaker or channel labels are added.<br/>
    ///   - **speaker**: speaker attribution is performed based on acoustic matching;<br/>
    ///              all input channels are mixed into a single stream for processing.<br/>
    ///   - **channel**: multiple input channels are processed individually and collated<br/>
    ///             into a single transcript.
    /// </summary>
    public enum TranscriptionConfigDiarization
    {
        /// <summary>
        /// no speaker or channel labels are added.
        /// </summary>
        Channel,
        /// <summary>
        /// no speaker or channel labels are added.
        /// </summary>
        None,
        /// <summary>
        /// no speaker or channel labels are added.
        /// </summary>
        Speaker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionConfigDiarizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionConfigDiarization value)
        {
            return value switch
            {
                TranscriptionConfigDiarization.Channel => "channel",
                TranscriptionConfigDiarization.None => "none",
                TranscriptionConfigDiarization.Speaker => "speaker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionConfigDiarization? ToEnum(string value)
        {
            return value switch
            {
                "channel" => TranscriptionConfigDiarization.Channel,
                "none" => TranscriptionConfigDiarization.None,
                "speaker" => TranscriptionConfigDiarization.Speaker,
                _ => null,
            };
        }
    }
}