//HintName: G.Models.PatchOrganizationMembersOutputStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchOrganizationMembersOutputStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrganizationMembersOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationMembersOutputStatus value)
        {
            return value switch
            {
                PatchOrganizationMembersOutputStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationMembersOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => PatchOrganizationMembersOutputStatus.Success,
                _ => null,
            };
        }
    }
}