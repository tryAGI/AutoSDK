//HintName: G.Models.WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleType
    {
        /// <summary>
        /// 
        /// </summary>
        FilePathRestriction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleType value)
        {
            return value switch
            {
                WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleType.FilePathRestriction => "file_path_restriction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleType? ToEnum(string value)
        {
            return value switch
            {
                "file_path_restriction" => WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleType.FilePathRestriction,
                _ => null,
            };
        }
    }
}