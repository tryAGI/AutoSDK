//HintName: G.Models.UpdateAzureCredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the region of the Azure resource.
    /// </summary>
    public enum UpdateAzureCredentialDTORegion
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
    public static class UpdateAzureCredentialDTORegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAzureCredentialDTORegion value)
        {
            return value switch
            {
                UpdateAzureCredentialDTORegion.Australiaeast => "australiaeast",
                UpdateAzureCredentialDTORegion.Canadacentral => "canadacentral",
                UpdateAzureCredentialDTORegion.Canadaeast => "canadaeast",
                UpdateAzureCredentialDTORegion.Eastus => "eastus",
                UpdateAzureCredentialDTORegion.Eastus2 => "eastus2",
                UpdateAzureCredentialDTORegion.France => "france",
                UpdateAzureCredentialDTORegion.Germanywestcentral => "germanywestcentral",
                UpdateAzureCredentialDTORegion.India => "india",
                UpdateAzureCredentialDTORegion.Japaneast => "japaneast",
                UpdateAzureCredentialDTORegion.Japanwest => "japanwest",
                UpdateAzureCredentialDTORegion.Northcentralus => "northcentralus",
                UpdateAzureCredentialDTORegion.Norway => "norway",
                UpdateAzureCredentialDTORegion.Polandcentral => "polandcentral",
                UpdateAzureCredentialDTORegion.Southcentralus => "southcentralus",
                UpdateAzureCredentialDTORegion.Spaincentral => "spaincentral",
                UpdateAzureCredentialDTORegion.Swedencentral => "swedencentral",
                UpdateAzureCredentialDTORegion.Switzerland => "switzerland",
                UpdateAzureCredentialDTORegion.Uaenorth => "uaenorth",
                UpdateAzureCredentialDTORegion.Uk => "uk",
                UpdateAzureCredentialDTORegion.Westeurope => "westeurope",
                UpdateAzureCredentialDTORegion.Westus => "westus",
                UpdateAzureCredentialDTORegion.Westus3 => "westus3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAzureCredentialDTORegion? ToEnum(string value)
        {
            return value switch
            {
                "australiaeast" => UpdateAzureCredentialDTORegion.Australiaeast,
                "canadacentral" => UpdateAzureCredentialDTORegion.Canadacentral,
                "canadaeast" => UpdateAzureCredentialDTORegion.Canadaeast,
                "eastus" => UpdateAzureCredentialDTORegion.Eastus,
                "eastus2" => UpdateAzureCredentialDTORegion.Eastus2,
                "france" => UpdateAzureCredentialDTORegion.France,
                "germanywestcentral" => UpdateAzureCredentialDTORegion.Germanywestcentral,
                "india" => UpdateAzureCredentialDTORegion.India,
                "japaneast" => UpdateAzureCredentialDTORegion.Japaneast,
                "japanwest" => UpdateAzureCredentialDTORegion.Japanwest,
                "northcentralus" => UpdateAzureCredentialDTORegion.Northcentralus,
                "norway" => UpdateAzureCredentialDTORegion.Norway,
                "polandcentral" => UpdateAzureCredentialDTORegion.Polandcentral,
                "southcentralus" => UpdateAzureCredentialDTORegion.Southcentralus,
                "spaincentral" => UpdateAzureCredentialDTORegion.Spaincentral,
                "swedencentral" => UpdateAzureCredentialDTORegion.Swedencentral,
                "switzerland" => UpdateAzureCredentialDTORegion.Switzerland,
                "uaenorth" => UpdateAzureCredentialDTORegion.Uaenorth,
                "uk" => UpdateAzureCredentialDTORegion.Uk,
                "westeurope" => UpdateAzureCredentialDTORegion.Westeurope,
                "westus" => UpdateAzureCredentialDTORegion.Westus,
                "westus3" => UpdateAzureCredentialDTORegion.Westus3,
                _ => null,
            };
        }
    }
}