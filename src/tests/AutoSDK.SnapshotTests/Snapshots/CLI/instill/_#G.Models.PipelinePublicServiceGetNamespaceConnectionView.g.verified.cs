//HintName: G.Models.PipelinePublicServiceGetNamespaceConnectionView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceGetNamespaceConnectionView
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
    public static class PipelinePublicServiceGetNamespaceConnectionViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceGetNamespaceConnectionView value)
        {
            return value switch
            {
                PipelinePublicServiceGetNamespaceConnectionView.VIEWBASIC => "VIEW_BASIC",
                PipelinePublicServiceGetNamespaceConnectionView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceGetNamespaceConnectionView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceGetNamespaceConnectionView.VIEWBASIC,
                "VIEW_FULL" => PipelinePublicServiceGetNamespaceConnectionView.VIEWFULL,
                _ => null,
            };
        }
    }
}