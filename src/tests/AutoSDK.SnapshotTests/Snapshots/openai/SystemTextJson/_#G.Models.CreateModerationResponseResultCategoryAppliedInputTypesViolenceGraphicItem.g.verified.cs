//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem
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
    public static class CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.Image => "image",
                CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.Image,
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.Text,
                _ => null,
            };
        }
    }
}