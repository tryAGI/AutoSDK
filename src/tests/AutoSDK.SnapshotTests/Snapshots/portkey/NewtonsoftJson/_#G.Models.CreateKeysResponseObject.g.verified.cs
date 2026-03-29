//HintName: G.Models.CreateKeysResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: api-key
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateKeysResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api-key")]
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKeysResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKeysResponseObject value)
        {
            return value switch
            {
                CreateKeysResponseObject.ApiKey => "api-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKeysResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => CreateKeysResponseObject.ApiKey,
                _ => null,
            };
        }
    }
}