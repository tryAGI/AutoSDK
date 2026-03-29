//HintName: G.Models.ConfigurableDataSinkNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfigurableDataSinkNames
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASTRA_DB")]
        AstraDb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZUREAI_SEARCH")]
        AzureaiSearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MILVUS")]
        Milvus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MONGODB_ATLAS")]
        MongodbAtlas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PINECONE")]
        Pinecone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POSTGRES")]
        Postgres,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QDRANT")]
        Qdrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfigurableDataSinkNamesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigurableDataSinkNames value)
        {
            return value switch
            {
                ConfigurableDataSinkNames.AstraDb => "ASTRA_DB",
                ConfigurableDataSinkNames.AzureaiSearch => "AZUREAI_SEARCH",
                ConfigurableDataSinkNames.Milvus => "MILVUS",
                ConfigurableDataSinkNames.MongodbAtlas => "MONGODB_ATLAS",
                ConfigurableDataSinkNames.Pinecone => "PINECONE",
                ConfigurableDataSinkNames.Postgres => "POSTGRES",
                ConfigurableDataSinkNames.Qdrant => "QDRANT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigurableDataSinkNames? ToEnum(string value)
        {
            return value switch
            {
                "ASTRA_DB" => ConfigurableDataSinkNames.AstraDb,
                "AZUREAI_SEARCH" => ConfigurableDataSinkNames.AzureaiSearch,
                "MILVUS" => ConfigurableDataSinkNames.Milvus,
                "MONGODB_ATLAS" => ConfigurableDataSinkNames.MongodbAtlas,
                "PINECONE" => ConfigurableDataSinkNames.Pinecone,
                "POSTGRES" => ConfigurableDataSinkNames.Postgres,
                "QDRANT" => ConfigurableDataSinkNames.Qdrant,
                _ => null,
            };
        }
    }
}