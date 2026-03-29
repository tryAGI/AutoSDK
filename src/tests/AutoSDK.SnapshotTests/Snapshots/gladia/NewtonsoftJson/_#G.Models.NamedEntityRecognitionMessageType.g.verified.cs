//HintName: G.Models.NamedEntityRecognitionMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: named_entity_recognition<br/>
    /// Example: named_entity_recognition
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NamedEntityRecognitionMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="named_entity_recognition")]
        NamedEntityRecognition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NamedEntityRecognitionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamedEntityRecognitionMessageType value)
        {
            return value switch
            {
                NamedEntityRecognitionMessageType.NamedEntityRecognition => "named_entity_recognition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamedEntityRecognitionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "named_entity_recognition" => NamedEntityRecognitionMessageType.NamedEntityRecognition,
                _ => null,
            };
        }
    }
}