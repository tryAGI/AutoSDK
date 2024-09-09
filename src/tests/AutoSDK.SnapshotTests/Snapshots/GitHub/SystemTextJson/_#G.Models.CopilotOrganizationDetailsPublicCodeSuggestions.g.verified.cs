//HintName: G.Models.CopilotOrganizationDetailsPublicCodeSuggestions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The organization policy for allowing or disallowing Copilot to make suggestions that match public code.
    /// </summary>
    public enum CopilotOrganizationDetailsPublicCodeSuggestions
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Unconfigured,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotOrganizationDetailsPublicCodeSuggestionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotOrganizationDetailsPublicCodeSuggestions value)
        {
            return value switch
            {
                CopilotOrganizationDetailsPublicCodeSuggestions.Allow => "allow",
                CopilotOrganizationDetailsPublicCodeSuggestions.Block => "block",
                CopilotOrganizationDetailsPublicCodeSuggestions.Unconfigured => "unconfigured",
                CopilotOrganizationDetailsPublicCodeSuggestions.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotOrganizationDetailsPublicCodeSuggestions? ToEnum(string value)
        {
            return value switch
            {
                "allow" => CopilotOrganizationDetailsPublicCodeSuggestions.Allow,
                "block" => CopilotOrganizationDetailsPublicCodeSuggestions.Block,
                "unconfigured" => CopilotOrganizationDetailsPublicCodeSuggestions.Unconfigured,
                "unknown" => CopilotOrganizationDetailsPublicCodeSuggestions.Unknown,
                _ => null,
            };
        }
    }
}