//HintName: G.Models.DeepSeekModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeepSeekModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deep-seek")]
        DeepSeek,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepSeekModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepSeekModelProvider value)
        {
            return value switch
            {
                DeepSeekModelProvider.DeepSeek => "deep-seek",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepSeekModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "deep-seek" => DeepSeekModelProvider.DeepSeek,
                _ => null,
            };
        }
    }
}