//HintName: G.Models.PropertiesConfigPropertiesTurnDetectionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 语音检测类型，支持 server_vad / client_vad / client_interrupt，默认 server_vad
    /// </summary>
    public enum PropertiesConfigPropertiesTurnDetectionType
    {
        /// <summary>
        /// 
        /// </summary>
        ClientInterrupt,
        /// <summary>
        /// 
        /// </summary>
        ClientVad,
        /// <summary>
        /// 
        /// </summary>
        SemanticVad,
        /// <summary>
        /// 
        /// </summary>
        ServerVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesConfigPropertiesTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesConfigPropertiesTurnDetectionType value)
        {
            return value switch
            {
                PropertiesConfigPropertiesTurnDetectionType.ClientInterrupt => "client_interrupt",
                PropertiesConfigPropertiesTurnDetectionType.ClientVad => "client_vad",
                PropertiesConfigPropertiesTurnDetectionType.SemanticVad => "semantic_vad",
                PropertiesConfigPropertiesTurnDetectionType.ServerVad => "server_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesConfigPropertiesTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "client_interrupt" => PropertiesConfigPropertiesTurnDetectionType.ClientInterrupt,
                "client_vad" => PropertiesConfigPropertiesTurnDetectionType.ClientVad,
                "semantic_vad" => PropertiesConfigPropertiesTurnDetectionType.SemanticVad,
                "server_vad" => PropertiesConfigPropertiesTurnDetectionType.ServerVad,
                _ => null,
            };
        }
    }
}