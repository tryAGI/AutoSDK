//HintName: G.Models.DatasetsUpdateCartesiaVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: 2025-04-16
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetsUpdateCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2024-06-10")]
        x20240610,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2024-11-13")]
        x20241113,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2025-04-16")]
        x20250416,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2025-11-04")]
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsUpdateCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsUpdateCartesiaVersion value)
        {
            return value switch
            {
                DatasetsUpdateCartesiaVersion.x20240610 => "2024-06-10",
                DatasetsUpdateCartesiaVersion.x20241113 => "2024-11-13",
                DatasetsUpdateCartesiaVersion.x20250416 => "2025-04-16",
                DatasetsUpdateCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsUpdateCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2024-06-10" => DatasetsUpdateCartesiaVersion.x20240610,
                "2024-11-13" => DatasetsUpdateCartesiaVersion.x20241113,
                "2025-04-16" => DatasetsUpdateCartesiaVersion.x20250416,
                "2025-11-04" => DatasetsUpdateCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}