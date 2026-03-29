//HintName: G.Models.PatchTriggerInstancesManageByTriggerIdResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the operation
    /// </summary>
    public enum PatchTriggerInstancesManageByTriggerIdResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTriggerInstancesManageByTriggerIdResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTriggerInstancesManageByTriggerIdResponseStatus value)
        {
            return value switch
            {
                PatchTriggerInstancesManageByTriggerIdResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTriggerInstancesManageByTriggerIdResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => PatchTriggerInstancesManageByTriggerIdResponseStatus.Success,
                _ => null,
            };
        }
    }
}