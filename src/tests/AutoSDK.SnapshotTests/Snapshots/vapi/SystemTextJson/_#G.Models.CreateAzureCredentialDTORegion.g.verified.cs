//HintName: G.Models.CreateAzureCredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the region of the Azure resource.
    /// </summary>
    public enum CreateAzureCredentialDTORegion
    {
        /// <summary>
        /// 
        /// </summary>
        Australiaeast,
        /// <summary>
        /// 
        /// </summary>
        Canadacentral,
        /// <summary>
        /// 
        /// </summary>
        Canadaeast,
        /// <summary>
        /// 
        /// </summary>
        Eastus,
        /// <summary>
        /// 
        /// </summary>
        Eastus2,
        /// <summary>
        /// 
        /// </summary>
        France,
        /// <summary>
        /// 
        /// </summary>
        Germanywestcentral,
        /// <summary>
        /// 
        /// </summary>
        India,
        /// <summary>
        /// 
        /// </summary>
        Japaneast,
        /// <summary>
        /// 
        /// </summary>
        Japanwest,
        /// <summary>
        /// 
        /// </summary>
        Northcentralus,
        /// <summary>
        /// 
        /// </summary>
        Norway,
        /// <summary>
        /// 
        /// </summary>
        Polandcentral,
        /// <summary>
        /// 
        /// </summary>
        Southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Spaincentral,
        /// <summary>
        /// 
        /// </summary>
        Swedencentral,
        /// <summary>
        /// 
        /// </summary>
        Switzerland,
        /// <summary>
        /// 
        /// </summary>
        Uaenorth,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Westeurope,
        /// <summary>
        /// 
        /// </summary>
        Westus,
        /// <summary>
        /// 
        /// </summary>
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