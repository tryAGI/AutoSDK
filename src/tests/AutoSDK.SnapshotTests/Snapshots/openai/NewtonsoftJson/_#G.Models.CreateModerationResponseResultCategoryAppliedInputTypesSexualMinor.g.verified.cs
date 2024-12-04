//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor
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
    public static class CreateModerationResponseResultCategoryAppliedInputTypesSexualMinorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor.Text,
                _ => null,
            };
        }
    }
}