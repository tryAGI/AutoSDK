//HintName: G.Models.JsonSchemaFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the format of the string. To pass a regex, use the `pattern` property instead.<br/>
    /// OpenAI documentation: https://platform.openai.com/docs/guides/structured-outputs?api-mode=chat&amp;type-restrictions=string-restrictions
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JsonSchemaFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date")]
        Date,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date-time")]
        DateTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="duration")]
        Duration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="email")]
        Email,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hostname")]
        Hostname,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ipv4")]
        Ipv4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ipv6")]
        Ipv6,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="time")]
        Time,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uuid")]
        Uuid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JsonSchemaFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonSchemaFormat value)
        {
            return value switch
            {
                JsonSchemaFormat.Date => "date",
                JsonSchemaFormat.DateTime => "date-time",
                JsonSchemaFormat.Duration => "duration",
                JsonSchemaFormat.Email => "email",
                JsonSchemaFormat.Hostname => "hostname",
                JsonSchemaFormat.Ipv4 => "ipv4",
                JsonSchemaFormat.Ipv6 => "ipv6",
                JsonSchemaFormat.Time => "time",
                JsonSchemaFormat.Uuid => "uuid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonSchemaFormat? ToEnum(string value)
        {
            return value switch
            {
                "date" => JsonSchemaFormat.Date,
                "date-time" => JsonSchemaFormat.DateTime,
                "duration" => JsonSchemaFormat.Duration,
                "email" => JsonSchemaFormat.Email,
                "hostname" => JsonSchemaFormat.Hostname,
                "ipv4" => JsonSchemaFormat.Ipv4,
                "ipv6" => JsonSchemaFormat.Ipv6,
                "time" => JsonSchemaFormat.Time,
                "uuid" => JsonSchemaFormat.Uuid,
                _ => null,
            };
        }
    }
}