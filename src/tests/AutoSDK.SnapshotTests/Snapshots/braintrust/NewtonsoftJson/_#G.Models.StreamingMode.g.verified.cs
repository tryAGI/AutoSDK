//HintName: G.Models.StreamingMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The mode format of the returned value (defaults to 'auto')
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamingMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parallel")]
        Parallel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingMode value)
        {
            return value switch
            {
                StreamingMode.Auto => "auto",
                StreamingMode.Json => "json",
                StreamingMode.Parallel => "parallel",
                StreamingMode.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => StreamingMode.Auto,
                "json" => StreamingMode.Json,
                "parallel" => StreamingMode.Parallel,
                "text" => StreamingMode.Text,
                _ => null,
            };
        }
    }
}