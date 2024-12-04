//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem
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
    public static class CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.Text => "text",
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.Image => "image",
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
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.Text,
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem.Image,
                _ => null,
            };
        }
    }
}