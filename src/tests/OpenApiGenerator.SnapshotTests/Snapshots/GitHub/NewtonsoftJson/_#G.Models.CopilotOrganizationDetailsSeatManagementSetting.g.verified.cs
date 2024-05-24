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
}