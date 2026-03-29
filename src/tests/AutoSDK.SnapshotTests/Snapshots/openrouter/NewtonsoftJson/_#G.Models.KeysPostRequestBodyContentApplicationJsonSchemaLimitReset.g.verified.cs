//HintName: G.Models.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KeysPostRequestBodyContentApplicationJsonSchemaLimitReset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="daily")]
        Daily,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monthly")]
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="weekly")]
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeysPostRequestBodyContentApplicationJsonSchemaLimitResetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeysPostRequestBodyContentApplicationJsonSchemaLimitReset value)
        {
            return value switch
            {
                KeysPostRequestBodyContentApplicationJsonSchemaLimitReset.Daily => "daily",
                KeysPostRequestBodyContentApplicationJsonSchemaLimitReset.Monthly => "monthly",
                KeysPostRequestBodyContentApplicationJsonSchemaLimitReset.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeysPostRequestBodyContentApplicationJsonSchemaLimitReset? ToEnum(string value)
        {
            return value switch
            {
                "daily" => KeysPostRequestBodyContentApplicationJsonSchemaLimitReset.Daily,
                "monthly" => KeysPostRequestBodyContentApplicationJsonSchemaLimitReset.Monthly,
                "weekly" => KeysPostRequestBodyContentApplicationJsonSchemaLimitReset.Weekly,
                _ => null,
            };
        }
    }
}