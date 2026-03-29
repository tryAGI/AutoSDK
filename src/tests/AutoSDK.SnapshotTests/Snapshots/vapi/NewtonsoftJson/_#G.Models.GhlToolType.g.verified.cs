//HintName: G.Models.GhlToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "ghl" for GHL tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GhlToolType
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
    public static class GhlToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GhlToolType value)
        {
            return value switch
            {
                GhlToolType.Ghl => "ghl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GhlToolType? ToEnum(string value)
        {
            return value switch
            {
                "ghl" => GhlToolType.Ghl,
                _ => null,
            };
        }
    }
}