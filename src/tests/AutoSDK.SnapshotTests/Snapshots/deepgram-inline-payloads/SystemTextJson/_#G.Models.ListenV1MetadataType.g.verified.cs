//HintName: G.Models.ListenV1MetadataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV1MetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1MetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MetadataType value)
        {
            return value switch
            {
                ListenV1MetadataType.Metadata => "Metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MetadataType? ToEnum(string value)
        {
            return value switch
            {
                "Metadata" => ListenV1MetadataType.Metadata,
                _ => null,
            };
        }
    }
}