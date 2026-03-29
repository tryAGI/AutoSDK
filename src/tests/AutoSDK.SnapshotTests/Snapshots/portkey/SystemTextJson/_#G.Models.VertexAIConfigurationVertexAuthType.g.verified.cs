//HintName: G.Models.VertexAIConfigurationVertexAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vertex AI authentication type
    /// </summary>
    public enum VertexAIConfigurationVertexAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
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