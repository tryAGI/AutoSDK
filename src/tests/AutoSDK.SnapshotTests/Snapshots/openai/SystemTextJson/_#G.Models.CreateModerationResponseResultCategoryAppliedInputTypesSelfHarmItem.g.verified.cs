//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.Image => "image",
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.Image,
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.Text,
                _ => null,
            };
        }
    }
}