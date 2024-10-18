//HintName: G.Models.ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Visibility of a runner group. You can select all repositories, select individual repositories, or all private repositories.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility value)
        {
            return value switch
            {
                ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility.Selected => "selected",
                ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility.All => "all",
                ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "selected" => ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility.Selected,
                "all" => ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility.All,
                "private" => ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility.Private,
                _ => null,
            };
        }
    }
}