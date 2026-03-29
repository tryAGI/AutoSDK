//HintName: G.Models.WorkflowOpenAIModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the OpenAI model that will be used.<br/>
    /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
    /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
    /// </summary>
    public enum WorkflowOpenAIModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        Chatgpt4oLatest,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0125,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0125_canadaeast,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0125_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0125_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0613,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo1106,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo1106_canadaeast,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo1106_westus,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo16k,
        /// <summary>
        /// 
        /// </summary>
        Gpt4,
        /// <summary>
        /// 
        /// </summary>
        Gpt40125Preview,
        /// <summary>
        /// 
        /// </summary>
        Gpt40125Preview_eastus,
        /// <summary>
        /// 
        /// </summary>
        Gpt40125Preview_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt40125Preview_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt40613,
        /// <summary>
        /// 
        /// </summary>
        Gpt40613_canadaeast,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview_australiaeast,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview_canadaeast,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview_france,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview_india,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview_norway,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview_swedencentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview_uk,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview_westus,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview_westus3,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo20240409,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo20240409_eastus2,
        /// <summary>
        /// 
        /// </summary>
        Gpt4TurboPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_eastus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_eastus2,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_germanywestcentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_polandcentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_spaincentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_westeurope,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_westus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414_westus3,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_eastus,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_eastus2,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_germanywestcentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_polandcentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_spaincentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_westeurope,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_westus,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414_westus3,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano20250414,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano20250414_eastus2,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano20250414_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano20250414_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano20250414_westus,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano20250414_westus3,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240513,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240513_eastus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240513_eastus2,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240513_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240513_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240513_westus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240513_westus3,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240806,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240806_eastus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240806_eastus2,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240806_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240806_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240806_westus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240806_westus3,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_eastus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_eastus2,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_germanywestcentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_polandcentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_spaincentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_swedencentral,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_westeurope,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_westus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120_westus3,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718_eastus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718_eastus2,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718_northcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718_southcentralus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718_westus,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718_westus3,
        /// <summary>
        /// 
        /// </summary>
        Gpt5,
        /// <summary>
        /// 
        /// </summary>
        Gpt5ChatLatest,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt51,
        /// <summary>
        /// 
        /// </summary>
        Gpt51ChatLatest,
        /// <summary>
        /// 
        /// </summary>
        Gpt52,
        /// <summary>
        /// 
        /// </summary>
        Gpt52ChatLatest,
        /// <summary>
        /// 
        /// </summary>
        O1Mini,
        /// <summary>
        /// 
        /// </summary>
        O1Mini20240912,
        /// <summary>
        /// 
        /// </summary>
        O3,
        /// <summary>
        /// 
        /// </summary>
        O3Mini,
        /// <summary>
        /// 
        /// </summary>
        O4Mini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowOpenAIModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowOpenAIModelModel value)
        {
            return value switch
            {
                WorkflowOpenAIModelModel.Chatgpt4oLatest => "chatgpt-4o-latest",
                WorkflowOpenAIModelModel.Gpt35Turbo => "gpt-3.5-turbo",
                WorkflowOpenAIModelModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                WorkflowOpenAIModelModel.Gpt35Turbo0125_canadaeast => "gpt-3.5-turbo-0125:canadaeast",
                WorkflowOpenAIModelModel.Gpt35Turbo0125_northcentralus => "gpt-3.5-turbo-0125:northcentralus",
                WorkflowOpenAIModelModel.Gpt35Turbo0125_southcentralus => "gpt-3.5-turbo-0125:southcentralus",
                WorkflowOpenAIModelModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                WorkflowOpenAIModelModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                WorkflowOpenAIModelModel.Gpt35Turbo1106_canadaeast => "gpt-3.5-turbo-1106:canadaeast",
                WorkflowOpenAIModelModel.Gpt35Turbo1106_westus => "gpt-3.5-turbo-1106:westus",
                WorkflowOpenAIModelModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                WorkflowOpenAIModelModel.Gpt4 => "gpt-4",
                WorkflowOpenAIModelModel.Gpt40125Preview => "gpt-4-0125-preview",
                WorkflowOpenAIModelModel.Gpt40125Preview_eastus => "gpt-4-0125-preview:eastus",
                WorkflowOpenAIModelModel.Gpt40125Preview_northcentralus => "gpt-4-0125-preview:northcentralus",
                WorkflowOpenAIModelModel.Gpt40125Preview_southcentralus => "gpt-4-0125-preview:southcentralus",
                WorkflowOpenAIModelModel.Gpt40613 => "gpt-4-0613",
                WorkflowOpenAIModelModel.Gpt40613_canadaeast => "gpt-4-0613:canadaeast",
                WorkflowOpenAIModelModel.Gpt41106Preview => "gpt-4-1106-preview",
                WorkflowOpenAIModelModel.Gpt41106Preview_australiaeast => "gpt-4-1106-preview:australiaeast",
                WorkflowOpenAIModelModel.Gpt41106Preview_canadaeast => "gpt-4-1106-preview:canadaeast",
                WorkflowOpenAIModelModel.Gpt41106Preview_france => "gpt-4-1106-preview:france",
                WorkflowOpenAIModelModel.Gpt41106Preview_india => "gpt-4-1106-preview:india",
                WorkflowOpenAIModelModel.Gpt41106Preview_norway => "gpt-4-1106-preview:norway",
                WorkflowOpenAIModelModel.Gpt41106Preview_swedencentral => "gpt-4-1106-preview:swedencentral",
                WorkflowOpenAIModelModel.Gpt41106Preview_uk => "gpt-4-1106-preview:uk",
                WorkflowOpenAIModelModel.Gpt41106Preview_westus => "gpt-4-1106-preview:westus",
                WorkflowOpenAIModelModel.Gpt41106Preview_westus3 => "gpt-4-1106-preview:westus3",
                WorkflowOpenAIModelModel.Gpt4Turbo => "gpt-4-turbo",
                WorkflowOpenAIModelModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                WorkflowOpenAIModelModel.Gpt4Turbo20240409_eastus2 => "gpt-4-turbo-2024-04-09:eastus2",
                WorkflowOpenAIModelModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                WorkflowOpenAIModelModel.Gpt41 => "gpt-4.1",
                WorkflowOpenAIModelModel.Gpt4120250414 => "gpt-4.1-2025-04-14",
                WorkflowOpenAIModelModel.Gpt4120250414_eastus => "gpt-4.1-2025-04-14:eastus",
                WorkflowOpenAIModelModel.Gpt4120250414_eastus2 => "gpt-4.1-2025-04-14:eastus2",
                WorkflowOpenAIModelModel.Gpt4120250414_germanywestcentral => "gpt-4.1-2025-04-14:germanywestcentral",
                WorkflowOpenAIModelModel.Gpt4120250414_northcentralus => "gpt-4.1-2025-04-14:northcentralus",
                WorkflowOpenAIModelModel.Gpt4120250414_polandcentral => "gpt-4.1-2025-04-14:polandcentral",
                WorkflowOpenAIModelModel.Gpt4120250414_southcentralus => "gpt-4.1-2025-04-14:southcentralus",
                WorkflowOpenAIModelModel.Gpt4120250414_spaincentral => "gpt-4.1-2025-04-14:spaincentral",
                WorkflowOpenAIModelModel.Gpt4120250414_westeurope => "gpt-4.1-2025-04-14:westeurope",
                WorkflowOpenAIModelModel.Gpt4120250414_westus => "gpt-4.1-2025-04-14:westus",
                WorkflowOpenAIModelModel.Gpt4120250414_westus3 => "gpt-4.1-2025-04-14:westus3",
                WorkflowOpenAIModelModel.Gpt41Mini => "gpt-4.1-mini",
                WorkflowOpenAIModelModel.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_eastus => "gpt-4.1-mini-2025-04-14:eastus",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_eastus2 => "gpt-4.1-mini-2025-04-14:eastus2",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_germanywestcentral => "gpt-4.1-mini-2025-04-14:germanywestcentral",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_northcentralus => "gpt-4.1-mini-2025-04-14:northcentralus",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_polandcentral => "gpt-4.1-mini-2025-04-14:polandcentral",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_southcentralus => "gpt-4.1-mini-2025-04-14:southcentralus",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_spaincentral => "gpt-4.1-mini-2025-04-14:spaincentral",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_westeurope => "gpt-4.1-mini-2025-04-14:westeurope",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_westus => "gpt-4.1-mini-2025-04-14:westus",
                WorkflowOpenAIModelModel.Gpt41Mini20250414_westus3 => "gpt-4.1-mini-2025-04-14:westus3",
                WorkflowOpenAIModelModel.Gpt41Nano => "gpt-4.1-nano",
                WorkflowOpenAIModelModel.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                WorkflowOpenAIModelModel.Gpt41Nano20250414_eastus2 => "gpt-4.1-nano-2025-04-14:eastus2",
                WorkflowOpenAIModelModel.Gpt41Nano20250414_northcentralus => "gpt-4.1-nano-2025-04-14:northcentralus",
                WorkflowOpenAIModelModel.Gpt41Nano20250414_southcentralus => "gpt-4.1-nano-2025-04-14:southcentralus",
                WorkflowOpenAIModelModel.Gpt41Nano20250414_westus => "gpt-4.1-nano-2025-04-14:westus",
                WorkflowOpenAIModelModel.Gpt41Nano20250414_westus3 => "gpt-4.1-nano-2025-04-14:westus3",
                WorkflowOpenAIModelModel.Gpt4o => "gpt-4o",
                WorkflowOpenAIModelModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                WorkflowOpenAIModelModel.Gpt4o20240513_eastus => "gpt-4o-2024-05-13:eastus",
                WorkflowOpenAIModelModel.Gpt4o20240513_eastus2 => "gpt-4o-2024-05-13:eastus2",
                WorkflowOpenAIModelModel.Gpt4o20240513_northcentralus => "gpt-4o-2024-05-13:northcentralus",
                WorkflowOpenAIModelModel.Gpt4o20240513_southcentralus => "gpt-4o-2024-05-13:southcentralus",
                WorkflowOpenAIModelModel.Gpt4o20240513_westus => "gpt-4o-2024-05-13:westus",
                WorkflowOpenAIModelModel.Gpt4o20240513_westus3 => "gpt-4o-2024-05-13:westus3",
                WorkflowOpenAIModelModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                WorkflowOpenAIModelModel.Gpt4o20240806_eastus => "gpt-4o-2024-08-06:eastus",
                WorkflowOpenAIModelModel.Gpt4o20240806_eastus2 => "gpt-4o-2024-08-06:eastus2",
                WorkflowOpenAIModelModel.Gpt4o20240806_northcentralus => "gpt-4o-2024-08-06:northcentralus",
                WorkflowOpenAIModelModel.Gpt4o20240806_southcentralus => "gpt-4o-2024-08-06:southcentralus",
                WorkflowOpenAIModelModel.Gpt4o20240806_westus => "gpt-4o-2024-08-06:westus",
                WorkflowOpenAIModelModel.Gpt4o20240806_westus3 => "gpt-4o-2024-08-06:westus3",
                WorkflowOpenAIModelModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                WorkflowOpenAIModelModel.Gpt4o20241120_eastus => "gpt-4o-2024-11-20:eastus",
                WorkflowOpenAIModelModel.Gpt4o20241120_eastus2 => "gpt-4o-2024-11-20:eastus2",
                WorkflowOpenAIModelModel.Gpt4o20241120_germanywestcentral => "gpt-4o-2024-11-20:germanywestcentral",
                WorkflowOpenAIModelModel.Gpt4o20241120_polandcentral => "gpt-4o-2024-11-20:polandcentral",
                WorkflowOpenAIModelModel.Gpt4o20241120_southcentralus => "gpt-4o-2024-11-20:southcentralus",
                WorkflowOpenAIModelModel.Gpt4o20241120_spaincentral => "gpt-4o-2024-11-20:spaincentral",
                WorkflowOpenAIModelModel.Gpt4o20241120_swedencentral => "gpt-4o-2024-11-20:swedencentral",
                WorkflowOpenAIModelModel.Gpt4o20241120_westeurope => "gpt-4o-2024-11-20:westeurope",
                WorkflowOpenAIModelModel.Gpt4o20241120_westus => "gpt-4o-2024-11-20:westus",
                WorkflowOpenAIModelModel.Gpt4o20241120_westus3 => "gpt-4o-2024-11-20:westus3",
                WorkflowOpenAIModelModel.Gpt4oMini => "gpt-4o-mini",
                WorkflowOpenAIModelModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                WorkflowOpenAIModelModel.Gpt4oMini20240718_eastus => "gpt-4o-mini-2024-07-18:eastus",
                WorkflowOpenAIModelModel.Gpt4oMini20240718_eastus2 => "gpt-4o-mini-2024-07-18:eastus2",
                WorkflowOpenAIModelModel.Gpt4oMini20240718_northcentralus => "gpt-4o-mini-2024-07-18:northcentralus",
                WorkflowOpenAIModelModel.Gpt4oMini20240718_southcentralus => "gpt-4o-mini-2024-07-18:southcentralus",
                WorkflowOpenAIModelModel.Gpt4oMini20240718_westus => "gpt-4o-mini-2024-07-18:westus",
                WorkflowOpenAIModelModel.Gpt4oMini20240718_westus3 => "gpt-4o-mini-2024-07-18:westus3",
                WorkflowOpenAIModelModel.Gpt5 => "gpt-5",
                WorkflowOpenAIModelModel.Gpt5ChatLatest => "gpt-5-chat-latest",
                WorkflowOpenAIModelModel.Gpt5Mini => "gpt-5-mini",
                WorkflowOpenAIModelModel.Gpt5Nano => "gpt-5-nano",
                WorkflowOpenAIModelModel.Gpt51 => "gpt-5.1",
                WorkflowOpenAIModelModel.Gpt51ChatLatest => "gpt-5.1-chat-latest",
                WorkflowOpenAIModelModel.Gpt52 => "gpt-5.2",
                WorkflowOpenAIModelModel.Gpt52ChatLatest => "gpt-5.2-chat-latest",
                WorkflowOpenAIModelModel.O1Mini => "o1-mini",
                WorkflowOpenAIModelModel.O1Mini20240912 => "o1-mini-2024-09-12",
                WorkflowOpenAIModelModel.O3 => "o3",
                WorkflowOpenAIModelModel.O3Mini => "o3-mini",
                WorkflowOpenAIModelModel.O4Mini => "o4-mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowOpenAIModelModel? ToEnum(string value)
        {
            return value switch
            {
                "chatgpt-4o-latest" => WorkflowOpenAIModelModel.Chatgpt4oLatest,
                "gpt-3.5-turbo" => WorkflowOpenAIModelModel.Gpt35Turbo,
                "gpt-3.5-turbo-0125" => WorkflowOpenAIModelModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-0125:canadaeast" => WorkflowOpenAIModelModel.Gpt35Turbo0125_canadaeast,
                "gpt-3.5-turbo-0125:northcentralus" => WorkflowOpenAIModelModel.Gpt35Turbo0125_northcentralus,
                "gpt-3.5-turbo-0125:southcentralus" => WorkflowOpenAIModelModel.Gpt35Turbo0125_southcentralus,
                "gpt-3.5-turbo-0613" => WorkflowOpenAIModelModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => WorkflowOpenAIModelModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-1106:canadaeast" => WorkflowOpenAIModelModel.Gpt35Turbo1106_canadaeast,
                "gpt-3.5-turbo-1106:westus" => WorkflowOpenAIModelModel.Gpt35Turbo1106_westus,
                "gpt-3.5-turbo-16k" => WorkflowOpenAIModelModel.Gpt35Turbo16k,
                "gpt-4" => WorkflowOpenAIModelModel.Gpt4,
                "gpt-4-0125-preview" => WorkflowOpenAIModelModel.Gpt40125Preview,
                "gpt-4-0125-preview:eastus" => WorkflowOpenAIModelModel.Gpt40125Preview_eastus,
                "gpt-4-0125-preview:northcentralus" => WorkflowOpenAIModelModel.Gpt40125Preview_northcentralus,
                "gpt-4-0125-preview:southcentralus" => WorkflowOpenAIModelModel.Gpt40125Preview_southcentralus,
                "gpt-4-0613" => WorkflowOpenAIModelModel.Gpt40613,
                "gpt-4-0613:canadaeast" => WorkflowOpenAIModelModel.Gpt40613_canadaeast,
                "gpt-4-1106-preview" => WorkflowOpenAIModelModel.Gpt41106Preview,
                "gpt-4-1106-preview:australiaeast" => WorkflowOpenAIModelModel.Gpt41106Preview_australiaeast,
                "gpt-4-1106-preview:canadaeast" => WorkflowOpenAIModelModel.Gpt41106Preview_canadaeast,
                "gpt-4-1106-preview:france" => WorkflowOpenAIModelModel.Gpt41106Preview_france,
                "gpt-4-1106-preview:india" => WorkflowOpenAIModelModel.Gpt41106Preview_india,
                "gpt-4-1106-preview:norway" => WorkflowOpenAIModelModel.Gpt41106Preview_norway,
                "gpt-4-1106-preview:swedencentral" => WorkflowOpenAIModelModel.Gpt41106Preview_swedencentral,
                "gpt-4-1106-preview:uk" => WorkflowOpenAIModelModel.Gpt41106Preview_uk,
                "gpt-4-1106-preview:westus" => WorkflowOpenAIModelModel.Gpt41106Preview_westus,
                "gpt-4-1106-preview:westus3" => WorkflowOpenAIModelModel.Gpt41106Preview_westus3,
                "gpt-4-turbo" => WorkflowOpenAIModelModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => WorkflowOpenAIModelModel.Gpt4Turbo20240409,
                "gpt-4-turbo-2024-04-09:eastus2" => WorkflowOpenAIModelModel.Gpt4Turbo20240409_eastus2,
                "gpt-4-turbo-preview" => WorkflowOpenAIModelModel.Gpt4TurboPreview,
                "gpt-4.1" => WorkflowOpenAIModelModel.Gpt41,
                "gpt-4.1-2025-04-14" => WorkflowOpenAIModelModel.Gpt4120250414,
                "gpt-4.1-2025-04-14:eastus" => WorkflowOpenAIModelModel.Gpt4120250414_eastus,
                "gpt-4.1-2025-04-14:eastus2" => WorkflowOpenAIModelModel.Gpt4120250414_eastus2,
                "gpt-4.1-2025-04-14:germanywestcentral" => WorkflowOpenAIModelModel.Gpt4120250414_germanywestcentral,
                "gpt-4.1-2025-04-14:northcentralus" => WorkflowOpenAIModelModel.Gpt4120250414_northcentralus,
                "gpt-4.1-2025-04-14:polandcentral" => WorkflowOpenAIModelModel.Gpt4120250414_polandcentral,
                "gpt-4.1-2025-04-14:southcentralus" => WorkflowOpenAIModelModel.Gpt4120250414_southcentralus,
                "gpt-4.1-2025-04-14:spaincentral" => WorkflowOpenAIModelModel.Gpt4120250414_spaincentral,
                "gpt-4.1-2025-04-14:westeurope" => WorkflowOpenAIModelModel.Gpt4120250414_westeurope,
                "gpt-4.1-2025-04-14:westus" => WorkflowOpenAIModelModel.Gpt4120250414_westus,
                "gpt-4.1-2025-04-14:westus3" => WorkflowOpenAIModelModel.Gpt4120250414_westus3,
                "gpt-4.1-mini" => WorkflowOpenAIModelModel.Gpt41Mini,
                "gpt-4.1-mini-2025-04-14" => WorkflowOpenAIModelModel.Gpt41Mini20250414,
                "gpt-4.1-mini-2025-04-14:eastus" => WorkflowOpenAIModelModel.Gpt41Mini20250414_eastus,
                "gpt-4.1-mini-2025-04-14:eastus2" => WorkflowOpenAIModelModel.Gpt41Mini20250414_eastus2,
                "gpt-4.1-mini-2025-04-14:germanywestcentral" => WorkflowOpenAIModelModel.Gpt41Mini20250414_germanywestcentral,
                "gpt-4.1-mini-2025-04-14:northcentralus" => WorkflowOpenAIModelModel.Gpt41Mini20250414_northcentralus,
                "gpt-4.1-mini-2025-04-14:polandcentral" => WorkflowOpenAIModelModel.Gpt41Mini20250414_polandcentral,
                "gpt-4.1-mini-2025-04-14:southcentralus" => WorkflowOpenAIModelModel.Gpt41Mini20250414_southcentralus,
                "gpt-4.1-mini-2025-04-14:spaincentral" => WorkflowOpenAIModelModel.Gpt41Mini20250414_spaincentral,
                "gpt-4.1-mini-2025-04-14:westeurope" => WorkflowOpenAIModelModel.Gpt41Mini20250414_westeurope,
                "gpt-4.1-mini-2025-04-14:westus" => WorkflowOpenAIModelModel.Gpt41Mini20250414_westus,
                "gpt-4.1-mini-2025-04-14:westus3" => WorkflowOpenAIModelModel.Gpt41Mini20250414_westus3,
                "gpt-4.1-nano" => WorkflowOpenAIModelModel.Gpt41Nano,
                "gpt-4.1-nano-2025-04-14" => WorkflowOpenAIModelModel.Gpt41Nano20250414,
                "gpt-4.1-nano-2025-04-14:eastus2" => WorkflowOpenAIModelModel.Gpt41Nano20250414_eastus2,
                "gpt-4.1-nano-2025-04-14:northcentralus" => WorkflowOpenAIModelModel.Gpt41Nano20250414_northcentralus,
                "gpt-4.1-nano-2025-04-14:southcentralus" => WorkflowOpenAIModelModel.Gpt41Nano20250414_southcentralus,
                "gpt-4.1-nano-2025-04-14:westus" => WorkflowOpenAIModelModel.Gpt41Nano20250414_westus,
                "gpt-4.1-nano-2025-04-14:westus3" => WorkflowOpenAIModelModel.Gpt41Nano20250414_westus3,
                "gpt-4o" => WorkflowOpenAIModelModel.Gpt4o,
                "gpt-4o-2024-05-13" => WorkflowOpenAIModelModel.Gpt4o20240513,
                "gpt-4o-2024-05-13:eastus" => WorkflowOpenAIModelModel.Gpt4o20240513_eastus,
                "gpt-4o-2024-05-13:eastus2" => WorkflowOpenAIModelModel.Gpt4o20240513_eastus2,
                "gpt-4o-2024-05-13:northcentralus" => WorkflowOpenAIModelModel.Gpt4o20240513_northcentralus,
                "gpt-4o-2024-05-13:southcentralus" => WorkflowOpenAIModelModel.Gpt4o20240513_southcentralus,
                "gpt-4o-2024-05-13:westus" => WorkflowOpenAIModelModel.Gpt4o20240513_westus,
                "gpt-4o-2024-05-13:westus3" => WorkflowOpenAIModelModel.Gpt4o20240513_westus3,
                "gpt-4o-2024-08-06" => WorkflowOpenAIModelModel.Gpt4o20240806,
                "gpt-4o-2024-08-06:eastus" => WorkflowOpenAIModelModel.Gpt4o20240806_eastus,
                "gpt-4o-2024-08-06:eastus2" => WorkflowOpenAIModelModel.Gpt4o20240806_eastus2,
                "gpt-4o-2024-08-06:northcentralus" => WorkflowOpenAIModelModel.Gpt4o20240806_northcentralus,
                "gpt-4o-2024-08-06:southcentralus" => WorkflowOpenAIModelModel.Gpt4o20240806_southcentralus,
                "gpt-4o-2024-08-06:westus" => WorkflowOpenAIModelModel.Gpt4o20240806_westus,
                "gpt-4o-2024-08-06:westus3" => WorkflowOpenAIModelModel.Gpt4o20240806_westus3,
                "gpt-4o-2024-11-20" => WorkflowOpenAIModelModel.Gpt4o20241120,
                "gpt-4o-2024-11-20:eastus" => WorkflowOpenAIModelModel.Gpt4o20241120_eastus,
                "gpt-4o-2024-11-20:eastus2" => WorkflowOpenAIModelModel.Gpt4o20241120_eastus2,
                "gpt-4o-2024-11-20:germanywestcentral" => WorkflowOpenAIModelModel.Gpt4o20241120_germanywestcentral,
                "gpt-4o-2024-11-20:polandcentral" => WorkflowOpenAIModelModel.Gpt4o20241120_polandcentral,
                "gpt-4o-2024-11-20:southcentralus" => WorkflowOpenAIModelModel.Gpt4o20241120_southcentralus,
                "gpt-4o-2024-11-20:spaincentral" => WorkflowOpenAIModelModel.Gpt4o20241120_spaincentral,
                "gpt-4o-2024-11-20:swedencentral" => WorkflowOpenAIModelModel.Gpt4o20241120_swedencentral,
                "gpt-4o-2024-11-20:westeurope" => WorkflowOpenAIModelModel.Gpt4o20241120_westeurope,
                "gpt-4o-2024-11-20:westus" => WorkflowOpenAIModelModel.Gpt4o20241120_westus,
                "gpt-4o-2024-11-20:westus3" => WorkflowOpenAIModelModel.Gpt4o20241120_westus3,
                "gpt-4o-mini" => WorkflowOpenAIModelModel.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => WorkflowOpenAIModelModel.Gpt4oMini20240718,
                "gpt-4o-mini-2024-07-18:eastus" => WorkflowOpenAIModelModel.Gpt4oMini20240718_eastus,
                "gpt-4o-mini-2024-07-18:eastus2" => WorkflowOpenAIModelModel.Gpt4oMini20240718_eastus2,
                "gpt-4o-mini-2024-07-18:northcentralus" => WorkflowOpenAIModelModel.Gpt4oMini20240718_northcentralus,
                "gpt-4o-mini-2024-07-18:southcentralus" => WorkflowOpenAIModelModel.Gpt4oMini20240718_southcentralus,
                "gpt-4o-mini-2024-07-18:westus" => WorkflowOpenAIModelModel.Gpt4oMini20240718_westus,
                "gpt-4o-mini-2024-07-18:westus3" => WorkflowOpenAIModelModel.Gpt4oMini20240718_westus3,
                "gpt-5" => WorkflowOpenAIModelModel.Gpt5,
                "gpt-5-chat-latest" => WorkflowOpenAIModelModel.Gpt5ChatLatest,
                "gpt-5-mini" => WorkflowOpenAIModelModel.Gpt5Mini,
                "gpt-5-nano" => WorkflowOpenAIModelModel.Gpt5Nano,
                "gpt-5.1" => WorkflowOpenAIModelModel.Gpt51,
                "gpt-5.1-chat-latest" => WorkflowOpenAIModelModel.Gpt51ChatLatest,
                "gpt-5.2" => WorkflowOpenAIModelModel.Gpt52,
                "gpt-5.2-chat-latest" => WorkflowOpenAIModelModel.Gpt52ChatLatest,
                "o1-mini" => WorkflowOpenAIModelModel.O1Mini,
                "o1-mini-2024-09-12" => WorkflowOpenAIModelModel.O1Mini20240912,
                "o3" => WorkflowOpenAIModelModel.O3,
                "o3-mini" => WorkflowOpenAIModelModel.O3Mini,
                "o4-mini" => WorkflowOpenAIModelModel.O4Mini,
                _ => null,
            };
        }
    }
}