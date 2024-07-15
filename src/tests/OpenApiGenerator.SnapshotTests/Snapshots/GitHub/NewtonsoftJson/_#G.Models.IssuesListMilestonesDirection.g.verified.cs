//HintName: G.Models.IssuesListMilestonesDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListMilestonesDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListMilestonesDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListMilestonesDirection value)
        {
            return value switch
            {
                IssuesListMilestonesDirection.Asc => "asc",
                IssuesListMilestonesDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListMilestonesDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => IssuesListMilestonesDirection.Asc,
                "desc" => IssuesListMilestonesDirection.Desc,
                _ => null,
            };
        }
    }
}