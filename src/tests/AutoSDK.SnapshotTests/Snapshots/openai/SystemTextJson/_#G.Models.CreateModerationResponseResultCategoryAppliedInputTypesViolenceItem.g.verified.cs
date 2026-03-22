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
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
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
                CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem.Image => "image",
                CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem.Text => "text",
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
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem.Image,
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem.Text,
                _ => null,
            };
        }
    }
}