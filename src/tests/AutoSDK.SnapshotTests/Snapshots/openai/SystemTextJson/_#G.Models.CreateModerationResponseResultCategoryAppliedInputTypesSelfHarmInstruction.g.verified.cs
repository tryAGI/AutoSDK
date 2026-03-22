//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction
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
    public static class CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstructionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction value)
        {
            return value switch
            {
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.Image => "image",
                CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.Text => "text",
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
                "image" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.Image,
                "text" => CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction.Text,
                _ => null,
            };
        }
    }
}