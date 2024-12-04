//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem.Text,
                _ => null,
            };
        }
    }
}