//HintName: G.Models.UpdateAzureOpenAICredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateAzureOpenAICredentialDTORegion
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