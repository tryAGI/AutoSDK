//HintName: G.Models.FallbackGladiaTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackGladiaTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="accurate")]
        Accurate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="solaria-1")]
        Solaria1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackGladiaTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackGladiaTranscriberModel value)
        {
            return value switch
            {
                FallbackGladiaTranscriberModel.Accurate => "accurate",
                FallbackGladiaTranscriberModel.Fast => "fast",
                FallbackGladiaTranscriberModel.Solaria1 => "solaria-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackGladiaTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "accurate" => FallbackGladiaTranscriberModel.Accurate,
                "fast" => FallbackGladiaTranscriberModel.Fast,
                "solaria-1" => FallbackGladiaTranscriberModel.Solaria1,
                _ => null,
            };
        }
    }
}