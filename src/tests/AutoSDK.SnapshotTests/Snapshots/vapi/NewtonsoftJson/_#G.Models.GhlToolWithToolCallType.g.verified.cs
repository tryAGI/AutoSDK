//HintName: G.Models.GhlToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "ghl" for GHL tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GhlToolWithToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ghl")]
        Ghl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GhlToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GhlToolWithToolCallType value)
        {
            return value switch
            {
                GhlToolWithToolCallType.Ghl => "ghl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GhlToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "ghl" => GhlToolWithToolCallType.Ghl,
                _ => null,
            };
        }
    }
}