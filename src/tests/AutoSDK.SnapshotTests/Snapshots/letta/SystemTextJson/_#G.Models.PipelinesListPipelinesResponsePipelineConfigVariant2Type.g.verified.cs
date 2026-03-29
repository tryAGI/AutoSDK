//HintName: G.Models.PipelinesListPipelinesResponsePipelineConfigVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesListPipelinesResponsePipelineConfigVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        CustomWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesListPipelinesResponsePipelineConfigVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesListPipelinesResponsePipelineConfigVariant2Type value)
        {
            return value switch
            {
                PipelinesListPipelinesResponsePipelineConfigVariant2Type.CustomWebhook => "custom_webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesListPipelinesResponsePipelineConfigVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesListPipelinesResponsePipelineConfigVariant2Type.CustomWebhook,
                _ => null,
            };
        }
    }
}