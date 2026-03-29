//HintName: G.Models.TranscriptionJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of speech recognition performed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptionJobType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="async")]
        Async,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionJobType value)
        {
            return value switch
            {
                TranscriptionJobType.Async => "async",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionJobType? ToEnum(string value)
        {
            return value switch
            {
                "async" => TranscriptionJobType.Async,
                _ => null,
            };
        }
    }
}