//HintName: G.Models.FallbackCartesiaTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackCartesiaTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ink-whisper")]
        InkWhisper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackCartesiaTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackCartesiaTranscriberModel value)
        {
            return value switch
            {
                FallbackCartesiaTranscriberModel.InkWhisper => "ink-whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackCartesiaTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "ink-whisper" => FallbackCartesiaTranscriberModel.InkWhisper,
                _ => null,
            };
        }
    }
}