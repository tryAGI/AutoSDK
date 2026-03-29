//HintName: G.Models.FallbackGladiaTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackGladiaTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gladia")]
        Gladia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackGladiaTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackGladiaTranscriberProvider value)
        {
            return value switch
            {
                FallbackGladiaTranscriberProvider.Gladia => "gladia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackGladiaTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "gladia" => FallbackGladiaTranscriberProvider.Gladia,
                _ => null,
            };
        }
    }
}