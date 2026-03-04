//HintName: G.Models.PipelinePublicServiceGetNamespaceConnectionView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinePublicServiceGetNamespaceConnectionView
    {
        /// <summary>
        /// Default view.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        ViewFull,
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
                PipelinePublicServiceGetNamespaceConnectionView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceGetNamespaceConnectionView.ViewFull => "VIEW_FULL",
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
                "VIEW_BASIC" => PipelinePublicServiceGetNamespaceConnectionView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceGetNamespaceConnectionView.ViewFull,
                _ => null,
            };
        }
    }
}