//HintName: G.Models.ClientMessageMetadataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "metadata" is sent to forward metadata to the client.
    /// </summary>
    public enum ClientMessageMetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageMetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageMetadataType value)
        {
            return value switch
            {
                ClientMessageMetadataType.Metadata => "metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageMetadataType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => ClientMessageMetadataType.Metadata,
                _ => null,
            };
        }
    }
}