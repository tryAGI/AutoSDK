//HintName: G.Models.PipelinesUpdatePipelineProducerConfigResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesUpdatePipelineProducerConfigResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ConfigTypeMismatch,
        /// <summary>
        /// 
        /// </summary>
        InvalidProducerConfig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesUpdatePipelineProducerConfigResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineProducerConfigResponseErrorCode value)
        {
            return value switch
            {
                PipelinesUpdatePipelineProducerConfigResponseErrorCode.ConfigTypeMismatch => "configTypeMismatch",
                PipelinesUpdatePipelineProducerConfigResponseErrorCode.InvalidProducerConfig => "invalidProducerConfig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineProducerConfigResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "configTypeMismatch" => PipelinesUpdatePipelineProducerConfigResponseErrorCode.ConfigTypeMismatch,
                "invalidProducerConfig" => PipelinesUpdatePipelineProducerConfigResponseErrorCode.InvalidProducerConfig,
                _ => null,
            };
        }
    }
}