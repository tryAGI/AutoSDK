//HintName: G.Models.ListenMetadataPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListenMetadataPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="listen_metadata")]
        ListenMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenMetadataPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenMetadataPayloadMessageType value)
        {
            return value switch
            {
                ListenMetadataPayloadMessageType.ListenMetadata => "listen_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenMetadataPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "listen_metadata" => ListenMetadataPayloadMessageType.ListenMetadata,
                _ => null,
            };
        }
    }
}