//HintName: G.Models.RepositoryAdvisoryState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the advisory.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="draft")]
        Draft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="published")]
        Published,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="triage")]
        Triage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="withdrawn")]
        Withdrawn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryAdvisoryStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryState value)
        {
            return value switch
            {
                RepositoryAdvisoryState.Closed => "closed",
                RepositoryAdvisoryState.Draft => "draft",
                RepositoryAdvisoryState.Published => "published",
                RepositoryAdvisoryState.Triage => "triage",
                RepositoryAdvisoryState.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => RepositoryAdvisoryState.Closed,
                "draft" => RepositoryAdvisoryState.Draft,
                "published" => RepositoryAdvisoryState.Published,
                "triage" => RepositoryAdvisoryState.Triage,
                "withdrawn" => RepositoryAdvisoryState.Withdrawn,
                _ => null,
            };
        }
    }
}