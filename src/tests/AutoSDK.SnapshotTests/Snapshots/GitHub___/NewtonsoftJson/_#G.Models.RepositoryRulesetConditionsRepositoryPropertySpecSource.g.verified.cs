//HintName: G.Models.RepositoryRulesetConditionsRepositoryPropertySpecSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source of the repository property. Defaults to 'custom' if not specified.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRulesetConditionsRepositoryPropertySpecSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulesetConditionsRepositoryPropertySpecSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetConditionsRepositoryPropertySpecSource value)
        {
            return value switch
            {
                RepositoryRulesetConditionsRepositoryPropertySpecSource.Custom => "custom",
                RepositoryRulesetConditionsRepositoryPropertySpecSource.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetConditionsRepositoryPropertySpecSource? ToEnum(string value)
        {
            return value switch
            {
                "custom" => RepositoryRulesetConditionsRepositoryPropertySpecSource.Custom,
                "system" => RepositoryRulesetConditionsRepositoryPropertySpecSource.System,
                _ => null,
            };
        }
    }
}