//HintName: G.Models.OrganizationActionsVariableVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Visibility of a variable
    /// </summary>
    public enum OrganizationActionsVariableVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationActionsVariableVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationActionsVariableVisibility value)
        {
            return value switch
            {
                OrganizationActionsVariableVisibility.All => "all",
                OrganizationActionsVariableVisibility.Private => "private",
                OrganizationActionsVariableVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationActionsVariableVisibility ToEnum(string value)
        {
            return value switch
            {
                "all" => OrganizationActionsVariableVisibility.All,
                "private" => OrganizationActionsVariableVisibility.Private,
                "selected" => OrganizationActionsVariableVisibility.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}