//HintName: G.Models.AssistantCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantCredentialDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        AnthropicBedrock,
        /// <summary>
        /// 
        /// </summary>
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        AssemblyAi,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        ByoSipTrunk,
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        CustomCredential,
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Gcp,
        /// <summary>
        /// 
        /// </summary>
        GhlOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Gladia,
        /// <summary>
        /// 
        /// </summary>
        Gohighlevel,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Client,
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Hume,
        /// <summary>
        /// 
        /// </summary>
        InflectionAi,
        /// <summary>
        /// 
        /// </summary>
        Inworld,
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        Make,
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
        Neuphonic,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        PerplexityAi,
        /// <summary>
        /// 
        /// </summary>
        Playht,
        /// <summary>
        /// 
        /// </summary>
        RimeAi,
        /// <summary>
        /// 
        /// </summary>
        Runpod,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        SlackWebhook,
        /// <summary>
        /// 
        /// </summary>
        SlackOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        SmallestAi,
        /// <summary>
        /// 
        /// </summary>
        Soniox,
        /// <summary>
        /// 
        /// </summary>
        Speechmatics,
        /// <summary>
        /// 
        /// </summary>
        Supabase,
        /// <summary>
        /// 
        /// </summary>
        Tavus,
        /// <summary>
        /// 
        /// </summary>
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        Trieve,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Vonage,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Wellsaid,
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                AssistantCredentialDiscriminatorProvider.Anthropic => "anthropic",
                AssistantCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                AssistantCredentialDiscriminatorProvider.Anyscale => "anyscale",
                AssistantCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                AssistantCredentialDiscriminatorProvider.Azure => "azure",
                AssistantCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                AssistantCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                AssistantCredentialDiscriminatorProvider.Cartesia => "cartesia",
                AssistantCredentialDiscriminatorProvider.Cerebras => "cerebras",
                AssistantCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                AssistantCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                AssistantCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                AssistantCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                AssistantCredentialDiscriminatorProvider.Deepgram => "deepgram",
                AssistantCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                AssistantCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                AssistantCredentialDiscriminatorProvider.Email => "email",
                AssistantCredentialDiscriminatorProvider.Gcp => "gcp",
                AssistantCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                AssistantCredentialDiscriminatorProvider.Gladia => "gladia",
                AssistantCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                AssistantCredentialDiscriminatorProvider.Google => "google",
                AssistantCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                AssistantCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                AssistantCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                AssistantCredentialDiscriminatorProvider.Groq => "groq",
                AssistantCredentialDiscriminatorProvider.Hume => "hume",
                AssistantCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                AssistantCredentialDiscriminatorProvider.Inworld => "inworld",
                AssistantCredentialDiscriminatorProvider.Langfuse => "langfuse",
                AssistantCredentialDiscriminatorProvider.Lmnt => "lmnt",
                AssistantCredentialDiscriminatorProvider.Make => "make",
                AssistantCredentialDiscriminatorProvider.Minimax => "minimax",
                AssistantCredentialDiscriminatorProvider.Mistral => "mistral",
                AssistantCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                AssistantCredentialDiscriminatorProvider.Openai => "openai",
                AssistantCredentialDiscriminatorProvider.Openrouter => "openrouter",
                AssistantCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                AssistantCredentialDiscriminatorProvider.Playht => "playht",
                AssistantCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                AssistantCredentialDiscriminatorProvider.Runpod => "runpod",
                AssistantCredentialDiscriminatorProvider.S3 => "s3",
                AssistantCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                AssistantCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                AssistantCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                AssistantCredentialDiscriminatorProvider.Soniox => "soniox",
                AssistantCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                AssistantCredentialDiscriminatorProvider.Supabase => "supabase",
                AssistantCredentialDiscriminatorProvider.Tavus => "tavus",
                AssistantCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                AssistantCredentialDiscriminatorProvider.Trieve => "trieve",
                AssistantCredentialDiscriminatorProvider.Twilio => "twilio",
                AssistantCredentialDiscriminatorProvider.Vonage => "vonage",
                AssistantCredentialDiscriminatorProvider.Webhook => "webhook",
                AssistantCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                AssistantCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AssistantCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => AssistantCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => AssistantCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => AssistantCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => AssistantCredentialDiscriminatorProvider.Azure,
                "azure-openai" => AssistantCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => AssistantCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => AssistantCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => AssistantCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => AssistantCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => AssistantCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => AssistantCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => AssistantCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => AssistantCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => AssistantCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => AssistantCredentialDiscriminatorProvider.Elevenlabs,
                "email" => AssistantCredentialDiscriminatorProvider.Email,
                "gcp" => AssistantCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => AssistantCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => AssistantCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => AssistantCredentialDiscriminatorProvider.Gohighlevel,
                "google" => AssistantCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => AssistantCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => AssistantCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => AssistantCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => AssistantCredentialDiscriminatorProvider.Groq,
                "hume" => AssistantCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => AssistantCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => AssistantCredentialDiscriminatorProvider.Inworld,
                "langfuse" => AssistantCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => AssistantCredentialDiscriminatorProvider.Lmnt,
                "make" => AssistantCredentialDiscriminatorProvider.Make,
                "minimax" => AssistantCredentialDiscriminatorProvider.Minimax,
                "mistral" => AssistantCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => AssistantCredentialDiscriminatorProvider.Neuphonic,
                "openai" => AssistantCredentialDiscriminatorProvider.Openai,
                "openrouter" => AssistantCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => AssistantCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => AssistantCredentialDiscriminatorProvider.Playht,
                "rime-ai" => AssistantCredentialDiscriminatorProvider.RimeAi,
                "runpod" => AssistantCredentialDiscriminatorProvider.Runpod,
                "s3" => AssistantCredentialDiscriminatorProvider.S3,
                "slack-webhook" => AssistantCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => AssistantCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => AssistantCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => AssistantCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => AssistantCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => AssistantCredentialDiscriminatorProvider.Supabase,
                "tavus" => AssistantCredentialDiscriminatorProvider.Tavus,
                "together-ai" => AssistantCredentialDiscriminatorProvider.TogetherAi,
                "trieve" => AssistantCredentialDiscriminatorProvider.Trieve,
                "twilio" => AssistantCredentialDiscriminatorProvider.Twilio,
                "vonage" => AssistantCredentialDiscriminatorProvider.Vonage,
                "webhook" => AssistantCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => AssistantCredentialDiscriminatorProvider.Wellsaid,
                "xai" => AssistantCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}