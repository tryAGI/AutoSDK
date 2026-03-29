//HintName: G.Models.PipelinesCreatePipelineRequestProducerConfigVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesCreatePipelineRequestProducerConfigVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        SlackChannelReader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesCreatePipelineRequestProducerConfigVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesCreatePipelineRequestProducerConfigVariant1Type value)
        {
            return value switch
            {
                PipelinesCreatePipelineRequestProducerConfigVariant1Type.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesCreatePipelineRequestProducerConfigVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "slack_channel_reader" => PipelinesCreatePipelineRequestProducerConfigVariant1Type.SlackChannelReader,
                _ => null,
            };
        }
    }
}