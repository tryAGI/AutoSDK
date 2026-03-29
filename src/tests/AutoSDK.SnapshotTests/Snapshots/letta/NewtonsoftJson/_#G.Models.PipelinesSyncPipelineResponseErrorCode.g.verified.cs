//HintName: G.Models.PipelinesSyncPipelineResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesSyncPipelineResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipelineDisabled")]
        PipelineDisabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipelineNotSyncable")]
        PipelineNotSyncable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="syncFailed")]
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