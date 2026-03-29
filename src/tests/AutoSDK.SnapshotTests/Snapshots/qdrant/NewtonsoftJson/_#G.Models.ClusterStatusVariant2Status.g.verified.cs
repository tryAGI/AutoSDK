//HintName: G.Models.ClusterStatusVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClusterStatusVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClusterStatusVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClusterStatusVariant2Status value)
        {
            return value switch
            {
                ClusterStatusVariant2Status.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClusterStatusVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => ClusterStatusVariant2Status.Enabled,
                _ => null,
            };
        }
    }
}