//HintName: G.Models.OrgCustomPropertyValuesEditableBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Who can edit the values of the property<br/>
    /// Example: org_actors
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgCustomPropertyValuesEditableBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_actors")]
        OrgActors,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_and_repo_actors")]
        OrgAndRepoActors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgCustomPropertyValuesEditableByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgCustomPropertyValuesEditableBy value)
        {
            return value switch
            {
                OrgCustomPropertyValuesEditableBy.OrgActors => "org_actors",
                OrgCustomPropertyValuesEditableBy.OrgAndRepoActors => "org_and_repo_actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgCustomPropertyValuesEditableBy? ToEnum(string value)
        {
            return value switch
            {
                "org_actors" => OrgCustomPropertyValuesEditableBy.OrgActors,
                "org_and_repo_actors" => OrgCustomPropertyValuesEditableBy.OrgAndRepoActors,
                _ => null,
            };
        }
    }
}