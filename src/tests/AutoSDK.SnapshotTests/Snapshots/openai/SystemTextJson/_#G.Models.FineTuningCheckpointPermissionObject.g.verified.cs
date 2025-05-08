//HintName: G.Models.FineTuningCheckpointPermissionObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "checkpoint.permission".
    /// </summary>
    public enum FineTuningCheckpointPermissionObject
    {
        /// <summary>
        /// 
        /// </summary>
        CheckpointPermission,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningCheckpointPermissionObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningCheckpointPermissionObject value)
        {
            return value switch
            {
                FineTuningCheckpointPermissionObject.CheckpointPermission => "checkpoint.permission",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningCheckpointPermissionObject? ToEnum(string value)
        {
            return value switch
            {
                "checkpoint.permission" => FineTuningCheckpointPermissionObject.CheckpointPermission,
                _ => null,
            };
        }
    }
}