//HintName: G.Models.RepositoryRuleRequiredSignaturesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleRequiredSignaturesType
    {
        /// <summary>
        /// 
        /// </summary>
        RequiredSignatures,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleRequiredSignaturesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleRequiredSignaturesType value)
        {
            return value switch
            {
                RepositoryRuleRequiredSignaturesType.RequiredSignatures => "required_signatures",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleRequiredSignaturesType? ToEnum(string value)
        {
            return value switch
            {
                "required_signatures" => RepositoryRuleRequiredSignaturesType.RequiredSignatures,
                _ => null,
            };
        }
    }
}