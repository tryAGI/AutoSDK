//HintName: G.Models.AzureOpenAICredentialRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AzureOpenAICredentialRegion
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
    public static class AzureOpenAICredentialRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureOpenAICredentialRegion value)
        {
            return value switch
            {
                AzureOpenAICredentialRegion.Australiaeast => "australiaeast",
                AzureOpenAICredentialRegion.Canadacentral => "canadacentral",
                AzureOpenAICredentialRegion.Canadaeast => "canadaeast",
                AzureOpenAICredentialRegion.Eastus => "eastus",
                AzureOpenAICredentialRegion.Eastus2 => "eastus2",
                AzureOpenAICredentialRegion.France => "france",
                AzureOpenAICredentialRegion.Germanywestcentral => "germanywestcentral",
                AzureOpenAICredentialRegion.India => "india",
                AzureOpenAICredentialRegion.Japaneast => "japaneast",
                AzureOpenAICredentialRegion.Japanwest => "japanwest",
                AzureOpenAICredentialRegion.Northcentralus => "northcentralus",
                AzureOpenAICredentialRegion.Norway => "norway",
                AzureOpenAICredentialRegion.Polandcentral => "polandcentral",
                AzureOpenAICredentialRegion.Southcentralus => "southcentralus",
                AzureOpenAICredentialRegion.Spaincentral => "spaincentral",
                AzureOpenAICredentialRegion.Swedencentral => "swedencentral",
                AzureOpenAICredentialRegion.Switzerland => "switzerland",
                AzureOpenAICredentialRegion.Uaenorth => "uaenorth",
                AzureOpenAICredentialRegion.Uk => "uk",
                AzureOpenAICredentialRegion.Westeurope => "westeurope",
                AzureOpenAICredentialRegion.Westus => "westus",
                AzureOpenAICredentialRegion.Westus3 => "westus3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureOpenAICredentialRegion? ToEnum(string value)
        {
            return value switch
            {
                "australiaeast" => AzureOpenAICredentialRegion.Australiaeast,
                "canadacentral" => AzureOpenAICredentialRegion.Canadacentral,
                "canadaeast" => AzureOpenAICredentialRegion.Canadaeast,
                "eastus" => AzureOpenAICredentialRegion.Eastus,
                "eastus2" => AzureOpenAICredentialRegion.Eastus2,
                "france" => AzureOpenAICredentialRegion.France,
                "germanywestcentral" => AzureOpenAICredentialRegion.Germanywestcentral,
                "india" => AzureOpenAICredentialRegion.India,
                "japaneast" => AzureOpenAICredentialRegion.Japaneast,
                "japanwest" => AzureOpenAICredentialRegion.Japanwest,
                "northcentralus" => AzureOpenAICredentialRegion.Northcentralus,
                "norway" => AzureOpenAICredentialRegion.Norway,
                "polandcentral" => AzureOpenAICredentialRegion.Polandcentral,
                "southcentralus" => AzureOpenAICredentialRegion.Southcentralus,
                "spaincentral" => AzureOpenAICredentialRegion.Spaincentral,
                "swedencentral" => AzureOpenAICredentialRegion.Swedencentral,
                "switzerland" => AzureOpenAICredentialRegion.Switzerland,
                "uaenorth" => AzureOpenAICredentialRegion.Uaenorth,
                "uk" => AzureOpenAICredentialRegion.Uk,
                "westeurope" => AzureOpenAICredentialRegion.Westeurope,
                "westus" => AzureOpenAICredentialRegion.Westus,
                "westus3" => AzureOpenAICredentialRegion.Westus3,
                _ => null,
            };
        }
    }
}