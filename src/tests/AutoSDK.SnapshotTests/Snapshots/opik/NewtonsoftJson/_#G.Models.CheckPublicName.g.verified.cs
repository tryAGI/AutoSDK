//HintName: G.Models.CheckPublicName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheckPublicName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PII")]
        Pii,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOPIC")]
        Topic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckPublicNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckPublicName value)
        {
            return value switch
            {
                CheckPublicName.Pii => "PII",
                CheckPublicName.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckPublicName? ToEnum(string value)
        {
            return value switch
            {
                "PII" => CheckPublicName.Pii,
                "TOPIC" => CheckPublicName.Topic,
                _ => null,
            };
        }
    }
}