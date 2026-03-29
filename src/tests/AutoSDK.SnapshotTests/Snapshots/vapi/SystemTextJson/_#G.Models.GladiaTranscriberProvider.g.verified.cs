//HintName: G.Models.GladiaTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    public enum GladiaTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Gladia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GladiaTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GladiaTranscriberProvider value)
        {
            return value switch
            {
                GladiaTranscriberProvider.Gladia => "gladia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GladiaTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "gladia" => GladiaTranscriberProvider.Gladia,
                _ => null,
            };
        }
    }
}