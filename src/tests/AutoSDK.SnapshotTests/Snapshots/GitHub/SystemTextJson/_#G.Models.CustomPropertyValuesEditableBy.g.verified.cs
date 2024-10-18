//HintName: G.Models.CustomPropertyValuesEditableBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Who can edit the values of the property<br/>
    /// Example: org_actors
    /// </summary>
    public enum CustomPropertyValuesEditableBy
    {
        /// <summary>
        /// 
        /// </summary>
        OrgActors,
        /// <summary>
        /// 
        /// </summary>
        OrgAndRepoActors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomPropertyValuesEditableByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomPropertyValuesEditableBy value)
        {
            return value switch
            {
                CustomPropertyValuesEditableBy.OrgActors => "org_actors",
                CustomPropertyValuesEditableBy.OrgAndRepoActors => "org_and_repo_actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomPropertyValuesEditableBy? ToEnum(string value)
        {
            return value switch
            {
                "org_actors" => CustomPropertyValuesEditableBy.OrgActors,
                "org_and_repo_actors" => CustomPropertyValuesEditableBy.OrgAndRepoActors,
                _ => null,
            };
        }
    }
}