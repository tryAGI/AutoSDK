//HintName: G.Models.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
    /// </summary>
    public enum KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset value)
        {
            return value switch
            {
                KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset.Daily => "daily",
                KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset.Monthly => "monthly",
                KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset? ToEnum(string value)
        {
            return value switch
            {
                "daily" => KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset.Daily,
                "monthly" => KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset.Monthly,
                "weekly" => KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset.Weekly,
                _ => null,
            };
        }
    }
}