//HintName: G.Models.ModelPublicServiceGetModelDefinitionView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceGetModelDefinitionView
    {
        /// <summary>
        /// Default view, only includes basic information (omits `model_spec`).
        /// </summary>
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelPublicServiceGetModelDefinitionViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceGetModelDefinitionView value)
        {
            return value switch
            {
                ModelPublicServiceGetModelDefinitionView.ViewBasic => "VIEW_BASIC",
                ModelPublicServiceGetModelDefinitionView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceGetModelDefinitionView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceGetModelDefinitionView.ViewBasic,
                "VIEW_FULL" => ModelPublicServiceGetModelDefinitionView.ViewFull,
                _ => null,
            };
        }
    }
}