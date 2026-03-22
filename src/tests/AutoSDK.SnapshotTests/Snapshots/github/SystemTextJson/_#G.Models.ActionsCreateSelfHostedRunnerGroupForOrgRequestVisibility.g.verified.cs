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
    public static class ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility value)
        {
            return value switch
            {
                ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.All => "all",
                ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.Private => "private",
                ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.Selected => "selected",
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
                "all" => ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.All,
                "private" => ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.Private,
                "selected" => ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.Selected,
                _ => null,
            };
        }
    }
}