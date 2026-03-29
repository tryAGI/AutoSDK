//HintName: G.Models.GeoIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GeoIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="geo")]
        Geo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeoIndexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeoIndexType value)
        {
            return value switch
            {
                GeoIndexType.Geo => "geo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeoIndexType? ToEnum(string value)
        {
            return value switch
            {
                "geo" => GeoIndexType.Geo,
                _ => null,
            };
        }
    }
}