//HintName: G.Models.CreateAzureCredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the region of the Azure resource.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAzureCredentialDTORegion
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
    public static class CreateAzureCredentialDTORegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAzureCredentialDTORegion value)
        {
            return value switch
            {
                CreateAzureCredentialDTORegion.Australiaeast => "australiaeast",
                CreateAzureCredentialDTORegion.Canadacentral => "canadacentral",
                CreateAzureCredentialDTORegion.Canadaeast => "canadaeast",
                CreateAzureCredentialDTORegion.Eastus => "eastus",
                CreateAzureCredentialDTORegion.Eastus2 => "eastus2",
                CreateAzureCredentialDTORegion.France => "france",
                CreateAzureCredentialDTORegion.Germanywestcentral => "germanywestcentral",
                CreateAzureCredentialDTORegion.India => "india",
                CreateAzureCredentialDTORegion.Japaneast => "japaneast",
                CreateAzureCredentialDTORegion.Japanwest => "japanwest",
                CreateAzureCredentialDTORegion.Northcentralus => "northcentralus",
                CreateAzureCredentialDTORegion.Norway => "norway",
                CreateAzureCredentialDTORegion.Polandcentral => "polandcentral",
                CreateAzureCredentialDTORegion.Southcentralus => "southcentralus",
                CreateAzureCredentialDTORegion.Spaincentral => "spaincentral",
                CreateAzureCredentialDTORegion.Swedencentral => "swedencentral",
                CreateAzureCredentialDTORegion.Switzerland => "switzerland",
                CreateAzureCredentialDTORegion.Uaenorth => "uaenorth",
                CreateAzureCredentialDTORegion.Uk => "uk",
                CreateAzureCredentialDTORegion.Westeurope => "westeurope",
                CreateAzureCredentialDTORegion.Westus => "westus",
                CreateAzureCredentialDTORegion.Westus3 => "westus3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAzureCredentialDTORegion? ToEnum(string value)
        {
            return value switch
            {
                "australiaeast" => CreateAzureCredentialDTORegion.Australiaeast,
                "canadacentral" => CreateAzureCredentialDTORegion.Canadacentral,
                "canadaeast" => CreateAzureCredentialDTORegion.Canadaeast,
                "eastus" => CreateAzureCredentialDTORegion.Eastus,
                "eastus2" => CreateAzureCredentialDTORegion.Eastus2,
                "france" => CreateAzureCredentialDTORegion.France,
                "germanywestcentral" => CreateAzureCredentialDTORegion.Germanywestcentral,
                "india" => CreateAzureCredentialDTORegion.India,
                "japaneast" => CreateAzureCredentialDTORegion.Japaneast,
                "japanwest" => CreateAzureCredentialDTORegion.Japanwest,
                "northcentralus" => CreateAzureCredentialDTORegion.Northcentralus,
                "norway" => CreateAzureCredentialDTORegion.Norway,
                "polandcentral" => CreateAzureCredentialDTORegion.Polandcentral,
                "southcentralus" => CreateAzureCredentialDTORegion.Southcentralus,
                "spaincentral" => CreateAzureCredentialDTORegion.Spaincentral,
                "swedencentral" => CreateAzureCredentialDTORegion.Swedencentral,
                "switzerland" => CreateAzureCredentialDTORegion.Switzerland,
                "uaenorth" => CreateAzureCredentialDTORegion.Uaenorth,
                "uk" => CreateAzureCredentialDTORegion.Uk,
                "westeurope" => CreateAzureCredentialDTORegion.Westeurope,
                "westus" => CreateAzureCredentialDTORegion.Westus,
                "westus3" => CreateAzureCredentialDTORegion.Westus3,
                _ => null,
            };
        }
    }
}