//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationResponseResultCategoryAppliedInputTypesViolenceItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem.Text => "text",
                CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem.Text,
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem.Image,
                _ => null,
            };
        }
    }
}