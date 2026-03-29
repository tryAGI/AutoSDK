//HintName: G.Models.GladiaTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GladiaTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        Accurate,
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Solaria1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GladiaTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GladiaTranscriberModel value)
        {
            return value switch
            {
                GladiaTranscriberModel.Accurate => "accurate",
                GladiaTranscriberModel.Fast => "fast",
                GladiaTranscriberModel.Solaria1 => "solaria-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GladiaTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "accurate" => GladiaTranscriberModel.Accurate,
                "fast" => GladiaTranscriberModel.Fast,
                "solaria-1" => GladiaTranscriberModel.Solaria1,
                _ => null,
            };
        }
    }
}