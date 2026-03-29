//HintName: G.Models.CreateAzureOpenAICredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAzureOpenAICredentialDTORegion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="australiaeast")]
        Australiaeast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="canadacentral")]
        Canadacentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="canadaeast")]
        Canadaeast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eastus")]
        Eastus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eastus2")]
        Eastus2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="france")]
        France,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="germanywestcentral")]
        Germanywestcentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="india")]
        India,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="japaneast")]
        Japaneast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="japanwest")]
        Japanwest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="northcentralus")]
        Northcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="norway")]
        Norway,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="polandcentral")]
        Polandcentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="southcentralus")]
        Southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spaincentral")]
        Spaincentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swedencentral")]
        Swedencentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="switzerland")]
        Switzerland,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uaenorth")]
        Uaenorth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uk")]
        Uk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="westeurope")]
        Westeurope,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="westus")]
        Westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="westus3")]
        Westus3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAzureOpenAICredentialDTORegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAzureOpenAICredentialDTORegion value)
        {
            return value switch
            {
                CreateAzureOpenAICredentialDTORegion.Australiaeast => "australiaeast",
                CreateAzureOpenAICredentialDTORegion.Canadacentral => "canadacentral",
                CreateAzureOpenAICredentialDTORegion.Canadaeast => "canadaeast",
                CreateAzureOpenAICredentialDTORegion.Eastus => "eastus",
                CreateAzureOpenAICredentialDTORegion.Eastus2 => "eastus2",
                CreateAzureOpenAICredentialDTORegion.France => "france",
                CreateAzureOpenAICredentialDTORegion.Germanywestcentral => "germanywestcentral",
                CreateAzureOpenAICredentialDTORegion.India => "india",
                CreateAzureOpenAICredentialDTORegion.Japaneast => "japaneast",
                CreateAzureOpenAICredentialDTORegion.Japanwest => "japanwest",
                CreateAzureOpenAICredentialDTORegion.Northcentralus => "northcentralus",
                CreateAzureOpenAICredentialDTORegion.Norway => "norway",
                CreateAzureOpenAICredentialDTORegion.Polandcentral => "polandcentral",
                CreateAzureOpenAICredentialDTORegion.Southcentralus => "southcentralus",
                CreateAzureOpenAICredentialDTORegion.Spaincentral => "spaincentral",
                CreateAzureOpenAICredentialDTORegion.Swedencentral => "swedencentral",
                CreateAzureOpenAICredentialDTORegion.Switzerland => "switzerland",
                CreateAzureOpenAICredentialDTORegion.Uaenorth => "uaenorth",
                CreateAzureOpenAICredentialDTORegion.Uk => "uk",
                CreateAzureOpenAICredentialDTORegion.Westeurope => "westeurope",
                CreateAzureOpenAICredentialDTORegion.Westus => "westus",
                CreateAzureOpenAICredentialDTORegion.Westus3 => "westus3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAzureOpenAICredentialDTORegion? ToEnum(string value)
        {
            return value switch
            {
                "australiaeast" => CreateAzureOpenAICredentialDTORegion.Australiaeast,
                "canadacentral" => CreateAzureOpenAICredentialDTORegion.Canadacentral,
                "canadaeast" => CreateAzureOpenAICredentialDTORegion.Canadaeast,
                "eastus" => CreateAzureOpenAICredentialDTORegion.Eastus,
                "eastus2" => CreateAzureOpenAICredentialDTORegion.Eastus2,
                "france" => CreateAzureOpenAICredentialDTORegion.France,
                "germanywestcentral" => CreateAzureOpenAICredentialDTORegion.Germanywestcentral,
                "india" => CreateAzureOpenAICredentialDTORegion.India,
                "japaneast" => CreateAzureOpenAICredentialDTORegion.Japaneast,
                "japanwest" => CreateAzureOpenAICredentialDTORegion.Japanwest,
                "northcentralus" => CreateAzureOpenAICredentialDTORegion.Northcentralus,
                "norway" => CreateAzureOpenAICredentialDTORegion.Norway,
                "polandcentral" => CreateAzureOpenAICredentialDTORegion.Polandcentral,
                "southcentralus" => CreateAzureOpenAICredentialDTORegion.Southcentralus,
                "spaincentral" => CreateAzureOpenAICredentialDTORegion.Spaincentral,
                "swedencentral" => CreateAzureOpenAICredentialDTORegion.Swedencentral,
                "switzerland" => CreateAzureOpenAICredentialDTORegion.Switzerland,
                "uaenorth" => CreateAzureOpenAICredentialDTORegion.Uaenorth,
                "uk" => CreateAzureOpenAICredentialDTORegion.Uk,
                "westeurope" => CreateAzureOpenAICredentialDTORegion.Westeurope,
                "westus" => CreateAzureOpenAICredentialDTORegion.Westus,
                "westus3" => CreateAzureOpenAICredentialDTORegion.Westus3,
                _ => null,
            };
        }
    }
}