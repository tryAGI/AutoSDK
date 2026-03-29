//HintName: G.Models.VertexAIConfigurationVertexAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vertex AI authentication type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VertexAIConfigurationVertexAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="serviceAccount")]
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VertexAIConfigurationVertexAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VertexAIConfigurationVertexAuthType value)
        {
            return value switch
            {
                VertexAIConfigurationVertexAuthType.Basic => "basic",
                VertexAIConfigurationVertexAuthType.ServiceAccount => "serviceAccount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VertexAIConfigurationVertexAuthType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => VertexAIConfigurationVertexAuthType.Basic,
                "serviceAccount" => VertexAIConfigurationVertexAuthType.ServiceAccount,
                _ => null,
            };
        }
    }
}