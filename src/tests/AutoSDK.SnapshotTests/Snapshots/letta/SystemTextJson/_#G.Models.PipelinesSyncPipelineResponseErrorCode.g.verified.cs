//HintName: G.Models.PipelinesSyncPipelineResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesSyncPipelineResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        PipelineDisabled,
        /// <summary>
        /// 
        /// </summary>
        PipelineNotSyncable,
        /// <summary>
        /// 
        /// </summary>
        SyncFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesSyncPipelineResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesSyncPipelineResponseErrorCode value)
        {
            return value switch
            {
                PipelinesSyncPipelineResponseErrorCode.PipelineDisabled => "pipelineDisabled",
                PipelinesSyncPipelineResponseErrorCode.PipelineNotSyncable => "pipelineNotSyncable",
                PipelinesSyncPipelineResponseErrorCode.SyncFailed => "syncFailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesSyncPipelineResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "pipelineDisabled" => PipelinesSyncPipelineResponseErrorCode.PipelineDisabled,
                "pipelineNotSyncable" => PipelinesSyncPipelineResponseErrorCode.PipelineNotSyncable,
                "syncFailed" => PipelinesSyncPipelineResponseErrorCode.SyncFailed,
                _ => null,
            };
        }
    }
}