//HintName: G.Models.ActionsCreateOrgVariableRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of repositories in the organization that can access the variable. `selected` means only the repositories specified by `selected_repository_ids` can access the variable.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsCreateOrgVariableRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsCreateOrgVariableRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateOrgVariableRequestVisibility value)
        {
            return value switch
            {
                ActionsCreateOrgVariableRequestVisibility.All => "all",
                ActionsCreateOrgVariableRequestVisibility.Private => "private",
                ActionsCreateOrgVariableRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateOrgVariableRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsCreateOrgVariableRequestVisibility.All,
                "private" => ActionsCreateOrgVariableRequestVisibility.Private,
                "selected" => ActionsCreateOrgVariableRequestVisibility.Selected,
                _ => null,
            };
        }
    }
}