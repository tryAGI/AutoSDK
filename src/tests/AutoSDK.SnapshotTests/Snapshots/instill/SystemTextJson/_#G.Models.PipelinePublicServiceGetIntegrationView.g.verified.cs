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
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        VIEWFULL,
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
                PipelinePublicServiceGetIntegrationView.VIEWBASIC => "VIEW_BASIC",
                PipelinePublicServiceGetIntegrationView.VIEWFULL => "VIEW_FULL",
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
                "VIEW_BASIC" => PipelinePublicServiceGetIntegrationView.VIEWBASIC,
                "VIEW_FULL" => PipelinePublicServiceGetIntegrationView.VIEWFULL,
                _ => null,
            };
        }
    }
}