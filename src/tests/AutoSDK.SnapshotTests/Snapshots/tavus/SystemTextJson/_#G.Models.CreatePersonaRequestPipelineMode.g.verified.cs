//HintName: G.Models.CreatePersonaRequestPipelineMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePersonaRequestPipelineMode
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePersonaRequestPipelineModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePersonaRequestPipelineMode value)
        {
            return value switch
            {
                CreatePersonaRequestPipelineMode.Custom => "custom",
                CreatePersonaRequestPipelineMode.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePersonaRequestPipelineMode? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreatePersonaRequestPipelineMode.Custom,
                "full" => CreatePersonaRequestPipelineMode.Full,
                _ => null,
            };
        }
    }
}