//HintName: G.Models.VirtualKeysObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VirtualKeysObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="virtual-key")]
        VirtualKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VirtualKeysObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VirtualKeysObject value)
        {
            return value switch
            {
                VirtualKeysObject.VirtualKey => "virtual-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VirtualKeysObject? ToEnum(string value)
        {
            return value switch
            {
                "virtual-key" => VirtualKeysObject.VirtualKey,
                _ => null,
            };
        }
    }
}