//HintName: G.Models.AzureCredentialRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the region of the Azure resource.
    /// </summary>
    public enum AzureCredentialRegion
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
    public static class AzureCredentialRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureCredentialRegion value)
        {
            return value switch
            {
                AzureCredentialRegion.Australiaeast => "australiaeast",
                AzureCredentialRegion.Canadacentral => "canadacentral",
                AzureCredentialRegion.Canadaeast => "canadaeast",
                AzureCredentialRegion.Eastus => "eastus",
                AzureCredentialRegion.Eastus2 => "eastus2",
                AzureCredentialRegion.France => "france",
                AzureCredentialRegion.Germanywestcentral => "germanywestcentral",
                AzureCredentialRegion.India => "india",
                AzureCredentialRegion.Japaneast => "japaneast",
                AzureCredentialRegion.Japanwest => "japanwest",
                AzureCredentialRegion.Northcentralus => "northcentralus",
                AzureCredentialRegion.Norway => "norway",
                AzureCredentialRegion.Polandcentral => "polandcentral",
                AzureCredentialRegion.Southcentralus => "southcentralus",
                AzureCredentialRegion.Spaincentral => "spaincentral",
                AzureCredentialRegion.Swedencentral => "swedencentral",
                AzureCredentialRegion.Switzerland => "switzerland",
                AzureCredentialRegion.Uaenorth => "uaenorth",
                AzureCredentialRegion.Uk => "uk",
                AzureCredentialRegion.Westeurope => "westeurope",
                AzureCredentialRegion.Westus => "westus",
                AzureCredentialRegion.Westus3 => "westus3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureCredentialRegion? ToEnum(string value)
        {
            return value switch
            {
                "australiaeast" => AzureCredentialRegion.Australiaeast,
                "canadacentral" => AzureCredentialRegion.Canadacentral,
                "canadaeast" => AzureCredentialRegion.Canadaeast,
                "eastus" => AzureCredentialRegion.Eastus,
                "eastus2" => AzureCredentialRegion.Eastus2,
                "france" => AzureCredentialRegion.France,
                "germanywestcentral" => AzureCredentialRegion.Germanywestcentral,
                "india" => AzureCredentialRegion.India,
                "japaneast" => AzureCredentialRegion.Japaneast,
                "japanwest" => AzureCredentialRegion.Japanwest,
                "northcentralus" => AzureCredentialRegion.Northcentralus,
                "norway" => AzureCredentialRegion.Norway,
                "polandcentral" => AzureCredentialRegion.Polandcentral,
                "southcentralus" => AzureCredentialRegion.Southcentralus,
                "spaincentral" => AzureCredentialRegion.Spaincentral,
                "swedencentral" => AzureCredentialRegion.Swedencentral,
                "switzerland" => AzureCredentialRegion.Switzerland,
                "uaenorth" => AzureCredentialRegion.Uaenorth,
                "uk" => AzureCredentialRegion.Uk,
                "westeurope" => AzureCredentialRegion.Westeurope,
                "westus" => AzureCredentialRegion.Westus,
                "westus3" => AzureCredentialRegion.Westus3,
                _ => null,
            };
        }
    }
}