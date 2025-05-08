//HintName: G.Models.DeleteFineTuningCheckpointPermissionResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "checkpoint.permission".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteFineTuningCheckpointPermissionResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="checkpoint.permission")]
        CheckpointPermission,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteFineTuningCheckpointPermissionResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteFineTuningCheckpointPermissionResponseObject value)
        {
            return value switch
            {
                DeleteFineTuningCheckpointPermissionResponseObject.CheckpointPermission => "checkpoint.permission",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteFineTuningCheckpointPermissionResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "checkpoint.permission" => DeleteFineTuningCheckpointPermissionResponseObject.CheckpointPermission,
                _ => null,
            };
        }
    }
}