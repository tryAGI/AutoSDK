//HintName: G.Models.ResponseOutputMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the output message<br/>
    /// Default Value: assistant
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseOutputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputMessageRole value)
        {
            return value switch
            {
                ResponseOutputMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ResponseOutputMessageRole.Assistant,
                _ => null,
            };
        }
    }
}