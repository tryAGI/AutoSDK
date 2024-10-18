//HintName: G.Models.ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Visibility of a runner group. You can select all repositories, select individual repositories, or limit access to private repositories.<br/>
    /// Default Value: all
    /// </summary>
    public enum ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Selected,
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility value)
        {
            return value switch
            {
                ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.Selected => "selected",
                ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.All => "all",
                ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "selected" => ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.Selected,
                "all" => ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.All,
                "private" => ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.Private,
                _ => null,
            };
        }
    }
}