//HintName: G.Models.ActionsUpdateOrgVariableRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of repositories in the organization that can access the variable. `selected` means only the repositories specified by `selected_repository_ids` can access the variable.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsUpdateOrgVariableRequestVisibility
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
    public static class ActionsUpdateOrgVariableRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateOrgVariableRequestVisibility value)
        {
            return value switch
            {
                ActionsUpdateOrgVariableRequestVisibility.All => "all",
                ActionsUpdateOrgVariableRequestVisibility.Private => "private",
                ActionsUpdateOrgVariableRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateOrgVariableRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsUpdateOrgVariableRequestVisibility.All,
                "private" => ActionsUpdateOrgVariableRequestVisibility.Private,
                "selected" => ActionsUpdateOrgVariableRequestVisibility.Selected,
                _ => null,
            };
        }
    }
}