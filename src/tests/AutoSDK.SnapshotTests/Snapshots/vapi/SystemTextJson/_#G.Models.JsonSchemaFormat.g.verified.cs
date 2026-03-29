//HintName: G.Models.JsonSchemaFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the format of the string. To pass a regex, use the `pattern` property instead.<br/>
    /// OpenAI documentation: https://platform.openai.com/docs/guides/structured-outputs?api-mode=chat&amp;type-restrictions=string-restrictions
    /// </summary>
    public enum JsonSchemaFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        DateTime,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Hostname,
        /// <summary>
        /// 
        /// </summary>
        Ipv4,
        /// <summary>
        /// 
        /// </summary>
        Ipv6,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
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