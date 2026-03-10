//HintName: G.Models.GuardrailExecutionMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GuardrailExecutionMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="streaming")]
        Streaming,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blocking")]
        Blocking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailExecutionMode value)
        {
            return value switch
            {
                GuardrailExecutionMode.Streaming => "streaming",
                GuardrailExecutionMode.Blocking => "blocking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "streaming" => GuardrailExecutionMode.Streaming,
                "blocking" => GuardrailExecutionMode.Blocking,
                _ => null,
            };
        }
    }
}