//HintName: G.Models.PatchTriggerInstancesManageByTriggerIdRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchTriggerInstancesManageByTriggerIdRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disable")]
        Disable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enable")]
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTriggerInstancesManageByTriggerIdRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTriggerInstancesManageByTriggerIdRequestStatus value)
        {
            return value switch
            {
                PatchTriggerInstancesManageByTriggerIdRequestStatus.Disable => "disable",
                PatchTriggerInstancesManageByTriggerIdRequestStatus.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTriggerInstancesManageByTriggerIdRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "disable" => PatchTriggerInstancesManageByTriggerIdRequestStatus.Disable,
                "enable" => PatchTriggerInstancesManageByTriggerIdRequestStatus.Enable,
                _ => null,
            };
        }
    }
}