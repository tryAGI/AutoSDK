//HintName: G.Models.PipelinesCreatePipelineResponsePipelineConfigVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesCreatePipelineResponsePipelineConfigVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom_webhook")]
        CustomWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesCreatePipelineResponsePipelineConfigVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesCreatePipelineResponsePipelineConfigVariant2Type value)
        {
            return value switch
            {
                PipelinesCreatePipelineResponsePipelineConfigVariant2Type.CustomWebhook => "custom_webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesCreatePipelineResponsePipelineConfigVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesCreatePipelineResponsePipelineConfigVariant2Type.CustomWebhook,
                _ => null,
            };
        }
    }
}