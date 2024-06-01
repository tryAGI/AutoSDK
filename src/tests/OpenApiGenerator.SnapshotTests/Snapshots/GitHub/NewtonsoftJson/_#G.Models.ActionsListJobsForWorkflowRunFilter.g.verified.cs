//HintName: G.Models.ActionsListJobsForWorkflowRunFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: latest
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsListJobsForWorkflowRunFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latest")]
        Latest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsListJobsForWorkflowRunFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListJobsForWorkflowRunFilter value)
        {
            return value switch
            {
                ActionsListJobsForWorkflowRunFilter.Latest => "latest",
                ActionsListJobsForWorkflowRunFilter.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListJobsForWorkflowRunFilter ToEnum(string value)
        {
            return value switch
            {
                "latest" => ActionsListJobsForWorkflowRunFilter.Latest,
                "all" => ActionsListJobsForWorkflowRunFilter.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}