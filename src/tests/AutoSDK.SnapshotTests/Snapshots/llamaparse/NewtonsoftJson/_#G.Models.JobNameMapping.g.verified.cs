//HintName: G.Models.JobNameMapping.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for mapping original job names to readable names.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobNameMapping
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DATA_SOURCE")]
        DataSource,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_UPDATER")]
        FileUpdater,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INGESTION")]
        Ingestion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANAGED_INGESTION")]
        ManagedIngestion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="METADATA_UPDATE")]
        MetadataUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARSE")]
        Parse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRANSFORM")]
        Transform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobNameMappingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobNameMapping value)
        {
            return value switch
            {
                JobNameMapping.DataSource => "DATA_SOURCE",
                JobNameMapping.FileUpdater => "FILE_UPDATER",
                JobNameMapping.Ingestion => "INGESTION",
                JobNameMapping.ManagedIngestion => "MANAGED_INGESTION",
                JobNameMapping.MetadataUpdate => "METADATA_UPDATE",
                JobNameMapping.Parse => "PARSE",
                JobNameMapping.Transform => "TRANSFORM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobNameMapping? ToEnum(string value)
        {
            return value switch
            {
                "DATA_SOURCE" => JobNameMapping.DataSource,
                "FILE_UPDATER" => JobNameMapping.FileUpdater,
                "INGESTION" => JobNameMapping.Ingestion,
                "MANAGED_INGESTION" => JobNameMapping.ManagedIngestion,
                "METADATA_UPDATE" => JobNameMapping.MetadataUpdate,
                "PARSE" => JobNameMapping.Parse,
                "TRANSFORM" => JobNameMapping.Transform,
                _ => null,
            };
        }
    }
}