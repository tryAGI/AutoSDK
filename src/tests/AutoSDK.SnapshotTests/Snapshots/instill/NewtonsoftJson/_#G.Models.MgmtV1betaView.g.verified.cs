//HintName: G.Models.MgmtV1betaView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// View defines how a resource is presented. It can be used as a parameter in a<br/>
    /// method request to allow clients to select the amount of information they<br/>
    /// want in the response.<br/>
    ///  - VIEW_BASIC: Default view, only includes basic information.<br/>
    ///  - VIEW_FULL: Full representation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MgmtV1betaView
    {
        /// <summary>
        /// Default view, only includes basic information.
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
    public static class MgmtV1betaViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MgmtV1betaView value)
        {
            return value switch
            {
                MgmtV1betaView.ViewBasic => "VIEW_BASIC",
                MgmtV1betaView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MgmtV1betaView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => MgmtV1betaView.ViewBasic,
                "VIEW_FULL" => MgmtV1betaView.ViewFull,
                _ => null,
            };
        }
    }
}