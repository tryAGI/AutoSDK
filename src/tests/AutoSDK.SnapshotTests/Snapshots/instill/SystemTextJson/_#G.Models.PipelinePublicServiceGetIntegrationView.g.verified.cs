//HintName: G.Models.PipelinePublicServiceGetIntegrationView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceGetIntegrationView
    {
        /// <summary>
        /// Default view.
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
    public static class PipelinePublicServiceGetIntegrationViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceGetIntegrationView value)
        {
            return value switch
            {
                PipelinePublicServiceGetIntegrationView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceGetIntegrationView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceGetIntegrationView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceGetIntegrationView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceGetIntegrationView.ViewFull,
                _ => null,
            };
        }
    }
}