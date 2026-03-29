//HintName: G.Models.FallbackSonioxTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackSonioxTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="soniox")]
        Soniox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSonioxTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSonioxTranscriberProvider value)
        {
            return value switch
            {
                FallbackSonioxTranscriberProvider.Soniox => "soniox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSonioxTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "soniox" => FallbackSonioxTranscriberProvider.Soniox,
                _ => null,
            };
        }
    }
}