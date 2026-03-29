//HintName: G.Models.CartesiaTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CartesiaTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        InkWhisper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaTranscriberModel value)
        {
            return value switch
            {
                CartesiaTranscriberModel.InkWhisper => "ink-whisper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "ink-whisper" => CartesiaTranscriberModel.InkWhisper,
                _ => null,
            };
        }
    }
}