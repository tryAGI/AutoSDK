//HintName: G.Models.RepositoryAdvisoryUpdateState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the advisory.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryUpdateState
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryAdvisoryUpdateStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryUpdateState value)
        {
            return value switch
            {
                RepositoryAdvisoryUpdateState.Closed => "closed",
                RepositoryAdvisoryUpdateState.Draft => "draft",
                RepositoryAdvisoryUpdateState.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryUpdateState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => RepositoryAdvisoryUpdateState.Closed,
                "draft" => RepositoryAdvisoryUpdateState.Draft,
                "published" => RepositoryAdvisoryUpdateState.Published,
                _ => null,
            };
        }
    }
}