//HintName: G.Models.RepositoryRuleNonFastForwardType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleNonFastForwardType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non_fast_forward")]
        NonFastForward,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleNonFastForwardTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleNonFastForwardType value)
        {
            return value switch
            {
                RepositoryRuleNonFastForwardType.NonFastForward => "non_fast_forward",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleNonFastForwardType? ToEnum(string value)
        {
            return value switch
            {
                "non_fast_forward" => RepositoryRuleNonFastForwardType.NonFastForward,
                _ => null,
            };
        }
    }
}