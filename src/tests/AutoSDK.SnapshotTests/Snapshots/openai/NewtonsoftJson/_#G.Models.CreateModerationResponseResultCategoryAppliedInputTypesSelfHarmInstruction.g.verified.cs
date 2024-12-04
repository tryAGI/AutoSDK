//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction
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
    public static class CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstructionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.Text => "text",
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.Text,
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.Image,
                _ => null,
            };
        }
    }
}