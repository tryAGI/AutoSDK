//HintName: G.Models.EvalOpenAIModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the OpenAI model that will be used.<br/>
    /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
    /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalOpenAIModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chatgpt-4o-latest")]
        Chatgpt4oLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo")]
        Gpt35Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-0125")]
        Gpt35Turbo0125,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-0125:canadaeast")]
        Gpt35Turbo0125_canadaeast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-0125:northcentralus")]
        Gpt35Turbo0125_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-0125:southcentralus")]
        Gpt35Turbo0125_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-0613")]
        Gpt35Turbo0613,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-1106")]
        Gpt35Turbo1106,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-1106:canadaeast")]
        Gpt35Turbo1106_canadaeast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-1106:westus")]
        Gpt35Turbo1106_westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-16k")]
        Gpt35Turbo16k,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4")]
        Gpt4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0125-preview")]
        Gpt40125Preview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0125-preview:eastus")]
        Gpt40125Preview_eastus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0125-preview:northcentralus")]
        Gpt40125Preview_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0125-preview:southcentralus")]
        Gpt40125Preview_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0613")]
        Gpt40613,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0613:canadaeast")]
        Gpt40613_canadaeast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview")]
        Gpt41106Preview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview:australiaeast")]
        Gpt41106Preview_australiaeast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview:canadaeast")]
        Gpt41106Preview_canadaeast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview:france")]
        Gpt41106Preview_france,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview:india")]
        Gpt41106Preview_india,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview:norway")]
        Gpt41106Preview_norway,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview:swedencentral")]
        Gpt41106Preview_swedencentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview:uk")]
        Gpt41106Preview_uk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview:westus")]
        Gpt41106Preview_westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview:westus3")]
        Gpt41106Preview_westus3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-turbo")]
        Gpt4Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-turbo-2024-04-09")]
        Gpt4Turbo20240409,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-turbo-2024-04-09:eastus2")]
        Gpt4Turbo20240409_eastus2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-turbo-preview")]
        Gpt4TurboPreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1")]
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14")]
        Gpt4120250414,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:eastus")]
        Gpt4120250414_eastus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:eastus2")]
        Gpt4120250414_eastus2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:germanywestcentral")]
        Gpt4120250414_germanywestcentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:northcentralus")]
        Gpt4120250414_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:polandcentral")]
        Gpt4120250414_polandcentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:southcentralus")]
        Gpt4120250414_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:spaincentral")]
        Gpt4120250414_spaincentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:westeurope")]
        Gpt4120250414_westeurope,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:westus")]
        Gpt4120250414_westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14:westus3")]
        Gpt4120250414_westus3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini")]
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14")]
        Gpt41Mini20250414,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:eastus")]
        Gpt41Mini20250414_eastus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:eastus2")]
        Gpt41Mini20250414_eastus2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:germanywestcentral")]
        Gpt41Mini20250414_germanywestcentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:northcentralus")]
        Gpt41Mini20250414_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:polandcentral")]
        Gpt41Mini20250414_polandcentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:southcentralus")]
        Gpt41Mini20250414_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:spaincentral")]
        Gpt41Mini20250414_spaincentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:westeurope")]
        Gpt41Mini20250414_westeurope,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:westus")]
        Gpt41Mini20250414_westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14:westus3")]
        Gpt41Mini20250414_westus3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano")]
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano-2025-04-14")]
        Gpt41Nano20250414,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano-2025-04-14:eastus2")]
        Gpt41Nano20250414_eastus2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano-2025-04-14:northcentralus")]
        Gpt41Nano20250414_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano-2025-04-14:southcentralus")]
        Gpt41Nano20250414_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano-2025-04-14:westus")]
        Gpt41Nano20250414_westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano-2025-04-14:westus3")]
        Gpt41Nano20250414_westus3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o")]
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13")]
        Gpt4o20240513,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13:eastus")]
        Gpt4o20240513_eastus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13:eastus2")]
        Gpt4o20240513_eastus2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13:northcentralus")]
        Gpt4o20240513_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13:southcentralus")]
        Gpt4o20240513_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13:westus")]
        Gpt4o20240513_westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13:westus3")]
        Gpt4o20240513_westus3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06")]
        Gpt4o20240806,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06:eastus")]
        Gpt4o20240806_eastus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06:eastus2")]
        Gpt4o20240806_eastus2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06:northcentralus")]
        Gpt4o20240806_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06:southcentralus")]
        Gpt4o20240806_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06:westus")]
        Gpt4o20240806_westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06:westus3")]
        Gpt4o20240806_westus3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20")]
        Gpt4o20241120,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:eastus")]
        Gpt4o20241120_eastus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:eastus2")]
        Gpt4o20241120_eastus2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:germanywestcentral")]
        Gpt4o20241120_germanywestcentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:polandcentral")]
        Gpt4o20241120_polandcentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:southcentralus")]
        Gpt4o20241120_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:spaincentral")]
        Gpt4o20241120_spaincentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:swedencentral")]
        Gpt4o20241120_swedencentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:westeurope")]
        Gpt4o20241120_westeurope,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:westus")]
        Gpt4o20241120_westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20:westus3")]
        Gpt4o20241120_westus3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini")]
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-2024-07-18")]
        Gpt4oMini20240718,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-2024-07-18:eastus")]
        Gpt4oMini20240718_eastus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-2024-07-18:eastus2")]
        Gpt4oMini20240718_eastus2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-2024-07-18:northcentralus")]
        Gpt4oMini20240718_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-2024-07-18:southcentralus")]
        Gpt4oMini20240718_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-2024-07-18:westus")]
        Gpt4oMini20240718_westus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-2024-07-18:westus3")]
        Gpt4oMini20240718_westus3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5")]
        Gpt5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-chat-latest")]
        Gpt5ChatLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-mini")]
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-nano")]
        Gpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.1")]
        Gpt51,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.1-chat-latest")]
        Gpt51ChatLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.2")]
        Gpt52,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.2-chat-latest")]
        Gpt52ChatLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="o1-mini")]
        O1Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="o1-mini-2024-09-12")]
        O1Mini20240912,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="o3")]
        O3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="o3-mini")]
        O3Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="o4-mini")]
        O4Mini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalOpenAIModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalOpenAIModelModel value)
        {
            return value switch
            {
                EvalOpenAIModelModel.Chatgpt4oLatest => "chatgpt-4o-latest",
                EvalOpenAIModelModel.Gpt35Turbo => "gpt-3.5-turbo",
                EvalOpenAIModelModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                EvalOpenAIModelModel.Gpt35Turbo0125_canadaeast => "gpt-3.5-turbo-0125:canadaeast",
                EvalOpenAIModelModel.Gpt35Turbo0125_northcentralus => "gpt-3.5-turbo-0125:northcentralus",
                EvalOpenAIModelModel.Gpt35Turbo0125_southcentralus => "gpt-3.5-turbo-0125:southcentralus",
                EvalOpenAIModelModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                EvalOpenAIModelModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                EvalOpenAIModelModel.Gpt35Turbo1106_canadaeast => "gpt-3.5-turbo-1106:canadaeast",
                EvalOpenAIModelModel.Gpt35Turbo1106_westus => "gpt-3.5-turbo-1106:westus",
                EvalOpenAIModelModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                EvalOpenAIModelModel.Gpt4 => "gpt-4",
                EvalOpenAIModelModel.Gpt40125Preview => "gpt-4-0125-preview",
                EvalOpenAIModelModel.Gpt40125Preview_eastus => "gpt-4-0125-preview:eastus",
                EvalOpenAIModelModel.Gpt40125Preview_northcentralus => "gpt-4-0125-preview:northcentralus",
                EvalOpenAIModelModel.Gpt40125Preview_southcentralus => "gpt-4-0125-preview:southcentralus",
                EvalOpenAIModelModel.Gpt40613 => "gpt-4-0613",
                EvalOpenAIModelModel.Gpt40613_canadaeast => "gpt-4-0613:canadaeast",
                EvalOpenAIModelModel.Gpt41106Preview => "gpt-4-1106-preview",
                EvalOpenAIModelModel.Gpt41106Preview_australiaeast => "gpt-4-1106-preview:australiaeast",
                EvalOpenAIModelModel.Gpt41106Preview_canadaeast => "gpt-4-1106-preview:canadaeast",
                EvalOpenAIModelModel.Gpt41106Preview_france => "gpt-4-1106-preview:france",
                EvalOpenAIModelModel.Gpt41106Preview_india => "gpt-4-1106-preview:india",
                EvalOpenAIModelModel.Gpt41106Preview_norway => "gpt-4-1106-preview:norway",
                EvalOpenAIModelModel.Gpt41106Preview_swedencentral => "gpt-4-1106-preview:swedencentral",
                EvalOpenAIModelModel.Gpt41106Preview_uk => "gpt-4-1106-preview:uk",
                EvalOpenAIModelModel.Gpt41106Preview_westus => "gpt-4-1106-preview:westus",
                EvalOpenAIModelModel.Gpt41106Preview_westus3 => "gpt-4-1106-preview:westus3",
                EvalOpenAIModelModel.Gpt4Turbo => "gpt-4-turbo",
                EvalOpenAIModelModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                EvalOpenAIModelModel.Gpt4Turbo20240409_eastus2 => "gpt-4-turbo-2024-04-09:eastus2",
                EvalOpenAIModelModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                EvalOpenAIModelModel.Gpt41 => "gpt-4.1",
                EvalOpenAIModelModel.Gpt4120250414 => "gpt-4.1-2025-04-14",
                EvalOpenAIModelModel.Gpt4120250414_eastus => "gpt-4.1-2025-04-14:eastus",
                EvalOpenAIModelModel.Gpt4120250414_eastus2 => "gpt-4.1-2025-04-14:eastus2",
                EvalOpenAIModelModel.Gpt4120250414_germanywestcentral => "gpt-4.1-2025-04-14:germanywestcentral",
                EvalOpenAIModelModel.Gpt4120250414_northcentralus => "gpt-4.1-2025-04-14:northcentralus",
                EvalOpenAIModelModel.Gpt4120250414_polandcentral => "gpt-4.1-2025-04-14:polandcentral",
                EvalOpenAIModelModel.Gpt4120250414_southcentralus => "gpt-4.1-2025-04-14:southcentralus",
                EvalOpenAIModelModel.Gpt4120250414_spaincentral => "gpt-4.1-2025-04-14:spaincentral",
                EvalOpenAIModelModel.Gpt4120250414_westeurope => "gpt-4.1-2025-04-14:westeurope",
                EvalOpenAIModelModel.Gpt4120250414_westus => "gpt-4.1-2025-04-14:westus",
                EvalOpenAIModelModel.Gpt4120250414_westus3 => "gpt-4.1-2025-04-14:westus3",
                EvalOpenAIModelModel.Gpt41Mini => "gpt-4.1-mini",
                EvalOpenAIModelModel.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                EvalOpenAIModelModel.Gpt41Mini20250414_eastus => "gpt-4.1-mini-2025-04-14:eastus",
                EvalOpenAIModelModel.Gpt41Mini20250414_eastus2 => "gpt-4.1-mini-2025-04-14:eastus2",
                EvalOpenAIModelModel.Gpt41Mini20250414_germanywestcentral => "gpt-4.1-mini-2025-04-14:germanywestcentral",
                EvalOpenAIModelModel.Gpt41Mini20250414_northcentralus => "gpt-4.1-mini-2025-04-14:northcentralus",
                EvalOpenAIModelModel.Gpt41Mini20250414_polandcentral => "gpt-4.1-mini-2025-04-14:polandcentral",
                EvalOpenAIModelModel.Gpt41Mini20250414_southcentralus => "gpt-4.1-mini-2025-04-14:southcentralus",
                EvalOpenAIModelModel.Gpt41Mini20250414_spaincentral => "gpt-4.1-mini-2025-04-14:spaincentral",
                EvalOpenAIModelModel.Gpt41Mini20250414_westeurope => "gpt-4.1-mini-2025-04-14:westeurope",
                EvalOpenAIModelModel.Gpt41Mini20250414_westus => "gpt-4.1-mini-2025-04-14:westus",
                EvalOpenAIModelModel.Gpt41Mini20250414_westus3 => "gpt-4.1-mini-2025-04-14:westus3",
                EvalOpenAIModelModel.Gpt41Nano => "gpt-4.1-nano",
                EvalOpenAIModelModel.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                EvalOpenAIModelModel.Gpt41Nano20250414_eastus2 => "gpt-4.1-nano-2025-04-14:eastus2",
                EvalOpenAIModelModel.Gpt41Nano20250414_northcentralus => "gpt-4.1-nano-2025-04-14:northcentralus",
                EvalOpenAIModelModel.Gpt41Nano20250414_southcentralus => "gpt-4.1-nano-2025-04-14:southcentralus",
                EvalOpenAIModelModel.Gpt41Nano20250414_westus => "gpt-4.1-nano-2025-04-14:westus",
                EvalOpenAIModelModel.Gpt41Nano20250414_westus3 => "gpt-4.1-nano-2025-04-14:westus3",
                EvalOpenAIModelModel.Gpt4o => "gpt-4o",
                EvalOpenAIModelModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                EvalOpenAIModelModel.Gpt4o20240513_eastus => "gpt-4o-2024-05-13:eastus",
                EvalOpenAIModelModel.Gpt4o20240513_eastus2 => "gpt-4o-2024-05-13:eastus2",
                EvalOpenAIModelModel.Gpt4o20240513_northcentralus => "gpt-4o-2024-05-13:northcentralus",
                EvalOpenAIModelModel.Gpt4o20240513_southcentralus => "gpt-4o-2024-05-13:southcentralus",
                EvalOpenAIModelModel.Gpt4o20240513_westus => "gpt-4o-2024-05-13:westus",
                EvalOpenAIModelModel.Gpt4o20240513_westus3 => "gpt-4o-2024-05-13:westus3",
                EvalOpenAIModelModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                EvalOpenAIModelModel.Gpt4o20240806_eastus => "gpt-4o-2024-08-06:eastus",
                EvalOpenAIModelModel.Gpt4o20240806_eastus2 => "gpt-4o-2024-08-06:eastus2",
                EvalOpenAIModelModel.Gpt4o20240806_northcentralus => "gpt-4o-2024-08-06:northcentralus",
                EvalOpenAIModelModel.Gpt4o20240806_southcentralus => "gpt-4o-2024-08-06:southcentralus",
                EvalOpenAIModelModel.Gpt4o20240806_westus => "gpt-4o-2024-08-06:westus",
                EvalOpenAIModelModel.Gpt4o20240806_westus3 => "gpt-4o-2024-08-06:westus3",
                EvalOpenAIModelModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                EvalOpenAIModelModel.Gpt4o20241120_eastus => "gpt-4o-2024-11-20:eastus",
                EvalOpenAIModelModel.Gpt4o20241120_eastus2 => "gpt-4o-2024-11-20:eastus2",
                EvalOpenAIModelModel.Gpt4o20241120_germanywestcentral => "gpt-4o-2024-11-20:germanywestcentral",
                EvalOpenAIModelModel.Gpt4o20241120_polandcentral => "gpt-4o-2024-11-20:polandcentral",
                EvalOpenAIModelModel.Gpt4o20241120_southcentralus => "gpt-4o-2024-11-20:southcentralus",
                EvalOpenAIModelModel.Gpt4o20241120_spaincentral => "gpt-4o-2024-11-20:spaincentral",
                EvalOpenAIModelModel.Gpt4o20241120_swedencentral => "gpt-4o-2024-11-20:swedencentral",
                EvalOpenAIModelModel.Gpt4o20241120_westeurope => "gpt-4o-2024-11-20:westeurope",
                EvalOpenAIModelModel.Gpt4o20241120_westus => "gpt-4o-2024-11-20:westus",
                EvalOpenAIModelModel.Gpt4o20241120_westus3 => "gpt-4o-2024-11-20:westus3",
                EvalOpenAIModelModel.Gpt4oMini => "gpt-4o-mini",
                EvalOpenAIModelModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                EvalOpenAIModelModel.Gpt4oMini20240718_eastus => "gpt-4o-mini-2024-07-18:eastus",
                EvalOpenAIModelModel.Gpt4oMini20240718_eastus2 => "gpt-4o-mini-2024-07-18:eastus2",
                EvalOpenAIModelModel.Gpt4oMini20240718_northcentralus => "gpt-4o-mini-2024-07-18:northcentralus",
                EvalOpenAIModelModel.Gpt4oMini20240718_southcentralus => "gpt-4o-mini-2024-07-18:southcentralus",
                EvalOpenAIModelModel.Gpt4oMini20240718_westus => "gpt-4o-mini-2024-07-18:westus",
                EvalOpenAIModelModel.Gpt4oMini20240718_westus3 => "gpt-4o-mini-2024-07-18:westus3",
                EvalOpenAIModelModel.Gpt5 => "gpt-5",
                EvalOpenAIModelModel.Gpt5ChatLatest => "gpt-5-chat-latest",
                EvalOpenAIModelModel.Gpt5Mini => "gpt-5-mini",
                EvalOpenAIModelModel.Gpt5Nano => "gpt-5-nano",
                EvalOpenAIModelModel.Gpt51 => "gpt-5.1",
                EvalOpenAIModelModel.Gpt51ChatLatest => "gpt-5.1-chat-latest",
                EvalOpenAIModelModel.Gpt52 => "gpt-5.2",
                EvalOpenAIModelModel.Gpt52ChatLatest => "gpt-5.2-chat-latest",
                EvalOpenAIModelModel.O1Mini => "o1-mini",
                EvalOpenAIModelModel.O1Mini20240912 => "o1-mini-2024-09-12",
                EvalOpenAIModelModel.O3 => "o3",
                EvalOpenAIModelModel.O3Mini => "o3-mini",
                EvalOpenAIModelModel.O4Mini => "o4-mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalOpenAIModelModel? ToEnum(string value)
        {
            return value switch
            {
                "chatgpt-4o-latest" => EvalOpenAIModelModel.Chatgpt4oLatest,
                "gpt-3.5-turbo" => EvalOpenAIModelModel.Gpt35Turbo,
                "gpt-3.5-turbo-0125" => EvalOpenAIModelModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-0125:canadaeast" => EvalOpenAIModelModel.Gpt35Turbo0125_canadaeast,
                "gpt-3.5-turbo-0125:northcentralus" => EvalOpenAIModelModel.Gpt35Turbo0125_northcentralus,
                "gpt-3.5-turbo-0125:southcentralus" => EvalOpenAIModelModel.Gpt35Turbo0125_southcentralus,
                "gpt-3.5-turbo-0613" => EvalOpenAIModelModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => EvalOpenAIModelModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-1106:canadaeast" => EvalOpenAIModelModel.Gpt35Turbo1106_canadaeast,
                "gpt-3.5-turbo-1106:westus" => EvalOpenAIModelModel.Gpt35Turbo1106_westus,
                "gpt-3.5-turbo-16k" => EvalOpenAIModelModel.Gpt35Turbo16k,
                "gpt-4" => EvalOpenAIModelModel.Gpt4,
                "gpt-4-0125-preview" => EvalOpenAIModelModel.Gpt40125Preview,
                "gpt-4-0125-preview:eastus" => EvalOpenAIModelModel.Gpt40125Preview_eastus,
                "gpt-4-0125-preview:northcentralus" => EvalOpenAIModelModel.Gpt40125Preview_northcentralus,
                "gpt-4-0125-preview:southcentralus" => EvalOpenAIModelModel.Gpt40125Preview_southcentralus,
                "gpt-4-0613" => EvalOpenAIModelModel.Gpt40613,
                "gpt-4-0613:canadaeast" => EvalOpenAIModelModel.Gpt40613_canadaeast,
                "gpt-4-1106-preview" => EvalOpenAIModelModel.Gpt41106Preview,
                "gpt-4-1106-preview:australiaeast" => EvalOpenAIModelModel.Gpt41106Preview_australiaeast,
                "gpt-4-1106-preview:canadaeast" => EvalOpenAIModelModel.Gpt41106Preview_canadaeast,
                "gpt-4-1106-preview:france" => EvalOpenAIModelModel.Gpt41106Preview_france,
                "gpt-4-1106-preview:india" => EvalOpenAIModelModel.Gpt41106Preview_india,
                "gpt-4-1106-preview:norway" => EvalOpenAIModelModel.Gpt41106Preview_norway,
                "gpt-4-1106-preview:swedencentral" => EvalOpenAIModelModel.Gpt41106Preview_swedencentral,
                "gpt-4-1106-preview:uk" => EvalOpenAIModelModel.Gpt41106Preview_uk,
                "gpt-4-1106-preview:westus" => EvalOpenAIModelModel.Gpt41106Preview_westus,
                "gpt-4-1106-preview:westus3" => EvalOpenAIModelModel.Gpt41106Preview_westus3,
                "gpt-4-turbo" => EvalOpenAIModelModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => EvalOpenAIModelModel.Gpt4Turbo20240409,
                "gpt-4-turbo-2024-04-09:eastus2" => EvalOpenAIModelModel.Gpt4Turbo20240409_eastus2,
                "gpt-4-turbo-preview" => EvalOpenAIModelModel.Gpt4TurboPreview,
                "gpt-4.1" => EvalOpenAIModelModel.Gpt41,
                "gpt-4.1-2025-04-14" => EvalOpenAIModelModel.Gpt4120250414,
                "gpt-4.1-2025-04-14:eastus" => EvalOpenAIModelModel.Gpt4120250414_eastus,
                "gpt-4.1-2025-04-14:eastus2" => EvalOpenAIModelModel.Gpt4120250414_eastus2,
                "gpt-4.1-2025-04-14:germanywestcentral" => EvalOpenAIModelModel.Gpt4120250414_germanywestcentral,
                "gpt-4.1-2025-04-14:northcentralus" => EvalOpenAIModelModel.Gpt4120250414_northcentralus,
                "gpt-4.1-2025-04-14:polandcentral" => EvalOpenAIModelModel.Gpt4120250414_polandcentral,
                "gpt-4.1-2025-04-14:southcentralus" => EvalOpenAIModelModel.Gpt4120250414_southcentralus,
                "gpt-4.1-2025-04-14:spaincentral" => EvalOpenAIModelModel.Gpt4120250414_spaincentral,
                "gpt-4.1-2025-04-14:westeurope" => EvalOpenAIModelModel.Gpt4120250414_westeurope,
                "gpt-4.1-2025-04-14:westus" => EvalOpenAIModelModel.Gpt4120250414_westus,
                "gpt-4.1-2025-04-14:westus3" => EvalOpenAIModelModel.Gpt4120250414_westus3,
                "gpt-4.1-mini" => EvalOpenAIModelModel.Gpt41Mini,
                "gpt-4.1-mini-2025-04-14" => EvalOpenAIModelModel.Gpt41Mini20250414,
                "gpt-4.1-mini-2025-04-14:eastus" => EvalOpenAIModelModel.Gpt41Mini20250414_eastus,
                "gpt-4.1-mini-2025-04-14:eastus2" => EvalOpenAIModelModel.Gpt41Mini20250414_eastus2,
                "gpt-4.1-mini-2025-04-14:germanywestcentral" => EvalOpenAIModelModel.Gpt41Mini20250414_germanywestcentral,
                "gpt-4.1-mini-2025-04-14:northcentralus" => EvalOpenAIModelModel.Gpt41Mini20250414_northcentralus,
                "gpt-4.1-mini-2025-04-14:polandcentral" => EvalOpenAIModelModel.Gpt41Mini20250414_polandcentral,
                "gpt-4.1-mini-2025-04-14:southcentralus" => EvalOpenAIModelModel.Gpt41Mini20250414_southcentralus,
                "gpt-4.1-mini-2025-04-14:spaincentral" => EvalOpenAIModelModel.Gpt41Mini20250414_spaincentral,
                "gpt-4.1-mini-2025-04-14:westeurope" => EvalOpenAIModelModel.Gpt41Mini20250414_westeurope,
                "gpt-4.1-mini-2025-04-14:westus" => EvalOpenAIModelModel.Gpt41Mini20250414_westus,
                "gpt-4.1-mini-2025-04-14:westus3" => EvalOpenAIModelModel.Gpt41Mini20250414_westus3,
                "gpt-4.1-nano" => EvalOpenAIModelModel.Gpt41Nano,
                "gpt-4.1-nano-2025-04-14" => EvalOpenAIModelModel.Gpt41Nano20250414,
                "gpt-4.1-nano-2025-04-14:eastus2" => EvalOpenAIModelModel.Gpt41Nano20250414_eastus2,
                "gpt-4.1-nano-2025-04-14:northcentralus" => EvalOpenAIModelModel.Gpt41Nano20250414_northcentralus,
                "gpt-4.1-nano-2025-04-14:southcentralus" => EvalOpenAIModelModel.Gpt41Nano20250414_southcentralus,
                "gpt-4.1-nano-2025-04-14:westus" => EvalOpenAIModelModel.Gpt41Nano20250414_westus,
                "gpt-4.1-nano-2025-04-14:westus3" => EvalOpenAIModelModel.Gpt41Nano20250414_westus3,
                "gpt-4o" => EvalOpenAIModelModel.Gpt4o,
                "gpt-4o-2024-05-13" => EvalOpenAIModelModel.Gpt4o20240513,
                "gpt-4o-2024-05-13:eastus" => EvalOpenAIModelModel.Gpt4o20240513_eastus,
                "gpt-4o-2024-05-13:eastus2" => EvalOpenAIModelModel.Gpt4o20240513_eastus2,
                "gpt-4o-2024-05-13:northcentralus" => EvalOpenAIModelModel.Gpt4o20240513_northcentralus,
                "gpt-4o-2024-05-13:southcentralus" => EvalOpenAIModelModel.Gpt4o20240513_southcentralus,
                "gpt-4o-2024-05-13:westus" => EvalOpenAIModelModel.Gpt4o20240513_westus,
                "gpt-4o-2024-05-13:westus3" => EvalOpenAIModelModel.Gpt4o20240513_westus3,
                "gpt-4o-2024-08-06" => EvalOpenAIModelModel.Gpt4o20240806,
                "gpt-4o-2024-08-06:eastus" => EvalOpenAIModelModel.Gpt4o20240806_eastus,
                "gpt-4o-2024-08-06:eastus2" => EvalOpenAIModelModel.Gpt4o20240806_eastus2,
                "gpt-4o-2024-08-06:northcentralus" => EvalOpenAIModelModel.Gpt4o20240806_northcentralus,
                "gpt-4o-2024-08-06:southcentralus" => EvalOpenAIModelModel.Gpt4o20240806_southcentralus,
                "gpt-4o-2024-08-06:westus" => EvalOpenAIModelModel.Gpt4o20240806_westus,
                "gpt-4o-2024-08-06:westus3" => EvalOpenAIModelModel.Gpt4o20240806_westus3,
                "gpt-4o-2024-11-20" => EvalOpenAIModelModel.Gpt4o20241120,
                "gpt-4o-2024-11-20:eastus" => EvalOpenAIModelModel.Gpt4o20241120_eastus,
                "gpt-4o-2024-11-20:eastus2" => EvalOpenAIModelModel.Gpt4o20241120_eastus2,
                "gpt-4o-2024-11-20:germanywestcentral" => EvalOpenAIModelModel.Gpt4o20241120_germanywestcentral,
                "gpt-4o-2024-11-20:polandcentral" => EvalOpenAIModelModel.Gpt4o20241120_polandcentral,
                "gpt-4o-2024-11-20:southcentralus" => EvalOpenAIModelModel.Gpt4o20241120_southcentralus,
                "gpt-4o-2024-11-20:spaincentral" => EvalOpenAIModelModel.Gpt4o20241120_spaincentral,
                "gpt-4o-2024-11-20:swedencentral" => EvalOpenAIModelModel.Gpt4o20241120_swedencentral,
                "gpt-4o-2024-11-20:westeurope" => EvalOpenAIModelModel.Gpt4o20241120_westeurope,
                "gpt-4o-2024-11-20:westus" => EvalOpenAIModelModel.Gpt4o20241120_westus,
                "gpt-4o-2024-11-20:westus3" => EvalOpenAIModelModel.Gpt4o20241120_westus3,
                "gpt-4o-mini" => EvalOpenAIModelModel.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => EvalOpenAIModelModel.Gpt4oMini20240718,
                "gpt-4o-mini-2024-07-18:eastus" => EvalOpenAIModelModel.Gpt4oMini20240718_eastus,
                "gpt-4o-mini-2024-07-18:eastus2" => EvalOpenAIModelModel.Gpt4oMini20240718_eastus2,
                "gpt-4o-mini-2024-07-18:northcentralus" => EvalOpenAIModelModel.Gpt4oMini20240718_northcentralus,
                "gpt-4o-mini-2024-07-18:southcentralus" => EvalOpenAIModelModel.Gpt4oMini20240718_southcentralus,
                "gpt-4o-mini-2024-07-18:westus" => EvalOpenAIModelModel.Gpt4oMini20240718_westus,
                "gpt-4o-mini-2024-07-18:westus3" => EvalOpenAIModelModel.Gpt4oMini20240718_westus3,
                "gpt-5" => EvalOpenAIModelModel.Gpt5,
                "gpt-5-chat-latest" => EvalOpenAIModelModel.Gpt5ChatLatest,
                "gpt-5-mini" => EvalOpenAIModelModel.Gpt5Mini,
                "gpt-5-nano" => EvalOpenAIModelModel.Gpt5Nano,
                "gpt-5.1" => EvalOpenAIModelModel.Gpt51,
                "gpt-5.1-chat-latest" => EvalOpenAIModelModel.Gpt51ChatLatest,
                "gpt-5.2" => EvalOpenAIModelModel.Gpt52,
                "gpt-5.2-chat-latest" => EvalOpenAIModelModel.Gpt52ChatLatest,
                "o1-mini" => EvalOpenAIModelModel.O1Mini,
                "o1-mini-2024-09-12" => EvalOpenAIModelModel.O1Mini20240912,
                "o3" => EvalOpenAIModelModel.O3,
                "o3-mini" => EvalOpenAIModelModel.O3Mini,
                "o4-mini" => EvalOpenAIModelModel.O4Mini,
                _ => null,
            };
        }
    }
}