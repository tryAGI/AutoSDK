//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationResponseResultCategoryAppliedInputTypesSexualItem
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
    public static class CreateModerationResponseResultCategoryAppliedInputTypesSexualItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesSexualItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.Image => "image",
                CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesSexualItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.Image,
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.Text,
                _ => null,
            };
        }
    }
}