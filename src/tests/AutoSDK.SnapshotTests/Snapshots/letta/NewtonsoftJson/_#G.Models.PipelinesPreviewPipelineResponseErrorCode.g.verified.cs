//HintName: G.Models.PipelinesPreviewPipelineResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesPreviewPipelineResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="integrationNotFound")]
        IntegrationNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalidProducerConfig")]
        InvalidProducerConfig,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tokenExpired")]
        TokenExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesPreviewPipelineResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesPreviewPipelineResponseErrorCode value)
        {
            return value switch
            {
                PipelinesPreviewPipelineResponseErrorCode.IntegrationNotFound => "integrationNotFound",
                PipelinesPreviewPipelineResponseErrorCode.InvalidProducerConfig => "invalidProducerConfig",
                PipelinesPreviewPipelineResponseErrorCode.TokenExpired => "tokenExpired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesPreviewPipelineResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "integrationNotFound" => PipelinesPreviewPipelineResponseErrorCode.IntegrationNotFound,
                "invalidProducerConfig" => PipelinesPreviewPipelineResponseErrorCode.InvalidProducerConfig,
                "tokenExpired" => PipelinesPreviewPipelineResponseErrorCode.TokenExpired,
                _ => null,
            };
        }
    }
}