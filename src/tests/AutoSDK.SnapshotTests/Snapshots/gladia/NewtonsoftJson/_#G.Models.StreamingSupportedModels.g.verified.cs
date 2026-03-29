//HintName: G.Models.StreamingSupportedModels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model used to process the audio. "solaria-1" is used by default.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamingSupportedModels
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="solaria-1")]
        Solaria1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingSupportedModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingSupportedModels value)
        {
            return value switch
            {
                StreamingSupportedModels.Solaria1 => "solaria-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingSupportedModels? ToEnum(string value)
        {
            return value switch
            {
                "solaria-1" => StreamingSupportedModels.Solaria1,
                _ => null,
            };
        }
    }
}