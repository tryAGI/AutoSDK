//HintName: G.Models.PipelineV1betaView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// View defines how a resource is presented. Most resources can share this view<br/>
    /// definition, the particular meaning of each value should be defined in the<br/>
    /// resource itself. Certain resources might have their own View definition if<br/>
    /// they need to implement more than 2 (basic / full) views.<br/>
    ///  - VIEW_BASIC: Default view.<br/>
    ///  - VIEW_FULL: Full representation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelineV1betaView
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
    public static class PipelineV1betaViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineV1betaView value)
        {
            return value switch
            {
                PipelineV1betaView.ViewBasic => "VIEW_BASIC",
                PipelineV1betaView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineV1betaView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelineV1betaView.ViewBasic,
                "VIEW_FULL" => PipelineV1betaView.ViewFull,
                _ => null,
            };
        }
    }
}