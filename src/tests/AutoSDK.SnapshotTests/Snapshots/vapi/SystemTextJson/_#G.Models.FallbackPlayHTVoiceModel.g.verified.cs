//HintName: G.Models.FallbackPlayHTVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Playht voice model/engine to use.
    /// </summary>
    public enum FallbackPlayHTVoiceModel
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
    public static class FallbackPlayHTVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackPlayHTVoiceModel value)
        {
            return value switch
            {
                FallbackPlayHTVoiceModel.Play30Mini => "Play3.0-mini",
                FallbackPlayHTVoiceModel.PlayDialog => "PlayDialog",
                FallbackPlayHTVoiceModel.PlayHT20 => "PlayHT2.0",
                FallbackPlayHTVoiceModel.PlayHT20Turbo => "PlayHT2.0-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackPlayHTVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "Play3.0-mini" => FallbackPlayHTVoiceModel.Play30Mini,
                "PlayDialog" => FallbackPlayHTVoiceModel.PlayDialog,
                "PlayHT2.0" => FallbackPlayHTVoiceModel.PlayHT20,
                "PlayHT2.0-turbo" => FallbackPlayHTVoiceModel.PlayHT20Turbo,
                _ => null,
            };
        }
    }
}