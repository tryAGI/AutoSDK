//HintName: G.Models.IssuesListMilestonesSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: due_on
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListMilestonesSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="due_on")]
        DueOn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completeness")]
        Completeness,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListMilestonesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListMilestonesSort value)
        {
            return value switch
            {
                IssuesListMilestonesSort.DueOn => "due_on",
                IssuesListMilestonesSort.Completeness => "completeness",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListMilestonesSort ToEnum(string value)
        {
            return value switch
            {
                "due_on" => IssuesListMilestonesSort.DueOn,
                "completeness" => IssuesListMilestonesSort.Completeness,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}