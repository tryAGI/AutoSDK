//HintName: G.Models.PipelinePublicServiceListComponentDefinitionsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceListComponentDefinitionsView
    {
        /// <summary>
        /// Default view, only includes basic information (removes the `spec`
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
    public static class PipelinePublicServiceListComponentDefinitionsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListComponentDefinitionsView value)
        {
            return value switch
            {
                PipelinePublicServiceListComponentDefinitionsView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceListComponentDefinitionsView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListComponentDefinitionsView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceListComponentDefinitionsView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceListComponentDefinitionsView.ViewFull,
                _ => null,
            };
        }
    }
}