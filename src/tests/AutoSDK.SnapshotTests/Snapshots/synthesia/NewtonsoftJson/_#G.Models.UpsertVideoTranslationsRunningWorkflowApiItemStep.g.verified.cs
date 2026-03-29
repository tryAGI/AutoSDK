//HintName: G.Models.UpsertVideoTranslationsRunningWorkflowApiItemStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpsertVideoTranslationsRunningWorkflowApiItemStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation")]
        Generation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation")]
        Translation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpsertVideoTranslationsRunningWorkflowApiItemStepExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertVideoTranslationsRunningWorkflowApiItemStep value)
        {
            return value switch
            {
                UpsertVideoTranslationsRunningWorkflowApiItemStep.Generation => "generation",
                UpsertVideoTranslationsRunningWorkflowApiItemStep.Translation => "translation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertVideoTranslationsRunningWorkflowApiItemStep? ToEnum(string value)
        {
            return value switch
            {
                "generation" => UpsertVideoTranslationsRunningWorkflowApiItemStep.Generation,
                "translation" => UpsertVideoTranslationsRunningWorkflowApiItemStep.Translation,
                _ => null,
            };
        }
    }
}