//HintName: G.Models.PlayHTVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Playht voice model/engine to use.
    /// </summary>
    public enum PlayHTVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Play30Mini,
        /// <summary>
        /// 
        /// </summary>
        PlayDialog,
        /// <summary>
        /// 
        /// </summary>
        PlayHT20,
        /// <summary>
        /// 
        /// </summary>
        PlayHT20Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayHTVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayHTVoiceModel value)
        {
            return value switch
            {
                PlayHTVoiceModel.Play30Mini => "Play3.0-mini",
                PlayHTVoiceModel.PlayDialog => "PlayDialog",
                PlayHTVoiceModel.PlayHT20 => "PlayHT2.0",
                PlayHTVoiceModel.PlayHT20Turbo => "PlayHT2.0-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayHTVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "Play3.0-mini" => PlayHTVoiceModel.Play30Mini,
                "PlayDialog" => PlayHTVoiceModel.PlayDialog,
                "PlayHT2.0" => PlayHTVoiceModel.PlayHT20,
                "PlayHT2.0-turbo" => PlayHTVoiceModel.PlayHT20Turbo,
                _ => null,
            };
        }
    }
}