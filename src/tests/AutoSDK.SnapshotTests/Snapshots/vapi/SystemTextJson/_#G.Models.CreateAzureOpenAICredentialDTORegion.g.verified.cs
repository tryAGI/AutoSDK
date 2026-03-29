//HintName: G.Models.CreateAzureOpenAICredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAzureOpenAICredentialDTORegion
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