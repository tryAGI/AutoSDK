//HintName: G.Models.VirtualKeysStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VirtualKeysStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Exhausted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VirtualKeysStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VirtualKeysStatus value)
        {
            return value switch
            {
                VirtualKeysStatus.Active => "active",
                VirtualKeysStatus.Exhausted => "exhausted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VirtualKeysStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => VirtualKeysStatus.Active,
                "exhausted" => VirtualKeysStatus.Exhausted,
                _ => null,
            };
        }
    }
}