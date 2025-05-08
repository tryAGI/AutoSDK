//HintName: G.Models.TranscriptionInclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: []
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptionInclude
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logprobs")]
        Logprobs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionIncludeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionInclude value)
        {
            return value switch
            {
                TranscriptionInclude.Logprobs => "logprobs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionInclude? ToEnum(string value)
        {
            return value switch
            {
                "logprobs" => TranscriptionInclude.Logprobs,
                _ => null,
            };
        }
    }
}