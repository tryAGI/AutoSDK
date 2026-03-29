//HintName: G.Models.PipelinesUpdatePipelineProducerConfigResponseErrorCode2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesUpdatePipelineProducerConfigResponseErrorCode2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipelineNotFound")]
        PipelineNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesUpdatePipelineProducerConfigResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineProducerConfigResponseErrorCode2 value)
        {
            return value switch
            {
                PipelinesUpdatePipelineProducerConfigResponseErrorCode2.PipelineNotFound => "pipelineNotFound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineProducerConfigResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "pipelineNotFound" => PipelinesUpdatePipelineProducerConfigResponseErrorCode2.PipelineNotFound,
                _ => null,
            };
        }
    }
}