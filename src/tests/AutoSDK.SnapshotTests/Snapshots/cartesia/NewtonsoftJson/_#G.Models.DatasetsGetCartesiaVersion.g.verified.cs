//HintName: G.Models.DatasetsGetCartesiaVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: 2025-04-16
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetsGetCartesiaVersion
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
    public static class DatasetsGetCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsGetCartesiaVersion value)
        {
            return value switch
            {
                DatasetsGetCartesiaVersion.x20240610 => "2024-06-10",
                DatasetsGetCartesiaVersion.x20241113 => "2024-11-13",
                DatasetsGetCartesiaVersion.x20250416 => "2025-04-16",
                DatasetsGetCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsGetCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2024-06-10" => DatasetsGetCartesiaVersion.x20240610,
                "2024-11-13" => DatasetsGetCartesiaVersion.x20241113,
                "2025-04-16" => DatasetsGetCartesiaVersion.x20250416,
                "2025-11-04" => DatasetsGetCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}