//HintName: G.Models.ClientMessageModelOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "model-output" is sent as the model outputs tokens.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageModelOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model-output")]
        ModelOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageModelOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageModelOutputType value)
        {
            return value switch
            {
                ClientMessageModelOutputType.ModelOutput => "model-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageModelOutputType? ToEnum(string value)
        {
            return value switch
            {
                "model-output" => ClientMessageModelOutputType.ModelOutput,
                _ => null,
            };
        }
    }
}