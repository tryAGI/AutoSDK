//HintName: G.Models.CopilotOrganizationDetailsSeatManagementSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The mode of assigning new seats.
    /// </summary>
    public enum CopilotOrganizationDetailsSeatManagementSetting
    {
        /// <summary>
        /// 
        /// </summary>
        AssignAll,
        /// <summary>
        /// 
        /// </summary>
        AssignSelected,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
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