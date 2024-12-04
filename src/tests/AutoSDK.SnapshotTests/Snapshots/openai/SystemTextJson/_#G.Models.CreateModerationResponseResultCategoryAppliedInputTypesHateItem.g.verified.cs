//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesHateItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationResponseResultCategoryAppliedInputTypesHateItem
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationResponseResultCategoryAppliedInputTypesHateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesHateItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesHateItem.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesHateItem? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesHateItem.Text,
                _ => null,
            };
        }
    }
}