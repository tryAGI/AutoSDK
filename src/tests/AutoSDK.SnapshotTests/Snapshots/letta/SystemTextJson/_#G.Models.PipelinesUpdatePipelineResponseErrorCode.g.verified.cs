//HintName: G.Models.PipelinesUpdatePipelineResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesUpdatePipelineResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        PipelineNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesUpdatePipelineResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineResponseErrorCode value)
        {
            return value switch
            {
                PipelinesUpdatePipelineResponseErrorCode.PipelineNotFound => "pipelineNotFound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "pipelineNotFound" => PipelinesUpdatePipelineResponseErrorCode.PipelineNotFound,
                _ => null,
            };
        }
    }
}