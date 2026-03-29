//HintName: G.Models.ProviderName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderName
    {
        /// <summary>
        /// 
        /// </summary>
        Ai21,
        /// <summary>
        /// 
        /// </summary>
        AionLabs,
        /// <summary>
        /// 
        /// </summary>
        AkashML,
        /// <summary>
        /// 
        /// </summary>
        Alibaba,
        /// <summary>
        /// 
        /// </summary>
        AmazonBedrock,
        /// <summary>
        /// 
        /// </summary>
        AmazonNova,
        /// <summary>
        /// 
        /// </summary>
        Ambient,
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        ArceeAi,
        /// <summary>
        /// 
        /// </summary>
        AtlasCloud,
        /// <summary>
        /// 
        /// </summary>
        Avian,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        BaseTen,
        /// <summary>
        /// 
        /// </summary>
        BlackForestLabs,
        /// <summary>
        /// 
        /// </summary>
        BytePlus,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Chutes,
        /// <summary>
        /// 
        /// </summary>
        Cirrascale,
        /// <summary>
        /// 
        /// </summary>
        Clarifai,
        /// <summary>
        /// 
        /// </summary>
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        Crusoe,
        /// <summary>
        /// 
        /// </summary>
        DeepInfra,
        /// <summary>
        /// 
        /// </summary>
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        FakeProvider,
        /// <summary>
        /// 
        /// </summary>
        Featherless,
        /// <summary>
        /// 
        /// </summary>
        Fireworks,
        /// <summary>
        /// 
        /// </summary>
        Friendli,
        /// <summary>
        /// 
        /// </summary>
        GMICloud,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        GoogleAiStudio,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Hyperbolic,
        /// <summary>
        /// 
        /// </summary>
        Inception,
        /// <summary>
        /// 
        /// </summary>
        Inceptron,
        /// <summary>
        /// 
        /// </summary>
        InferenceNet,
        /// <summary>
        /// 
        /// </summary>
        Infermatic,
        /// <summary>
        /// 
        /// </summary>
        Inflection,
        /// <summary>
        /// 
        /// </summary>
        IoNet,
        /// <summary>
        /// 
        /// </summary>
        Ionstream,
        /// <summary>
        /// 
        /// </summary>
        Liquid,
        /// <summary>
        /// 
        /// </summary>
        Mancer2,
        /// <summary>
        /// 
        /// </summary>
        Mara,
        /// <summary>
        /// 
        /// </summary>
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        ModelRun,
        /// <summary>
        /// 
        /// </summary>
        Modular,
        /// <summary>
        /// 
        /// </summary>
        MoonshotAi,
        /// <summary>
        /// 
        /// </summary>
        Morph,
        /// <summary>
        /// 
        /// </summary>
        NCompass,
        /// <summary>
        /// 
        /// </summary>
        Nebius,
        /// <summary>
        /// 
        /// </summary>
        NextBit,
        /// <summary>
        /// 
        /// </summary>
        Novita,
        /// <summary>
        /// 
        /// </summary>
        Nvidia,
        /// <summary>
        /// 
        /// </summary>
        OpenAI,
        /// <summary>
        /// 
        /// </summary>
        OpenInference,
        /// <summary>
        /// 
        /// </summary>
        Parasail,
        /// <summary>
        /// 
        /// </summary>
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        Phala,
        /// <summary>
        /// 
        /// </summary>
        Reka,
        /// <summary>
        /// 
        /// </summary>
        Relace,
        /// <summary>
        /// 
        /// </summary>
        SambaNova,
        /// <summary>
        /// 
        /// </summary>
        Seed,
        /// <summary>
        /// 
        /// </summary>
        SiliconFlow,
        /// <summary>
        /// 
        /// </summary>
        Sourceful,
        /// <summary>
        /// 
        /// </summary>
        Stealth,
        /// <summary>
        /// 
        /// </summary>
        StepFun,
        /// <summary>
        /// 
        /// </summary>
        StreamLake,
        /// <summary>
        /// 
        /// </summary>
        Switchpoint,
        /// <summary>
        /// 
        /// </summary>
        Together,
        /// <summary>
        /// 
        /// </summary>
        Upstage,
        /// <summary>
        /// 
        /// </summary>
        Venice,
        /// <summary>
        /// 
        /// </summary>
        WandB,
        /// <summary>
        /// 
        /// </summary>
        Xiaomi,
        /// <summary>
        /// 
        /// </summary>
        ZAi,
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderName value)
        {
            return value switch
            {
                ProviderName.Ai21 => "AI21",
                ProviderName.AionLabs => "AionLabs",
                ProviderName.AkashML => "AkashML",
                ProviderName.Alibaba => "Alibaba",
                ProviderName.AmazonBedrock => "Amazon Bedrock",
                ProviderName.AmazonNova => "Amazon Nova",
                ProviderName.Ambient => "Ambient",
                ProviderName.Anthropic => "Anthropic",
                ProviderName.ArceeAi => "Arcee AI",
                ProviderName.AtlasCloud => "AtlasCloud",
                ProviderName.Avian => "Avian",
                ProviderName.Azure => "Azure",
                ProviderName.BaseTen => "BaseTen",
                ProviderName.BlackForestLabs => "Black Forest Labs",
                ProviderName.BytePlus => "BytePlus",
                ProviderName.Cerebras => "Cerebras",
                ProviderName.Chutes => "Chutes",
                ProviderName.Cirrascale => "Cirrascale",
                ProviderName.Clarifai => "Clarifai",
                ProviderName.Cloudflare => "Cloudflare",
                ProviderName.Cohere => "Cohere",
                ProviderName.Crusoe => "Crusoe",
                ProviderName.DeepInfra => "DeepInfra",
                ProviderName.DeepSeek => "DeepSeek",
                ProviderName.FakeProvider => "FakeProvider",
                ProviderName.Featherless => "Featherless",
                ProviderName.Fireworks => "Fireworks",
                ProviderName.Friendli => "Friendli",
                ProviderName.GMICloud => "GMICloud",
                ProviderName.Google => "Google",
                ProviderName.GoogleAiStudio => "Google AI Studio",
                ProviderName.Groq => "Groq",
                ProviderName.Hyperbolic => "Hyperbolic",
                ProviderName.Inception => "Inception",
                ProviderName.Inceptron => "Inceptron",
                ProviderName.InferenceNet => "InferenceNet",
                ProviderName.Infermatic => "Infermatic",
                ProviderName.Inflection => "Inflection",
                ProviderName.IoNet => "Io Net",
                ProviderName.Ionstream => "Ionstream",
                ProviderName.Liquid => "Liquid",
                ProviderName.Mancer2 => "Mancer 2",
                ProviderName.Mara => "Mara",
                ProviderName.Minimax => "Minimax",
                ProviderName.Mistral => "Mistral",
                ProviderName.ModelRun => "ModelRun",
                ProviderName.Modular => "Modular",
                ProviderName.MoonshotAi => "Moonshot AI",
                ProviderName.Morph => "Morph",
                ProviderName.NCompass => "NCompass",
                ProviderName.Nebius => "Nebius",
                ProviderName.NextBit => "NextBit",
                ProviderName.Novita => "Novita",
                ProviderName.Nvidia => "Nvidia",
                ProviderName.OpenAI => "OpenAI",
                ProviderName.OpenInference => "OpenInference",
                ProviderName.Parasail => "Parasail",
                ProviderName.Perplexity => "Perplexity",
                ProviderName.Phala => "Phala",
                ProviderName.Reka => "Reka",
                ProviderName.Relace => "Relace",
                ProviderName.SambaNova => "SambaNova",
                ProviderName.Seed => "Seed",
                ProviderName.SiliconFlow => "SiliconFlow",
                ProviderName.Sourceful => "Sourceful",
                ProviderName.Stealth => "Stealth",
                ProviderName.StepFun => "StepFun",
                ProviderName.StreamLake => "StreamLake",
                ProviderName.Switchpoint => "Switchpoint",
                ProviderName.Together => "Together",
                ProviderName.Upstage => "Upstage",
                ProviderName.Venice => "Venice",
                ProviderName.WandB => "WandB",
                ProviderName.Xiaomi => "Xiaomi",
                ProviderName.ZAi => "Z.AI",
                ProviderName.Xai => "xAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderName? ToEnum(string value)
        {
            return value switch
            {
                "AI21" => ProviderName.Ai21,
                "AionLabs" => ProviderName.AionLabs,
                "AkashML" => ProviderName.AkashML,
                "Alibaba" => ProviderName.Alibaba,
                "Amazon Bedrock" => ProviderName.AmazonBedrock,
                "Amazon Nova" => ProviderName.AmazonNova,
                "Ambient" => ProviderName.Ambient,
                "Anthropic" => ProviderName.Anthropic,
                "Arcee AI" => ProviderName.ArceeAi,
                "AtlasCloud" => ProviderName.AtlasCloud,
                "Avian" => ProviderName.Avian,
                "Azure" => ProviderName.Azure,
                "BaseTen" => ProviderName.BaseTen,
                "Black Forest Labs" => ProviderName.BlackForestLabs,
                "BytePlus" => ProviderName.BytePlus,
                "Cerebras" => ProviderName.Cerebras,
                "Chutes" => ProviderName.Chutes,
                "Cirrascale" => ProviderName.Cirrascale,
                "Clarifai" => ProviderName.Clarifai,
                "Cloudflare" => ProviderName.Cloudflare,
                "Cohere" => ProviderName.Cohere,
                "Crusoe" => ProviderName.Crusoe,
                "DeepInfra" => ProviderName.DeepInfra,
                "DeepSeek" => ProviderName.DeepSeek,
                "FakeProvider" => ProviderName.FakeProvider,
                "Featherless" => ProviderName.Featherless,
                "Fireworks" => ProviderName.Fireworks,
                "Friendli" => ProviderName.Friendli,
                "GMICloud" => ProviderName.GMICloud,
                "Google" => ProviderName.Google,
                "Google AI Studio" => ProviderName.GoogleAiStudio,
                "Groq" => ProviderName.Groq,
                "Hyperbolic" => ProviderName.Hyperbolic,
                "Inception" => ProviderName.Inception,
                "Inceptron" => ProviderName.Inceptron,
                "InferenceNet" => ProviderName.InferenceNet,
                "Infermatic" => ProviderName.Infermatic,
                "Inflection" => ProviderName.Inflection,
                "Io Net" => ProviderName.IoNet,
                "Ionstream" => ProviderName.Ionstream,
                "Liquid" => ProviderName.Liquid,
                "Mancer 2" => ProviderName.Mancer2,
                "Mara" => ProviderName.Mara,
                "Minimax" => ProviderName.Minimax,
                "Mistral" => ProviderName.Mistral,
                "ModelRun" => ProviderName.ModelRun,
                "Modular" => ProviderName.Modular,
                "Moonshot AI" => ProviderName.MoonshotAi,
                "Morph" => ProviderName.Morph,
                "NCompass" => ProviderName.NCompass,
                "Nebius" => ProviderName.Nebius,
                "NextBit" => ProviderName.NextBit,
                "Novita" => ProviderName.Novita,
                "Nvidia" => ProviderName.Nvidia,
                "OpenAI" => ProviderName.OpenAI,
                "OpenInference" => ProviderName.OpenInference,
                "Parasail" => ProviderName.Parasail,
                "Perplexity" => ProviderName.Perplexity,
                "Phala" => ProviderName.Phala,
                "Reka" => ProviderName.Reka,
                "Relace" => ProviderName.Relace,
                "SambaNova" => ProviderName.SambaNova,
                "Seed" => ProviderName.Seed,
                "SiliconFlow" => ProviderName.SiliconFlow,
                "Sourceful" => ProviderName.Sourceful,
                "Stealth" => ProviderName.Stealth,
                "StepFun" => ProviderName.StepFun,
                "StreamLake" => ProviderName.StreamLake,
                "Switchpoint" => ProviderName.Switchpoint,
                "Together" => ProviderName.Together,
                "Upstage" => ProviderName.Upstage,
                "Venice" => ProviderName.Venice,
                "WandB" => ProviderName.WandB,
                "Xiaomi" => ProviderName.Xiaomi,
                "Z.AI" => ProviderName.ZAi,
                "xAI" => ProviderName.Xai,
                _ => null,
            };
        }
    }
}