//HintName: G.Models.DataSourceReaderVersionMetadataReaderVersion2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataSourceReaderVersionMetadataReaderVersion2
    {
        /// <summary>
        /// 
        /// </summary>
        x10,
        /// <summary>
        /// 
        /// </summary>
        x20,
        /// <summary>
        /// 
        /// </summary>
        x21,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataSourceReaderVersionMetadataReaderVersion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataSourceReaderVersionMetadataReaderVersion2 value)
        {
            return value switch
            {
                DataSourceReaderVersionMetadataReaderVersion2.x10 => "1.0",
                DataSourceReaderVersionMetadataReaderVersion2.x20 => "2.0",
                DataSourceReaderVersionMetadataReaderVersion2.x21 => "2.1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataSourceReaderVersionMetadataReaderVersion2? ToEnum(string value)
        {
            return value switch
            {
                "1.0" => DataSourceReaderVersionMetadataReaderVersion2.x10,
                "2.0" => DataSourceReaderVersionMetadataReaderVersion2.x20,
                "2.1" => DataSourceReaderVersionMetadataReaderVersion2.x21,
                _ => null,
            };
        }
    }
}