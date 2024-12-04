//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModerationResponseResultCategoryAppliedInputTypesSexualItem
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
    public static class CreateModerationResponseResultCategoryAppliedInputTypesSexualItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesSexualItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.Text => "text",
                CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.Image => "image",
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
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.Text,
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesSexualItem.Image,
                _ => null,
            };
        }
    }
}