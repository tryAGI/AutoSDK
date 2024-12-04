//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem.Text,
                _ => null,
            };
        }
    }
}