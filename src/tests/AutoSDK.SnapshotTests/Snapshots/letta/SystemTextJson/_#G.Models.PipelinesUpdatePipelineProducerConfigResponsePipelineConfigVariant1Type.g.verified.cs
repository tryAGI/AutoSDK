//HintName: G.Models.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        SlackChannelReader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type value)
        {
            return value switch
            {
                PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "slack_channel_reader" => PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type.SlackChannelReader,
                _ => null,
            };
        }
    }
}