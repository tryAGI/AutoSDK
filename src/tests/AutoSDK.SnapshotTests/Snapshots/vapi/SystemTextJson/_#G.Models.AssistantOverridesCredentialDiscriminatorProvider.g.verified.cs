//HintName: G.Models.AssistantOverridesCredentialDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantOverridesCredentialDiscriminatorProvider
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
    public static class AssistantOverridesCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantOverridesCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                AssistantOverridesCredentialDiscriminatorProvider.Anthropic => "anthropic",
                AssistantOverridesCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                AssistantOverridesCredentialDiscriminatorProvider.Anyscale => "anyscale",
                AssistantOverridesCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                AssistantOverridesCredentialDiscriminatorProvider.Azure => "azure",
                AssistantOverridesCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                AssistantOverridesCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                AssistantOverridesCredentialDiscriminatorProvider.Cartesia => "cartesia",
                AssistantOverridesCredentialDiscriminatorProvider.Cerebras => "cerebras",
                AssistantOverridesCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                AssistantOverridesCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                AssistantOverridesCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                AssistantOverridesCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                AssistantOverridesCredentialDiscriminatorProvider.Deepgram => "deepgram",
                AssistantOverridesCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                AssistantOverridesCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                AssistantOverridesCredentialDiscriminatorProvider.Email => "email",
                AssistantOverridesCredentialDiscriminatorProvider.Gcp => "gcp",
                AssistantOverridesCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                AssistantOverridesCredentialDiscriminatorProvider.Gladia => "gladia",
                AssistantOverridesCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                AssistantOverridesCredentialDiscriminatorProvider.Google => "google",
                AssistantOverridesCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                AssistantOverridesCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                AssistantOverridesCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                AssistantOverridesCredentialDiscriminatorProvider.Groq => "groq",
                AssistantOverridesCredentialDiscriminatorProvider.Hume => "hume",
                AssistantOverridesCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                AssistantOverridesCredentialDiscriminatorProvider.Inworld => "inworld",
                AssistantOverridesCredentialDiscriminatorProvider.Langfuse => "langfuse",
                AssistantOverridesCredentialDiscriminatorProvider.Lmnt => "lmnt",
                AssistantOverridesCredentialDiscriminatorProvider.Make => "make",
                AssistantOverridesCredentialDiscriminatorProvider.Minimax => "minimax",
                AssistantOverridesCredentialDiscriminatorProvider.Mistral => "mistral",
                AssistantOverridesCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                AssistantOverridesCredentialDiscriminatorProvider.Openai => "openai",
                AssistantOverridesCredentialDiscriminatorProvider.Openrouter => "openrouter",
                AssistantOverridesCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                AssistantOverridesCredentialDiscriminatorProvider.Playht => "playht",
                AssistantOverridesCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                AssistantOverridesCredentialDiscriminatorProvider.Runpod => "runpod",
                AssistantOverridesCredentialDiscriminatorProvider.S3 => "s3",
                AssistantOverridesCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                AssistantOverridesCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                AssistantOverridesCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                AssistantOverridesCredentialDiscriminatorProvider.Soniox => "soniox",
                AssistantOverridesCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                AssistantOverridesCredentialDiscriminatorProvider.Supabase => "supabase",
                AssistantOverridesCredentialDiscriminatorProvider.Tavus => "tavus",
                AssistantOverridesCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                AssistantOverridesCredentialDiscriminatorProvider.Trieve => "trieve",
                AssistantOverridesCredentialDiscriminatorProvider.Twilio => "twilio",
                AssistantOverridesCredentialDiscriminatorProvider.Vonage => "vonage",
                AssistantOverridesCredentialDiscriminatorProvider.Webhook => "webhook",
                AssistantOverridesCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                AssistantOverridesCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantOverridesCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AssistantOverridesCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => AssistantOverridesCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => AssistantOverridesCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => AssistantOverridesCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => AssistantOverridesCredentialDiscriminatorProvider.Azure,
                "azure-openai" => AssistantOverridesCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => AssistantOverridesCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => AssistantOverridesCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => AssistantOverridesCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => AssistantOverridesCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => AssistantOverridesCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => AssistantOverridesCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => AssistantOverridesCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => AssistantOverridesCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => AssistantOverridesCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => AssistantOverridesCredentialDiscriminatorProvider.Elevenlabs,
                "email" => AssistantOverridesCredentialDiscriminatorProvider.Email,
                "gcp" => AssistantOverridesCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => AssistantOverridesCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => AssistantOverridesCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => AssistantOverridesCredentialDiscriminatorProvider.Gohighlevel,
                "google" => AssistantOverridesCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => AssistantOverridesCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => AssistantOverridesCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => AssistantOverridesCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => AssistantOverridesCredentialDiscriminatorProvider.Groq,
                "hume" => AssistantOverridesCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => AssistantOverridesCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => AssistantOverridesCredentialDiscriminatorProvider.Inworld,
                "langfuse" => AssistantOverridesCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => AssistantOverridesCredentialDiscriminatorProvider.Lmnt,
                "make" => AssistantOverridesCredentialDiscriminatorProvider.Make,
                "minimax" => AssistantOverridesCredentialDiscriminatorProvider.Minimax,
                "mistral" => AssistantOverridesCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => AssistantOverridesCredentialDiscriminatorProvider.Neuphonic,
                "openai" => AssistantOverridesCredentialDiscriminatorProvider.Openai,
                "openrouter" => AssistantOverridesCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => AssistantOverridesCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => AssistantOverridesCredentialDiscriminatorProvider.Playht,
                "rime-ai" => AssistantOverridesCredentialDiscriminatorProvider.RimeAi,
                "runpod" => AssistantOverridesCredentialDiscriminatorProvider.Runpod,
                "s3" => AssistantOverridesCredentialDiscriminatorProvider.S3,
                "slack-webhook" => AssistantOverridesCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => AssistantOverridesCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => AssistantOverridesCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => AssistantOverridesCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => AssistantOverridesCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => AssistantOverridesCredentialDiscriminatorProvider.Supabase,
                "tavus" => AssistantOverridesCredentialDiscriminatorProvider.Tavus,
                "together-ai" => AssistantOverridesCredentialDiscriminatorProvider.TogetherAi,
                "trieve" => AssistantOverridesCredentialDiscriminatorProvider.Trieve,
                "twilio" => AssistantOverridesCredentialDiscriminatorProvider.Twilio,
                "vonage" => AssistantOverridesCredentialDiscriminatorProvider.Vonage,
                "webhook" => AssistantOverridesCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => AssistantOverridesCredentialDiscriminatorProvider.Wellsaid,
                "xai" => AssistantOverridesCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}