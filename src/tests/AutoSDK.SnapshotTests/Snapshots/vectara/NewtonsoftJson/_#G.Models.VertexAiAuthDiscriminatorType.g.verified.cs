//HintName: G.Models.VertexAiAuthDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VertexAiAuthDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key")]
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service_account")]
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VertexAiAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VertexAiAuthDiscriminatorType value)
        {
            return value switch
            {
                VertexAiAuthDiscriminatorType.ApiKey => "api_key",
                VertexAiAuthDiscriminatorType.ServiceAccount => "service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VertexAiAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => VertexAiAuthDiscriminatorType.ApiKey,
                "service_account" => VertexAiAuthDiscriminatorType.ServiceAccount,
                _ => null,
            };
        }
    }
}