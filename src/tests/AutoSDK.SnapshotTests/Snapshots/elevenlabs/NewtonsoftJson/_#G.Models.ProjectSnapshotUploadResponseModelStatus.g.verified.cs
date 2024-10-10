//HintName: G.Models.ProjectSnapshotUploadResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectSnapshotUploadResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_queue")]
        InQueue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSnapshotUploadResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSnapshotUploadResponseModelStatus value)
        {
            return value switch
            {
                ProjectSnapshotUploadResponseModelStatus.Success => "success",
                ProjectSnapshotUploadResponseModelStatus.InQueue => "in_queue",
                ProjectSnapshotUploadResponseModelStatus.Pending => "pending",
                ProjectSnapshotUploadResponseModelStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSnapshotUploadResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => ProjectSnapshotUploadResponseModelStatus.Success,
                "in_queue" => ProjectSnapshotUploadResponseModelStatus.InQueue,
                "pending" => ProjectSnapshotUploadResponseModelStatus.Pending,
                "failed" => ProjectSnapshotUploadResponseModelStatus.Failed,
                _ => null,
            };
        }
    }
}