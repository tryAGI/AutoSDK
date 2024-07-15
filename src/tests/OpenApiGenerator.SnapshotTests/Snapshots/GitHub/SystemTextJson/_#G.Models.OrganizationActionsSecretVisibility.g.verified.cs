//HintName: G.Models.OrganizationActionsSecretVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Visibility of a secret
    /// </summary>
    public enum OrganizationActionsSecretVisibility
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
    public static class OrganizationActionsSecretVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationActionsSecretVisibility value)
        {
            return value switch
            {
                OrganizationActionsSecretVisibility.All => "all",
                OrganizationActionsSecretVisibility.Private => "private",
                OrganizationActionsSecretVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationActionsSecretVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrganizationActionsSecretVisibility.All,
                "private" => OrganizationActionsSecretVisibility.Private,
                "selected" => OrganizationActionsSecretVisibility.Selected,
                _ => null,
            };
        }
    }
}