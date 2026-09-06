//HintName: G.Models.DataSourceReaderVersionMetadataReaderVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataSourceReaderVersionMetadataReaderVersion
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
    public static class DataSourceReaderVersionMetadataReaderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataSourceReaderVersionMetadataReaderVersion value)
        {
            return value switch
            {
                DataSourceReaderVersionMetadataReaderVersion.x10 => "1.0",
                DataSourceReaderVersionMetadataReaderVersion.x20 => "2.0",
                DataSourceReaderVersionMetadataReaderVersion.x21 => "2.1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataSourceReaderVersionMetadataReaderVersion? ToEnum(string value)
        {
            return value switch
            {
                "1.0" => DataSourceReaderVersionMetadataReaderVersion.x10,
                "2.0" => DataSourceReaderVersionMetadataReaderVersion.x20,
                "2.1" => DataSourceReaderVersionMetadataReaderVersion.x21,
                _ => null,
            };
        }
    }
}