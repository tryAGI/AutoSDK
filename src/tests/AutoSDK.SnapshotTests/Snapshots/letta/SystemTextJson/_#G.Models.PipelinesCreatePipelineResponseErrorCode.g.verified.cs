//HintName: G.Models.PipelinesCreatePipelineResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesCreatePipelineResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        AgentNotFound,
        /// <summary>
        /// 
        /// </summary>
        IntegrationNotFound,
        /// <summary>
        /// 
        /// </summary>
        InvalidProducerConfig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesCreatePipelineResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesCreatePipelineResponseErrorCode value)
        {
            return value switch
            {
                PipelinesCreatePipelineResponseErrorCode.AgentNotFound => "agentNotFound",
                PipelinesCreatePipelineResponseErrorCode.IntegrationNotFound => "integrationNotFound",
                PipelinesCreatePipelineResponseErrorCode.InvalidProducerConfig => "invalidProducerConfig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesCreatePipelineResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "agentNotFound" => PipelinesCreatePipelineResponseErrorCode.AgentNotFound,
                "integrationNotFound" => PipelinesCreatePipelineResponseErrorCode.IntegrationNotFound,
                "invalidProducerConfig" => PipelinesCreatePipelineResponseErrorCode.InvalidProducerConfig,
                _ => null,
            };
        }
    }
}