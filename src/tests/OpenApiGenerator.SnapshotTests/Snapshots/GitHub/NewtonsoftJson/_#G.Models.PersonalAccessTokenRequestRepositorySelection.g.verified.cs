//HintName: G.Models.PersonalAccessTokenRequestRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of repository selection requested.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PersonalAccessTokenRequestRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subset")]
        Subset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersonalAccessTokenRequestRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersonalAccessTokenRequestRepositorySelection value)
        {
            return value switch
            {
                PersonalAccessTokenRequestRepositorySelection.None => "none",
                PersonalAccessTokenRequestRepositorySelection.All => "all",
                PersonalAccessTokenRequestRepositorySelection.Subset => "subset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersonalAccessTokenRequestRepositorySelection? ToEnum(string value)
        {
            return value switch
            {
                "none" => PersonalAccessTokenRequestRepositorySelection.None,
                "all" => PersonalAccessTokenRequestRepositorySelection.All,
                "subset" => PersonalAccessTokenRequestRepositorySelection.Subset,
                _ => null,
            };
        }
    }
}