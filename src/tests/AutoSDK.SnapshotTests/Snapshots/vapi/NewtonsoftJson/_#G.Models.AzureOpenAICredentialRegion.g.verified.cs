//HintName: G.Models.AzureOpenAICredentialRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureOpenAICredentialRegion
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