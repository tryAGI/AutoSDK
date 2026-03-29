//HintName: G.Models.UpdateAzureOpenAICredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAzureOpenAICredentialDTORegion
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
    public static class UpdateAzureOpenAICredentialDTORegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAzureOpenAICredentialDTORegion value)
        {
            return value switch
            {
                UpdateAzureOpenAICredentialDTORegion.Australiaeast => "australiaeast",
                UpdateAzureOpenAICredentialDTORegion.Canadacentral => "canadacentral",
                UpdateAzureOpenAICredentialDTORegion.Canadaeast => "canadaeast",
                UpdateAzureOpenAICredentialDTORegion.Eastus => "eastus",
                UpdateAzureOpenAICredentialDTORegion.Eastus2 => "eastus2",
                UpdateAzureOpenAICredentialDTORegion.France => "france",
                UpdateAzureOpenAICredentialDTORegion.Germanywestcentral => "germanywestcentral",
                UpdateAzureOpenAICredentialDTORegion.India => "india",
                UpdateAzureOpenAICredentialDTORegion.Japaneast => "japaneast",
                UpdateAzureOpenAICredentialDTORegion.Japanwest => "japanwest",
                UpdateAzureOpenAICredentialDTORegion.Northcentralus => "northcentralus",
                UpdateAzureOpenAICredentialDTORegion.Norway => "norway",
                UpdateAzureOpenAICredentialDTORegion.Polandcentral => "polandcentral",
                UpdateAzureOpenAICredentialDTORegion.Southcentralus => "southcentralus",
                UpdateAzureOpenAICredentialDTORegion.Spaincentral => "spaincentral",
                UpdateAzureOpenAICredentialDTORegion.Swedencentral => "swedencentral",
                UpdateAzureOpenAICredentialDTORegion.Switzerland => "switzerland",
                UpdateAzureOpenAICredentialDTORegion.Uaenorth => "uaenorth",
                UpdateAzureOpenAICredentialDTORegion.Uk => "uk",
                UpdateAzureOpenAICredentialDTORegion.Westeurope => "westeurope",
                UpdateAzureOpenAICredentialDTORegion.Westus => "westus",
                UpdateAzureOpenAICredentialDTORegion.Westus3 => "westus3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAzureOpenAICredentialDTORegion? ToEnum(string value)
        {
            return value switch
            {
                "australiaeast" => UpdateAzureOpenAICredentialDTORegion.Australiaeast,
                "canadacentral" => UpdateAzureOpenAICredentialDTORegion.Canadacentral,
                "canadaeast" => UpdateAzureOpenAICredentialDTORegion.Canadaeast,
                "eastus" => UpdateAzureOpenAICredentialDTORegion.Eastus,
                "eastus2" => UpdateAzureOpenAICredentialDTORegion.Eastus2,
                "france" => UpdateAzureOpenAICredentialDTORegion.France,
                "germanywestcentral" => UpdateAzureOpenAICredentialDTORegion.Germanywestcentral,
                "india" => UpdateAzureOpenAICredentialDTORegion.India,
                "japaneast" => UpdateAzureOpenAICredentialDTORegion.Japaneast,
                "japanwest" => UpdateAzureOpenAICredentialDTORegion.Japanwest,
                "northcentralus" => UpdateAzureOpenAICredentialDTORegion.Northcentralus,
                "norway" => UpdateAzureOpenAICredentialDTORegion.Norway,
                "polandcentral" => UpdateAzureOpenAICredentialDTORegion.Polandcentral,
                "southcentralus" => UpdateAzureOpenAICredentialDTORegion.Southcentralus,
                "spaincentral" => UpdateAzureOpenAICredentialDTORegion.Spaincentral,
                "swedencentral" => UpdateAzureOpenAICredentialDTORegion.Swedencentral,
                "switzerland" => UpdateAzureOpenAICredentialDTORegion.Switzerland,
                "uaenorth" => UpdateAzureOpenAICredentialDTORegion.Uaenorth,
                "uk" => UpdateAzureOpenAICredentialDTORegion.Uk,
                "westeurope" => UpdateAzureOpenAICredentialDTORegion.Westeurope,
                "westus" => UpdateAzureOpenAICredentialDTORegion.Westus,
                "westus3" => UpdateAzureOpenAICredentialDTORegion.Westus3,
                _ => null,
            };
        }
    }
}