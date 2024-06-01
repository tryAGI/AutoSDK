//HintName: G.Models.CopilotOrganizationDetailsSeatManagementSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The mode of assigning new seats.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CopilotOrganizationDetailsSeatManagementSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assign_all")]
        AssignAll,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assign_selected")]
        AssignSelected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unconfigured")]
        Unconfigured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotOrganizationDetailsSeatManagementSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotOrganizationDetailsSeatManagementSetting value)
        {
            return value switch
            {
                CopilotOrganizationDetailsSeatManagementSetting.AssignAll => "assign_all",
                CopilotOrganizationDetailsSeatManagementSetting.AssignSelected => "assign_selected",
                CopilotOrganizationDetailsSeatManagementSetting.Disabled => "disabled",
                CopilotOrganizationDetailsSeatManagementSetting.Unconfigured => "unconfigured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotOrganizationDetailsSeatManagementSetting ToEnum(string value)
        {
            return value switch
            {
                "assign_all" => CopilotOrganizationDetailsSeatManagementSetting.AssignAll,
                "assign_selected" => CopilotOrganizationDetailsSeatManagementSetting.AssignSelected,
                "disabled" => CopilotOrganizationDetailsSeatManagementSetting.Disabled,
                "unconfigured" => CopilotOrganizationDetailsSeatManagementSetting.Unconfigured,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}