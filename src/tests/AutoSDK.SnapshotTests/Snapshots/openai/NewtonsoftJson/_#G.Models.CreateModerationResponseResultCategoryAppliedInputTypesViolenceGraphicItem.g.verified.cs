//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
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
                CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.Text => "text",
                CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.Image => "image",
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
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.Text,
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.Image,
                _ => null,
            };
        }
    }
}