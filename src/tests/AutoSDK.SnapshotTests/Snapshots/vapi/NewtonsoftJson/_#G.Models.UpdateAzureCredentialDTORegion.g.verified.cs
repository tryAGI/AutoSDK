//HintName: G.Models.UpdateAzureCredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the region of the Azure resource.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateAzureCredentialDTORegion
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